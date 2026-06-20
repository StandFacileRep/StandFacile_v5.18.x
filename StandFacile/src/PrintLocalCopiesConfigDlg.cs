/*****************************************************
 	NomeFile : PrintLocalCopiesConfigDlg.cs
    Data	 : 14.06.2026
 	Autore   : Mauro Artuso

 *****************************************************/

using System;
using System.Drawing.Printing;
using System.Windows.Forms;

using static StandCommonFiles.ComDef;
using static StandCommonFiles.CommonCl;
using static StandCommonFiles.Printer_Legacy;
using static StandCommonFiles.Printer_Windows;

using static StandFacile.glb;
using static StandFacile.Define;
using static StandFacile.Config;


namespace StandFacile
{
    /// <summary>
    /// Classe per la configurazione delle copie di stampa
    /// </summary>
    public partial class PrintLocalCopiesConfigDlg : Form
    {
#pragma warning disable IDE0044

        /// <summary>riferimento a PrintTicketConfigDlg</summary>
        public static PrintLocalCopiesConfigDlg _rPrintTckConfigDlg;

        readonly ToolTip _tt = new ToolTip
        {
            InitialDelay = 50,
            ShowAlways = true
        };

        /*****************************************************
            vanno restituite solo variabili e non controlli,
            che potrebbero non essere confermati con OK
         *****************************************************/

        static bool _bListinoModificato;

        static PrinterSettings settings = new PrinterSettings();
        static String sDefaultPrinter;

        /// <summary>ottiene flag di modifica listino necessaria</summary>
        public static bool GetListinoModificato() { return _bListinoModificato; }

        /// <summary>ottiene true se la stampante è windows</summary>
        public static bool GetPrinterTypeIsWindows() { return (iSysPrinterType == (int)PRINTER_SEL.STAMPANTE_WINDOWS); }

        /// <summary>ottiene flag di richiesta stampa copia scontrino NoPrice</summary>
        public static bool GetTicketNoPriceCopy() { return _rPrintTckConfigDlg.LC_checkBoxLocalCopy.Checked; }

        /// <summary>imposta il puntatore ai checkBox delle copie</summary>
        CheckBox[] _pCheckBoxCopia = new CheckBox[NUM_SEP_PRINT_GROUPS];

        /// <summary>struct per la gestione degli avvisi e/o errori</summary>
        public static TErrMsg _WrnMsg;

        /// <summary>costruttore</summary>
        public PrintLocalCopiesConfigDlg()
        {
            int i = 0;
            String sLogStr;

            InitializeComponent();

            _rPrintTckConfigDlg = this;

            _tt.SetToolTip(BtnWin, "imposta stampante Windows: USB, LAN, WiFi");
            _tt.SetToolTip(BtnGenPrinterOptions, "impostazioni Generiche stampa");
            _tt.SetToolTip(BtnLegacy, "imposta stampante Legacy: COM, LPT");

            _pCheckBoxCopia[0] = checkBoxCopia_0;
            _pCheckBoxCopia[1] = checkBoxCopia_1;
            _pCheckBoxCopia[2] = checkBoxCopia_2;
            _pCheckBoxCopia[3] = checkBoxCopia_3;
            _pCheckBoxCopia[4] = checkBoxCopia_4;
            _pCheckBoxCopia[5] = checkBoxCopia_5;
            _pCheckBoxCopia[6] = checkBoxCopia_6;
            _pCheckBoxCopia[7] = checkBoxCopia_7;
            _pCheckBoxCopia[8] = checkBoxCopia_8;
            _pCheckBoxCopia[9] = checkBoxCopia_9;

            if (CheckService(CFG_COMMON_STRINGS._HIDE_LEGACY_PRINTER))
            {
                printersGroupBox.Visible = false;
                RadioGroup_PrinterType.Visible = false;

                this.Height = this.Height - printersGroupBox.Height - 20;
            }

            // stampante Windows di Default
            sDefaultPrinter = settings.PrinterName;

            //  l'ultimo elemento del vettore è la stampante messaggi, poi di riepilogo, poi la Locale ( = non quella delle copie)
            sGlbWinPrinterParams.sSumPrinterModel = ReadRegistry(WIN_SUM_PRINTER_MODEL_KEY, sDefaultPrinter);
            sGlbWinPrinterParams.iSumPrinterModel = 0;

            PrintersListCombo.Items.Clear();

            if (!CheckService(CFG_COMMON_STRINGS._HIDE_LEGACY_PRINTER))
                PrintersListCombo.Items.Add(_LEGACY_PRINTER);

            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                PrintersListCombo.Items.Add(printer);

                if (printer == sGlbWinPrinterParams.sSumPrinterModel)
                {
                    if (CheckService(CFG_COMMON_STRINGS._HIDE_LEGACY_PRINTER))
                        sGlbWinPrinterParams.iSumPrinterModel = i;
                    else
                        sGlbWinPrinterParams.iSumPrinterModel = i + 1;

                    sLogStr = String.Format("PrintLocalCopiesConfigDlg : SumPrinter = {0}", sGlbWinPrinterParams.iSumPrinterModel);
                    Logger.Info(sLogStr);
                }

                i++;
            }

            if (PrintersListCombo.Items.Count > 0)
            {
                if ((sGlbWinPrinterParams.iSumPrinterModel >= 0) && (sGlbWinPrinterParams.iSumPrinterModel < PrintersListCombo.Items.Count))
                    PrintersListCombo.SelectedIndex = sGlbWinPrinterParams.iSumPrinterModel;
                else
                    PrintersListCombo.SelectedIndex = 0;
            }

            Init(false);
        }

        /// <summary>
        /// Inizializzazione con lettura dal Registro e dal DataManager
        /// </summary>
        /// <param name="bShow"></param>
        public void Init(bool bShow)
        {
            int iPrinterTypeRadio;

            //inizializzazione stampante windows o Legacy
            iPrinterTypeRadio = ReadRegistry(SYS_PRINTER_TYPE_KEY, (int)PRINTER_SEL.STAMPANTE_WINDOWS);

            if ((iPrinterTypeRadio == (int)PRINTER_SEL.STAMPANTE_WINDOWS) || CheckService(CFG_COMMON_STRINGS._HIDE_LEGACY_PRINTER))

            {
                prt_Windows.Checked = true;
                iSysPrinterType = (int)PRINTER_SEL.STAMPANTE_WINDOWS;
            }
            else
            {
                prt_Legacy.Checked = true;
                iSysPrinterType = (int)PRINTER_SEL.STAMPANTE_LEGACY;
            }

            if (DataManager.CheckIf_CassaSec_and_NDB()) // cassa secondaria e DB
            {
                LC_panelLocalCopies.Enabled = false;
                LC_label1.Enabled = false;
                LC_label2.Enabled = false;
                LC_label3.Enabled = false;
            }
            else
            {
                LC_panelLocalCopies.Enabled = true;
                LC_label1.Enabled = true;
                LC_label2.Enabled = true;
                LC_label3.Enabled = true;
            }

            for (int i = 0; i < NUM_SEP_PRINT_GROUPS; i++)
            {
                if (!String.IsNullOrEmpty(SF_Data.sCopiesGroupsText[i]))
                    _pCheckBoxCopia[i].Text = SF_Data.sCopiesGroupsText[i];

                _tt.SetToolTip(_pCheckBoxCopia[i], "questa descrizione si imposta da:\r\n \"Configurazione Copie in rete\"");

                _pCheckBoxCopia[i].Checked = IsBitSet(SF_Data.iLocalCopyOptions, i);
            }

            LC_checkBox_LocPrices.Checked = IsBitSet(SF_Data.iLocalCopyOptions, (int)LOCAL_COPIES_OPTS.BIT_PRICE_PRINT_ON_COPIES_REQUIRED);

            LC_checkBox_AvoidPrintGroups.Checked = IsBitSet(SF_Data.iLocalCopyOptions, (int)LOCAL_COPIES_OPTS.BIT_AVOIDPRINTGROUPS_PRINT_REQUIRED);

            LC_checkBoxSelectedOnly.Enabled = IsBitSet(SF_Data.iLocalCopyOptions, (int)LOCAL_COPIES_OPTS.BIT_RECEIPT_LOCAL_COPY_REQUIRED);
            LC_checkBoxLocalCopy.Checked = IsBitSet(SF_Data.iLocalCopyOptions, (int)LOCAL_COPIES_OPTS.BIT_RECEIPT_LOCAL_COPY_REQUIRED);

            LC_checkBoxSelectedOnly.Checked = IsBitSet(SF_Data.iLocalCopyOptions, (int)LOCAL_COPIES_OPTS.BIT_SELECTEDONLY_PRINT_REQUIRED);

            LC_checkBoxSingleRowItems.Checked = IsBitSet(SF_Data.iLocalCopyOptions, (int)LOCAL_COPIES_OPTS.BIT_SINGLEROWITEMS_PRINT_REQUIRED);
            LC_checkBoxUnitItems.Checked = IsBitSet(SF_Data.iLocalCopyOptions, (int)LOCAL_COPIES_OPTS.BIT_QUANTITYONE_PRINT_REQUIRED);

            LC_checkBox_CUT.Checked = IsBitSet(SF_Data.iLocalCopyOptions, (int)LOCAL_COPIES_OPTS.BIT_PRINT_GROUPS_CUT_REQUIRED);

            LC_checkBoxRiepilogo.Checked = IsBitSet(SF_Data.iLocalCopyOptions, (int)LOCAL_COPIES_OPTS.BIT_SUMMARY_COPY_REQUIRED);

            CheckBoxNoPrice_CheckedChanged(this, null);
            Timer_Tick(this, null);

            _bListinoModificato = false;

            if (bShow)
            {
                timer.Enabled = true;
                ShowDialog();
            }
            else
                timer.Enabled = false;
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

        private void CheckBoxNoPrice_CheckedChanged(object sender, EventArgs e)
        {
            LC_checkBoxSelectedOnly.Enabled = LC_checkBoxLocalCopy.Checked;
            LC_checkBox_LocPrices.Enabled = LC_checkBoxLocalCopy.Checked;
            LC_checkBoxSingleRowItems.Enabled = LC_checkBoxLocalCopy.Checked;
            LC_checkBoxUnitItems.Enabled = LC_checkBoxLocalCopy.Checked;
            LC_labelWarn2.Enabled = LC_checkBoxLocalCopy.Checked;

            panelCopies.Enabled = LC_checkBoxLocalCopy.Checked && LC_checkBoxSelectedOnly.Checked;
        }

        private void CheckBoxSingleRowItems_CheckedChanged(object sender, EventArgs e)
        {
            if (LC_checkBoxSingleRowItems.Checked)
                LC_checkBoxUnitItems.Checked = false;
        }

        private void CheckBoxUnitItems_CheckedChanged(object sender, EventArgs e)
        {
            if (LC_checkBoxUnitItems.Checked)
                LC_checkBoxSingleRowItems.Checked = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LC_checkBox_CUT.Enabled = LC_checkBoxLocalCopy.Checked && (!LC_checkBox_AvoidPrintGroups.Checked || !LC_checkBoxSingleRowItems.Checked && !LC_checkBoxUnitItems.Checked);

            LC_checkBox_AvoidPrintGroups.Enabled = LC_checkBoxLocalCopy.Checked && LC_checkBoxSelectedOnly.Checked && (LC_checkBoxSingleRowItems.Checked || LC_checkBoxUnitItems.Checked);

            PrintersListCombo.Enabled = LC_checkBoxRiepilogo.Checked;
            BtnPrintCheck.Enabled = LC_checkBoxRiepilogo.Checked;
            LC_label4.Enabled = LC_checkBoxRiepilogo.Checked;
            LC_label5.Enabled = LC_checkBoxRiepilogo.Checked;
        }

        private void LinkLbl_Mnu_CCR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();

            PrintNetCopiesConfigDlg._rPrintConfigDlg.Init(true);

            if (PrintNetCopiesConfigDlg.GetListinoModificato())
                DataManager.SalvaListino();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        private void BtnPrintCheck_Click(object sender, EventArgs e)
        {
            String sTmp, sFileToPrint;

            sFileToPrint = BuildSampleText();

            if (PrintNetCopiesConfigDlg.GetPrinterTypeIsWindows(PrintersListCombo.Text))
                PrintFile(sFileToPrint, sGlbWinPrinterParams, 0, PrintersListCombo.Text);
            else
                PrintFile(sFileToPrint, sGlbLegacyPrinterParams, (int)PRINT_QUEUE_ACTION.PRINT_NOW);

            sTmp = String.Format("PrintLocalCopiesConfigDlg : printSampleText({0}) {1}", PrintersListCombo.SelectedIndex, sFileToPrint);
            Logger.Info(sTmp);

        }

        /**************************************************
	        letture dai controlli dalle variabili per la
	        scrittura nel registro
         **************************************************/
        private void BtnOK_Click(object sender, EventArgs e)
        {
            int i, iLocalCopyOptions;

            iLocalCopyOptions = 0;

            for (i = 0; i < NUM_SEP_PRINT_GROUPS; i++)
            {
                if (_pCheckBoxCopia[i].Checked)
                    iLocalCopyOptions = SetBit(iLocalCopyOptions, i);
            }

            iLocalCopyOptions = UpdateBit(iLocalCopyOptions, LC_checkBox_LocPrices.Checked, (int)LOCAL_COPIES_OPTS.BIT_PRICE_PRINT_ON_COPIES_REQUIRED);

            iLocalCopyOptions = UpdateBit(iLocalCopyOptions, LC_checkBox_AvoidPrintGroups.Checked, (int)LOCAL_COPIES_OPTS.BIT_AVOIDPRINTGROUPS_PRINT_REQUIRED);

            iLocalCopyOptions = UpdateBit(iLocalCopyOptions, LC_checkBoxLocalCopy.Checked, (int)LOCAL_COPIES_OPTS.BIT_RECEIPT_LOCAL_COPY_REQUIRED);

            iLocalCopyOptions = UpdateBit(iLocalCopyOptions, LC_checkBoxSelectedOnly.Checked, (int)LOCAL_COPIES_OPTS.BIT_SELECTEDONLY_PRINT_REQUIRED);

            iLocalCopyOptions = UpdateBit(iLocalCopyOptions, LC_checkBoxSingleRowItems.Checked, (int)LOCAL_COPIES_OPTS.BIT_SINGLEROWITEMS_PRINT_REQUIRED);

            iLocalCopyOptions = UpdateBit(iLocalCopyOptions, LC_checkBoxUnitItems.Checked, (int)LOCAL_COPIES_OPTS.BIT_QUANTITYONE_PRINT_REQUIRED);

            iLocalCopyOptions = UpdateBit(iLocalCopyOptions, LC_checkBox_CUT.Checked, (int)LOCAL_COPIES_OPTS.BIT_PRINT_GROUPS_CUT_REQUIRED);

            iLocalCopyOptions = UpdateBit(iLocalCopyOptions, LC_checkBoxRiepilogo.Checked, (int)LOCAL_COPIES_OPTS.BIT_SUMMARY_COPY_REQUIRED);

            // controllo _bListinoModificato per gestione della stampa QuantitàUno, salvataggio in : SF_Data[]
            if (SF_Data.iLocalCopyOptions != iLocalCopyOptions)
            {
                _bListinoModificato = true;

                SF_Data.iLocalCopyOptions = iLocalCopyOptions;
            }

            if (prt_Windows.Checked || CheckService(CFG_COMMON_STRINGS._HIDE_LEGACY_PRINTER))
            {
                WriteRegistry(SYS_PRINTER_TYPE_KEY, (int)PRINTER_SEL.STAMPANTE_WINDOWS);
                iSysPrinterType = (int)PRINTER_SEL.STAMPANTE_WINDOWS;
                prt_Windows.Checked = true;
            }
            else
            {
                WriteRegistry(SYS_PRINTER_TYPE_KEY, (int)PRINTER_SEL.STAMPANTE_LEGACY);
                iSysPrinterType = (int)PRINTER_SEL.STAMPANTE_LEGACY;
                prt_Legacy.Checked = true;
            }

            // memorizza se serve la stampante selezionata
            if (sGlbWinPrinterParams.sSumPrinterModel != PrintersListCombo.Text)
            {
                sGlbWinPrinterParams.sSumPrinterModel = PrintersListCombo.Text;
                sGlbWinPrinterParams.iSumPrinterModel = PrintersListCombo.SelectedIndex;

                WriteRegistry(WIN_SUM_PRINTER_MODEL_KEY, sGlbWinPrinterParams.sSumPrinterModel);
            }

            Logger.Info("PrintLocalCopiesConfigDlg OK");

            timer.Enabled = false;
            Close();
        }

    }
}
