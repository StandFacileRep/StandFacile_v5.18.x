/***********************************************
  	NomeFile : StandCucina/Program.cs
	Data	 : 09.10.2026
  	Autore   : Mauro Artuso
 ***********************************************/

using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

using NLog;

using StandCommonFiles;

using static StandCommonFiles.ComDef;
using static StandCommonFiles.CommonCl;

namespace StandFacile
{
    static class Program
    {
#pragma warning disable IDE0060

        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>

        static Mutex _mx;
        public static StandFacile_DB.dBaseIntf_my _rBdBaseIntf_my;
        public static StandFacile_DB.dBaseIntf_pg _rBdBaseIntf_pg;

        [STAThread]
        static void Main()
        {
            int iLoop = 5;
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

            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                // Nome dell'assembly richiesto
                string name = new AssemblyName(args.Name).Name;

                // esclude false DLL
                if (!args.Name.Contains("StandCucina.resources") && !args.Name.Contains("StandCucina_no_dll.resources"))
                    MessageBox.Show("DLL non trovata: " + args.Name + " \n");

                return null;
            };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            // Caricamento configurazione
            Config rConfig = new Config();

            LoggerNLog.ConfigureAppender();
            LogManager.Configuration = LoggerNLog.config;

            sTmp = "\n\n";
            sTmp += "******************************\n";
            sTmp += "**  AVVIO LOG StandCucina   **\n";
            sTmp += "**  ";
            sTmp += String.Format("{0,-10} {1,16}", RELEASE_SW, "**\n");
            sTmp += "******************************";

            CommonCl.Logger.Info(sTmp);

            // deve stare qui subito dopo il LogServer !
            MessageDlg rMessageDlg = new MessageDlg();

            // Avvio del server di stampa
            Printer_Legacy.Init();

            FrmMain rFrmMain = new FrmMain();

            LogForm rLogForm = new LogForm();

            int iNDbMode = ReadRegistry(DB_MODE_KEY, (int)DB_MODE.MYSQL);

            if (iNDbMode == (int)DB_MODE.MYSQL)
                _rBdBaseIntf_my = new StandFacile_DB.dBaseIntf_my();
            else
                if (iNDbMode == (int)DB_MODE.POSTGRES)
                    _rBdBaseIntf_pg = new StandFacile_DB.dBaseIntf_pg();

            dBaseIntf rdBaseIntf = new dBaseIntf();

            NetConfigLightDlg rNetConfigLightDlg = new NetConfigLightDlg();

            GenPrinterDlg rGenericPrintDlg = new GenPrinterDlg();

            Barcode_EAN13 rBarcode_EAN13 = new Barcode_EAN13();

            // inizializza i parametri di stampa
            LegacyPrinterDlg rLegacyPrinterDlg = new LegacyPrinterDlg();

            // inizializza i parametri di stampa
            WinPrinterDlg rWinPrinterDlg = new WinPrinterDlg();

            // inizializza i parametri di stampa
            PrintConfigLightDlg rPrintConfigLightDlg = new PrintConfigLightDlg();

            // Avvio gestione delle notifiche UDP
            UdpBroadcastService rUdpService = new UdpBroadcastService();

            rFrmMain.Init();

            bApplicationRuns = true;

            // avvia la form principale
            Application.Run(rFrmMain);

            _mx.ReleaseMutex();
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Eccezione non gestita nel Thread");
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show((e.ExceptionObject as Exception).Message, "Eccezione non gestita nell'UI");
        }

    }
}
