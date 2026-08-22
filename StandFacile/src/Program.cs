/*********************************************************
    NomeFile : StandFacile
    Data	 : 11.08.2026
    Autore   : Mauro Artuso

    Avvia le classi visuali e non, nell'ordine corretto
 *********************************************************/

using Microsoft.Win32;
using NLog;
using StandCommonFiles;
using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using static StandCommonFiles.ComDef;
using static StandCommonFiles.CommonCl;
using static System.Convert;

namespace StandFacile
{
    static class Program
    {
        public static StandFacile_DB.dBaseIntf_ql _rBdBaseIntf_ql;
        public static StandFacile_DB.dBaseIntf_my _rBdBaseIntf_my;
        public static StandFacile_DB.dBaseIntf_pg _rBdBaseIntf_pg;

        public static dBaseTunnel_my _rdBaseTunnel_my;

        static Mutex _mx;

        static Assembly ResolveAssembly(object sender, ResolveEventArgs args)
        {
            //MessageBox.Show("DLL non trovata: " + args.Name + " \n");

            return null;
        }

        [STAThread]
        public static void Main()
        {
            int iNDbMode, iLoop = 5;
            bool bStandIsRunning = false;
            String sTmp;

            do
            {
                _mx = new Mutex(true, Application.ProductName.ToString(), out bStandIsRunning);

                if (!bStandIsRunning)
                {
                    if (iLoop > 0)
                    {
                        Thread.Sleep(1000); // attendi
                        iLoop--;
                        _mx.Close();
                    }
                    else
                        return; // esci dal programma
                }
                else
                    break;
            }
            while (true);


            // verifica l'esistenza della chiave KEY_STAND_FACILE eventualmente la crea
            if (Registry.GetValue(Define.KEY_STAND_FACILE, "iGridRows", DEF_GRID_NROWS) == null)
                Registry.SetValue(Define.KEY_STAND_FACILE, "iGridRows", DEF_GRID_NROWS);

            // Inizializza le directories dopo che è definita la data
            DataManager rDataManager = new DataManager();

            LoggerNLog.ConfigureAppender();
            LogManager.Configuration = LoggerNLog.config;

            sTmp = "\n\n";
            sTmp += "******************************\n";
            sTmp += "**  AVVIO LOG StandFacile   **\n";
            sTmp += "**  ";
            sTmp += String.Format("{0,-10} {1,16}", RELEASE_SW, "**\n");
            sTmp += "******************************";

            CommonCl.Logger.Info(sTmp);

            // Caricamento configurazione
            Config rConfig = new Config();

            iNDbMode = ReadRegistry(DB_MODE_KEY, (int)DB_MODE.SQLITE);

            if (iNDbMode == (int)DB_MODE.SQLITE)
                _rBdBaseIntf_ql = new StandFacile_DB.dBaseIntf_ql();
            else
                if (iNDbMode == (int)DB_MODE.MYSQL)
                    _rBdBaseIntf_my = new StandFacile_DB.dBaseIntf_my();
                else
                    if (iNDbMode == (int)DB_MODE.POSTGRES)
                        _rBdBaseIntf_pg = new StandFacile_DB.dBaseIntf_pg();

            dBaseIntf rBdBaseIntf = new dBaseIntf();

            _rdBaseTunnel_my = new dBaseTunnel_my();

            Barcode_EAN13 rBarcode_EAN13 = new Barcode_EAN13();

            //Barcode_EAN13.BuildBarcodeID("111308221001");

            if (!Config.CheckService(CFG_COMMON_STRINGS._HIDE_LEGACY_PRINTER))
            {
                // Avvio del server di stampa
                Printer_Legacy.Init();
            }

            //AppDomain.CurrentDomain.AssemblyResolve += ResolveAssembly;

            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                // Nome dell'assembly richiesto
                string name = new AssemblyName(args.Name).Name;

                // esclude false DLL
                if (!args.Name.Contains("StandFacile.resources"))
                    MessageBox.Show("DLL non trovata: " + args.Name + " \n");

                return null;
            };

            // Precede tutte le classi visuali
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            // inizializza i parametri di stampa
            LegacyPrinterDlg rLegacyPrinterDlg = new LegacyPrinterDlg();

            // Avvio della Form di gestione Sconti prima di leggere dal Listino
            ScontoDlg rScontoDlg = new ScontoDlg();

            // gestisce la tipologia di Cassa memorizzando i server con
            // cui è possibile comunicare
            NetConfigDlg rTipoCassaDlg = new NetConfigDlg();

            // Caricamento Listino e Dati
            rDataManager.Init();

            // dopo caricamento Listino
            OptionsDlg rOptionsDlg = new OptionsDlg();

            // inizializza la form di selezione data dei reports
            SelDataDlg rSelDataDlg = new SelDataDlg();

            // inizializza i parametri di stampa Windows
            WinPrinterDlg rWinPrinterDlg = new WinPrinterDlg();

            // Avvio della Form di verifica iniziale della data,
            // va messo dopo WinPrinterDlg, rDataManager.Init()
            StartDlg rStartDlg = new StartDlg();

            GenPrinterDlg rGenericPrintDlg = new GenPrinterDlg();

            // inizializza le impostazioni di stampa copie locali
            PrintLocalCopiesConfigDlg rPrintConfigReceiptDlg = new PrintLocalCopiesConfigDlg();

            // inizializza i parametri di stampa
            PrintNetCopiesConfigDlg rFrmPrintConfig = new PrintNetCopiesConfigDlg();

            // avvia la form principale
            FrmMain rFrmMain = new FrmMain();

            // Avvio della Form di anteprima scontrino
            AnteprimaDlg rAnteprimaDlg = new AnteprimaDlg();

            // Avvio della funzione di esecuzione Test Automatici
            TestManager rTestManager = new TestManager();

            // Avvio gestione delle notifiche UDP
            UdpBroadcastService rUdpService = new UdpBroadcastService();

            rFrmMain.Init();
            rFrmMain.Show();

            bApplicationRuns = true;

            // avvia la form principale
            Application.Run(rFrmMain);

            _mx.ReleaseMutex();
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Eccezione non gestita nel Thread");
            CommonCl.Logger.Info(e.Exception.Message);
            //StopLogServer();
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show((e.ExceptionObject as Exception).Message, "Eccezione non gestita nell'UI");
            CommonCl.Logger.Info((e.ExceptionObject as Exception).Message); // non funziona
        }

    }
}
