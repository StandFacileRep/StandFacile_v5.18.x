/***********************************************
  	NomeFile : StandOrdini/Program.cs
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
#pragma warning disable IDE0059

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
                if (!args.Name.Contains("StandOrdini.resources") && !args.Name.Contains("StandOrdini_no_dll.resources"))
                    MessageBox.Show("DLL non trovata: " + args.Name + " \n");

                return null;
            };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoggerNLog.ConfigureAppender();
            LogManager.Configuration = LoggerNLog.config;

            sTmp = "\n\n";
            sTmp += "******************************\n";
            sTmp += "**  AVVIO LOG StandOrdini   **\n";
            sTmp += "**  ";
            sTmp += String.Format("{0,-10} {1,16}", RELEASE_SW, "**\n");
            sTmp += "******************************";

            CommonCl.Logger.Info(sTmp);

            // deve stare qui subito dopo il LogServer !
            MessageDlg rMessageDlg = new MessageDlg();

            FrmMain rFrmMain = new FrmMain();

            int iNDbMode = ReadRegistry(DB_MODE_KEY, (int)DB_MODE.MYSQL);

            if (iNDbMode == (int)DB_MODE.MYSQL)
                _rBdBaseIntf_my = new StandFacile_DB.dBaseIntf_my();
            else
                if (iNDbMode == (int)DB_MODE.POSTGRES)
                    _rBdBaseIntf_pg = new StandFacile_DB.dBaseIntf_pg();

            dBaseIntf rdBaseIntf = new dBaseIntf();

            NetConfigLightDlg rNetConfigLightDlg = new NetConfigLightDlg();

            SpeechSynth rSpeechSynth = new SpeechSynth();
            SpeechSynth.rSpeechSynth.Init(false);

            // Avvio gestione delle notifiche UDP
            UdpBroadcastService rUdpService = new UdpBroadcastService();

            rFrmMain.Init(); // ultimo

            bApplicationRuns = true;

            // avvia la form principale
            Application.Run(rFrmMain);

            _mx.ReleaseMutex();
        }
    }
}
