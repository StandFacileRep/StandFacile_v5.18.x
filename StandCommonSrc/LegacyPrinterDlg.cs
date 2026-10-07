/*****************************************************************************
	NomeFile : StandCommonSrc/LegacyPrinterDlg.cs
    Data	 : 10.09.2025
	Autore   : Mauro Artuso
 ****************************************************************************/

using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

using StandCommonFiles;
using static StandCommonFiles.ComDef;
using static StandCommonFiles.CommonCl;

using static StandCommonFiles.Printer_Legacy;

using static StandFacile.glb;

namespace StandFacile
{
    /// <summary>
    /// classe per la gestione della Form per l'impostazione dei parametri <br/>
    ///  delle stampanti, tutti i dati vengono memorizzati nel registro <br/>
    /// su pressione del tasto OK, la struct sPrinterParam consente di passare <br/>
    /// tutti i parametri alla classe Print_Legacy
    /// </summary>
    public partial class LegacyPrinterDlg : Form
    {
        /// <summary>possibili dimensioni della carta</summary>
        public enum PAPER_SIZE
        {
            /// <summary>enum carta da 57mm</summary>
            S57MM = 0,
            /// <summary>enum carta da 80mm</summary>
            S80MM
        };

        /// <summary>possibi velocità di stampa</summary>
        public enum RANGE
        {
            /// <summary>enum velocità bassa</summary>
            LOW = 0,
            /// <summary>enum velocità media</summary>
            MEDIUM,
            /// <summary>enum velocità alta</summary>
            HIGH
        };

        /// <summary>controllo di flusso</summary>
        public enum FLOW_CONTROL
        {
            /// <summary>enum nessun controllo</summary>
            FLOW_NONE = 0,
            /// <summary>enum controllo RTS/CTS</summary>
            RTS_CTS,
            /// <summary>enum controllo XON/XOFF</summary>
            XON_XOFF
        };

        private bool _bInitComplete = false;

        static TLegacyPrinterParams _sLegacyPrinterParamsCopy = new TLegacyPrinterParams();

        /// <summary>riferimento a LegacyPrinterDlg</summary>
        public static LegacyPrinterDlg rThermPrinterDlg;

        TErrMsg _ErrMsg;

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern SafeFileHandle CreateFile(string lpFileName, FileAccess dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

        /// <summary>costruttore</summary>
        public LegacyPrinterDlg()
        {
            InitializeComponent();

            rThermPrinterDlg = this;

            /************************************************************
             *  i Combo devono essere popolati preventivamente
             *  prima di impostare il SelectedIndex con il max di voci
             ************************************************************/

            PrinterTypeCombo.Items.Clear();

            for (int i = 0; i < MAX_LEGACY_MODELS; i++)
                PrinterTypeCombo.Items.Add(sConstLegacyModels[i]);

            LogoBmpCombo.Items.Clear();
            LogoBmpCombo.Items.Add("no Logo");
            LogoBmpCombo.Items.Add("graphic Logo");
            LogoBmpCombo.Items.Add("Logo bmp 1");
            LogoBmpCombo.Items.Add("Logo bmp 2");
            LogoBmpCombo.Items.Add("Logo bmp 3");
            LogoBmpCombo.Items.Add("Logo bmp 4");

            Init(false);
        }

        /// <summary>
        /// Inizializzazione con lettura dal Registro
        /// </summary>
        public void Init(bool bShow)
        {
            // 8
            sGlbLegacyPrinterParams.iPrinterModel = ReadRegistry(LEGACY_PRINTER_MODEL_KEY, 0);
            sGlbLegacyPrinterParams.iLogoBmp = ReadRegistry("iLegacyLogoBmp", 0);
            sGlbLegacyPrinterParams.iFlowCtrl = ReadRegistry("iLegacyFlowCtrl", (int)FLOW_CONTROL.FLOW_NONE);
            sGlbLegacyPrinterParams.iPaperSize = ReadRegistry("iLegacyPaperSize", 1);
            sGlbLegacyPrinterParams.sPort = ReadRegistry("sLegacyPort", "COM1");

            // *** copia locale ***
            _sLegacyPrinterParamsCopy = sGlbLegacyPrinterParams;

            if (sGlbLegacyPrinterParams.iPrinterModel < PrinterTypeCombo.Items.Count) // controllo sul range 
                PrinterTypeCombo.SelectedIndex = sGlbLegacyPrinterParams.iPrinterModel;
            else
            {
                PrinterTypeCombo.SelectedIndex = 0;
                sGlbLegacyPrinterParams.iPrinterModel = 0;
            }

            if (sGlbLegacyPrinterParams.iLogoBmp < LogoBmpCombo.Items.Count) // controllo sul range
                LogoBmpCombo.SelectedIndex = sGlbLegacyPrinterParams.iLogoBmp;
            else
                LogoBmpCombo.SelectedIndex = 0;

            if (PrinterTypeCombo.SelectedIndex == (int)LEGACY_PRINTER_MODELS.STAMPANTE_TM_T88_SER)
                TP_flow_XON_XOFF.Enabled = true;
            else
                TP_flow_XON_XOFF.Enabled = false;

            switch (sGlbLegacyPrinterParams.iFlowCtrl)
            {
                case (int)FLOW_CONTROL.RTS_CTS:
                    TP_flow_RTS_CTS.Checked = true;
                    break;
                case (int)FLOW_CONTROL.XON_XOFF:
                    TP_flow_XON_XOFF.Checked = true;
                    break;
                default:
                    TP_flow_NONE.Checked = true;
                    break;
            }

            switch (sGlbLegacyPrinterParams.iPaperSize)
            {
                case (int)PAPER_SIZE.S57MM:
                    width57.Checked = true;
                    break;
                case (int)PAPER_SIZE.S80MM:
                    width80.Checked = true;
                    break;
                default:
                    width80.Checked = true;
                    break;
            }


            FindPorts();

            PORT_Combo.Text = sGlbLegacyPrinterParams.sPort;

            // si sono inizializzati i Combo
            _bInitComplete = true;

            AggiornaAspettoControlli();

            if ((iSysPrinterType == (int)PRINTER_TYPE.STAMPANTE_LEGACY) || bShow)
            {
                if (!Printer_Legacy.PortVerify(sGlbLegacyPrinterParams))
                {
                    _ErrMsg.sMsg = ReadRegistry("sLegacyPort", "COMx");
                    _ErrMsg.iErrID = WRN_CNA;
                    WarningManager(_ErrMsg);
                }
            }

            if (bShow)
                // no ShowDialog altrimenti si perde il Focus su eventuali MessageDlg 
                // che quindi non si riesce più a chiudere
                rThermPrinterDlg.Show();

            return;
        }

        /// <summary>
        /// funzione che inposta tutti i parametri necessari
        /// alla classe prelevandoli dai controlli e non dal Registro
        /// </summary>
        public void UpdateLegacyPrinterParam()
        {
            _sLegacyPrinterParamsCopy.iPrinterModel = PrinterTypeCombo.SelectedIndex;
            _sLegacyPrinterParamsCopy.iLogoBmp = LogoBmpCombo.SelectedIndex;

            _sLegacyPrinterParamsCopy.sPort = PORT_Combo.Text;

            if (TP_flow_RTS_CTS.Checked)
                _sLegacyPrinterParamsCopy.iFlowCtrl = (int)FLOW_CONTROL.RTS_CTS;
            else if (TP_flow_XON_XOFF.Checked)
                _sLegacyPrinterParamsCopy.iFlowCtrl = (int)FLOW_CONTROL.XON_XOFF;
            else
                _sLegacyPrinterParamsCopy.iFlowCtrl = (int)FLOW_CONTROL.FLOW_NONE;

            if (width57.Checked)
                _sLegacyPrinterParamsCopy.iPaperSize = (int)PAPER_SIZE.S57MM;
            else
                _sLegacyPrinterParamsCopy.iPaperSize = (int)PAPER_SIZE.S80MM;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            // Refresh lettura controlli
            UpdateLegacyPrinterParam();

            // acquisizione impostazioni
            sGlbLegacyPrinterParams = _sLegacyPrinterParamsCopy;

            // 8 scritture nel registro
            WriteRegistry(LEGACY_PRINTER_MODEL_KEY, sGlbLegacyPrinterParams.iPrinterModel);
            WriteRegistry("iLegacyLogoBmp", sGlbLegacyPrinterParams.iLogoBmp);
            WriteRegistry("iLegacyFlowCtrl", sGlbLegacyPrinterParams.iFlowCtrl);
            WriteRegistry("iLegacyPaperSize", sGlbLegacyPrinterParams.iPaperSize);
            WriteRegistry("sLegacyPort", sGlbLegacyPrinterParams.sPort);

            if (!PortVerify(sGlbLegacyPrinterParams))
            {
                _ErrMsg.sMsg = ReadRegistry("sLegacyPort", "COMx");
                _ErrMsg.iErrID = WRN_CNA;
                WarningManager(_ErrMsg);
            }

            Hide();
            Logger.Info("ThermPrinter : OKBtnClick");
        }

        /**************************************************************
         * funzione che aggiorna l'aspetto dei bottoni sulla base delle
         * caratteristiche possibili per ciascuna stampante,
         * come regola i controlli sono stabiliti a mano e non vengono
         * letti dal Registry
         **************************************************************/
        private void AggiornaAspettoControlli()
        {
            // altrimenti viene percorsa inizialmente con dati sbagliati
            if (!_bInitComplete)
                return;

            PORT_Combo.Text = _sLegacyPrinterParamsCopy.sPort;

            switch (PrinterTypeCombo.SelectedIndex)
            {
                case (int)LEGACY_PRINTER_MODELS.STAMPANTE_TM_T88_SER:
                case (int)LEGACY_PRINTER_MODELS.STAMPANTE_TM_L90_LPT:

                    width80.Checked = true;
                    TP_PaperSizeGroupBox.Enabled = false;

                    LogoBmpCombo.Enabled = true;

                    if (PrinterTypeCombo.SelectedIndex == (int)LEGACY_PRINTER_MODELS.STAMPANTE_TM_T88_SER)
                    {
                        Lbl_ImpSer.Enabled = true;
                        TP_SettingsGroupBox.Enabled = true;

                        TP_FlowRadio.Enabled = true;
                        TP_flow_NONE.Enabled = true;
                        TP_flow_RTS_CTS.Enabled = true;
                        TP_flow_XON_XOFF.Enabled = true;

                        if (TP_flow_RTS_CTS.Checked)
                            _sLegacyPrinterParamsCopy.iFlowCtrl = (int)FLOW_CONTROL.RTS_CTS;
                        else if (TP_flow_XON_XOFF.Checked)
                            _sLegacyPrinterParamsCopy.iFlowCtrl = (int)FLOW_CONTROL.XON_XOFF;
                        else
                            _sLegacyPrinterParamsCopy.iFlowCtrl = (int)FLOW_CONTROL.FLOW_NONE;

                    }
                    else
                    {
                        Lbl_ImpSer.Enabled = false;
                        TP_SettingsGroupBox.Enabled = false;

                        TP_FlowRadio.Enabled = false;
                        TP_flow_NONE.Enabled = false;
                        TP_flow_RTS_CTS.Enabled = false;
                        TP_flow_XON_XOFF.Enabled = false;
                    }

                    break;

                default:
                    TP_flow_NONE.Enabled = false;
                    TP_flow_RTS_CTS.Enabled = false;
                    TP_flow_XON_XOFF.Enabled = false;
                    PORT_Combo.Enabled = false;

                    TP_PaperSizeGroupBox.Enabled = false;
                    LogoBmpCombo.Enabled = false;

                    break;
            }
        }

        // funzione chiamata da variazioni di qualsiasi controllo
        private void PrinterTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_bInitComplete)
                return;

            UpdateLegacyPrinterParam();

            AggiornaAspettoControlli();

            FindPorts();

            // reset selezione
            if (PORT_Combo.Items.Count > 0)
                PORT_Combo.SelectedIndex = 0;
        }

        private void BtnTestoProva_Click(object sender, EventArgs e)
        {
            UpdateLegacyPrinterParam();

            Printer_Legacy.PrintSampleText(_sLegacyPrinterParamsCopy);
        }

        private void FindPorts()
        {
            // ***** ricerca COMs *****

            string[] sCOM_PortName = SerialPort.GetPortNames();

            if (Lbl_ImpSer.Enabled)
            {
                PORT_Combo.Items.Clear();
                foreach (string port in sCOM_PortName)

                    PORT_Combo.Items.Add(port);
            }
            else
            {
                PORT_Combo.Items.Clear();

                // ***** ricerca LPTs (non c'è la classe ParallelPort) *****
                for (int i = 1; i < 10; i++)
                {
                    String sLPT_PortName = String.Format("LPT{0}", i);

                    bool bAvailable = false;

                    // Try to open the port
                    SafeFileHandle hLPT = CreateFile(sLPT_PortName, FileAccess.Write, 0, IntPtr.Zero, FileMode.Open, 0, IntPtr.Zero);

                    if (!hLPT.IsInvalid)
                    {
                        //bInstalled = true;
                        bAvailable = true;
                        hLPT.Close();
                    }

                    if (bAvailable)
                    {
                        sLPT_PortName = String.Format("LPT{0}", i);
                        PORT_Combo.Items.Add(sLPT_PortName);
                    }
                }
            }
        }

        private void ThermPrinterDlg_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            // evita la distruzione della form creando una eccezione alla successiva apertura
            e.Cancel = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

    }
}


