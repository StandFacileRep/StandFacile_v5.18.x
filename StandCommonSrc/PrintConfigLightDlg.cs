/*****************************************************
 	NomeFile : StandCommonSrc/PrintConfigLightDlg.cs
    Data	 : 06.12.2024
 	Autore   : Mauro Artuso

 *****************************************************/

using System;
using System.Windows.Forms;
using static StandCommonFiles.CommonCl;

namespace StandFacile
{
    /// <summary>
    /// Classe per la configurazione delle copie di stampa
    /// </summary>
    public partial class PrintConfigLightDlg : Form
    {
        /// <summary>riferimento a PrintConfigLightDlg</summary>
        public static PrintConfigLightDlg rPrintConfigLightDlg;

        readonly ToolTip _tt = new ToolTip
        {
            InitialDelay = 50,
            ShowAlways = true
        };

        /*****************************************************
            vanno restituite solo variabili e non controlli,
            che potrebbero non essere confermati con OK
         *****************************************************/

        /// <summary>costruttore</summary>
        public PrintConfigLightDlg()
        {
            InitializeComponent();

            rPrintConfigLightDlg = this;

            _tt.SetToolTip(BtnWin, "imposta stampante Windows: USB, LAN, WiFi");
            _tt.SetToolTip(BtnCommonPrintSetup, "opzioni Comuni di stampa");
            _tt.SetToolTip(BtnLegacy, "imposta stampante Legacy: COM, LPT");

            Init(false);
        }

        /// <summary>
        /// Inizializzazione con lettura dal Registro e dal DataManager
        /// </summary>
        /// <param name="bShow"></param>
        public void Init(bool bShow)
        {
            if (bShow)
                ShowDialog();
        }

        /**************************************************
	        letture dai controlli dalle variabili per la
	        scrittura nel registro
         **************************************************/
        private void BtnOK_Click(object sender, EventArgs e)
        {
            Logger.Info("PrintConfigLightDlg OK");
        }

        private void BtnGeneric_Click(object sender, EventArgs e)
        {
            GenPrinterDlg._rGenPrinterDlg.Init(true);
        }

        private void BtnLegacy_Click(object sender, EventArgs e)
        {
            LegacyPrinterDlg.rThermPrinterDlg.Init(true);
        }

        private void BtnWin_Click(object sender, EventArgs e)
        {
            WinPrinterDlg._rWinPrinterDlg.Init(true);
        }

    }
}
