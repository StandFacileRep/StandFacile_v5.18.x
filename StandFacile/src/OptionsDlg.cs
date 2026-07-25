/***************************************************
	NomeFile : StandFacile\OptionsDlg.cs
    Data	 : 25.07.2026
	Autore   : Mauro Artuso
 ***************************************************/

using System;
using System.Windows.Forms;

using static StandCommonFiles.ComDef;
using static StandCommonFiles.CommonCl;


using static StandFacile.glb;
using static StandFacile.Define;

namespace StandFacile
{
    /// <summary></summary>
    public partial class OptionsDlg : Form
    {
        static int _iDispMngStatus, _iColorThemeIndex;

        static bool _bListinoModificato;

        /// <summary>riferimento a dBaseIntf</summary>
        public static OptionsDlg _rOptionsDlg;

        /// <summary>ottiene flag di modifica listino necessaria</summary>
        public static bool GetListinoModificato() { return _bListinoModificato; }

        /// <summary>ottiene indice del tema dei colori</summary>
        public static int GetColorThemeIndex() { return _iColorThemeIndex; }

        /// <summary>ottiene flag di visualizzazione totale scontrino precedente</summary>
        public bool GetShowPrevReceipt() { return MO_checkBoxShowPrevReceipt.Checked; }

        /// <summary>ottiene flag di avvio stampa Scontrino con il tasto Enter</summary>
        public bool GetEnterPrintReceipt() { return MO_checkBox_Enter.Checked; }

        /// <summary>ottiene flag di consenso agli articoli con Prezzo zero Euro</summary>
        public bool GetZeroPriceEnabled() { return MO_checkBox_ZeroPriceItems.Checked; }

        /// <summary>ottiene flag di inserimento coperti obbligatorio</summary>
        public static bool GetPlaceSettings_MandatoryFlag() { return IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_PLACE_SETTINGS_REQUIRED); }

        /// <summary>ottiene flag di inserimento tavolo obbligatorio</summary>
        public static bool GetTable_MandatoryFlag() { return IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_TABLE_REQUIRED); }

        /// <summary>ottiene flag di inserimento nome obbligatorio</summary>
        public static bool GetName_MandatoryFlag() { return IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_NAME_REQUIRED); }

        /// <summary>ottiene flag di inserimento pagamento obbligatorio</summary>
        public static bool GetPayment_MandatoryFlag() { return IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_PAYMENT_REQUIRED); }

        /// <summary>ottiene flag di modo Touch</summary>
        public static bool GetTouchModeEnabled() { return IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_TOUCH_MODE_REQUIRED); }

        /// <summary>ottiene flag di modo Touch</summary>
        public static bool GetDirectTapIncEnabled() { return IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_DIRECT_TAP_INC); }

        /// <summary>ottiene flag di visualizzazione interna dell'Anteprima</summary>
        public static bool GetShowExternalPreview()
        {
            return IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_SHOW_EXTERNAL_PREVIEW) || PREVIEW_DEBUG;
        }

        /// <summary>ottiene flag di inserimento CAP obbligatorio</summary>
        public static bool Get_CAP_MandatoryFlag() { return IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_CAP_REQUIRED); }

        /// <summary>ottiene flag di visualizzazione CAP</summary>
        public static bool Get_CAP_ShowFlag() { return IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_SHOW_CAP_EDIT); }

        readonly ToolTip _tt = new ToolTip
        {
            InitialDelay = 50,
            ShowAlways = true
        };

        /// <summary>costruttore</summary>
        public OptionsDlg()
        {

            InitializeComponent();

            _rOptionsDlg = this;

            _tt.SetToolTip(MO_checkBox_ZeroPriceItems, "consente o meno Articoli con Prezzo = zero,\nattenzione che la disattivazione modifica il Listino eliminando eventuali Articoli con prezzo nullo,\nin questo caso si modifica anche il checksum web!");

            _tt.SetToolTip(MO_checkBoxPrivacy, "attiva il modo riservato: si richiede cioè l'inserimento della password per visualizzare gli incassi");

            //_tt.SetToolTip(checkBox_Show_DB_Check, "visualizza o meno il pulsante DB check");
            //_tt.SetToolTip(checkBox_Show_OSKeyb, "visualizza o meno il pulsante tastiera on screen");

            Init(false);
        }

        /// <summary>Inizializzazione dei vari Flag caricati dal Listino e dal Registry</summary>
        public void Init(bool bShow)
        {
            MO_checkBoxPlaceSett.Checked = GetPlaceSettings_MandatoryFlag();
            MO_checkBoxTable.Checked = GetTable_MandatoryFlag();
            MO_checkBox_Name.Checked = GetName_MandatoryFlag();
            MO_checkBox_CAP.Checked = Get_CAP_MandatoryFlag();
            MO_checkBoxPayment.Checked = GetPayment_MandatoryFlag();

            MO_ckBoxExternalPreview.Checked = IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_SHOW_EXTERNAL_PREVIEW);

            MO_checkBox_ZeroPriceItems.Checked = IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_ZERO_PRICE_ITEMS_ALLOWED);
            MO_checkBox_Enter.Checked = IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_ENTER_PRINT_RECEIPT_ENABLED);
            MO_checkBoxPrivacy.Checked = IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_PRIVACY);

            // 0 = visualizzo, 1 = nascondo, tranne MO_checkBox_Show_OSKeyb, MO_checkBox_Show_CAP
            MO_checkBox_ShowSendMsg.Checked = !IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_SHOW_MSG_BUTTON);
            MO_checkBox_ShowTakeAway.Checked = !IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_SHOW_TAKEAWAY_BUTTON);
            MO_checkBox_ShowDiscount.Checked = !IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_SHOW_DISCOUNT_BUTTON);
            MO_checkBox_Show_DB_Check.Checked = !IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_SHOW_DB_BUTTON);

            // altra regola per Btn_OSKeyb
            MO_checkBox_Show_OSKeyb.Checked = IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_SHOW_TOUCH_KEYB_BUTTON);
            MO_checkBox_Show_CAP.Checked = IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_SHOW_CAP_EDIT);

            if (DataManager.CheckIf_CassaSec_and_NDB()) // cassa secondaria e DB
            {
                MO_checkBox_InitialAvailabilityDlg.Enabled = false;
                MO_checkBox_InitialAvailabilityDlg.Checked = false;

                MO_checkBoxPlaceSett.Enabled = false;
                MO_checkBoxTable.Enabled = false;
                MO_checkBox_Name.Enabled = false;
                MO_checkBoxPayment.Enabled = false;
                MO_checkBoxPrivacy.Enabled = false;
                MO_checkBox_Enter.Enabled = false;
                MO_checkBox_CAP.Enabled = false;
                MO_checkBox_ZeroPriceItems.Enabled = false;

                panelShowHideButtons.Enabled = false;
            }
            else
            {
                _iDispMngStatus = ReadRegistry(DISP_DLG_MNG_KEY, SetBit(0, BIT_SHOW_DISP_DLG));

                MO_checkBox_InitialAvailabilityDlg.Enabled = true;
                MO_checkBox_InitialAvailabilityDlg.Checked = IsBitSet(_iDispMngStatus, BIT_SHOW_DISP_DLG);

                MO_checkBoxPlaceSett.Enabled = true;
                MO_checkBoxTable.Enabled = true;
                MO_checkBox_Name.Enabled = true;
                MO_checkBoxPayment.Enabled = true;
                MO_checkBoxPrivacy.Enabled = true;
                MO_checkBox_Enter.Enabled = true;
                MO_checkBox_CAP.Enabled = true;
                MO_checkBox_ZeroPriceItems.Enabled = true;

                panelShowHideButtons.Enabled = true;
            }

            // letto dal Registry
            MO_checkBoxShowPrevReceipt.Checked = (ReadRegistry(VIEW_PREV_RECEIPT_KEY, 0) == 1);

            _iColorThemeIndex = ReadRegistry(COLOR_THEME_KEY, 1);

            if (_iColorThemeIndex < NUM_COLOR_THEMES)
                comboColorTheme.SelectedIndex = _iColorThemeIndex;
            else
                comboColorTheme.SelectedIndex = 0;

            _bListinoModificato = false;

            if (bShow)
                ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MO_checkBoxPlaceSett.Checked = false;
            MO_checkBoxTable.Checked = false;
            MO_checkBox_Name.Enabled = false;
            MO_checkBoxPayment.Checked = false;
            MO_checkBox_ZeroPriceItems.Checked = false;
            MO_checkBox_CAP.Checked = false;
            MO_checkBox_Enter.Checked = false;

            MO_checkBox_ShowSendMsg.Checked = true;
            MO_checkBox_ShowTakeAway.Checked = true;
            MO_checkBox_ShowDiscount.Checked = true;
            MO_checkBox_Show_DB_Check.Checked = true;
            MO_checkBox_Show_OSKeyb.Checked = false;

            MO_checkBoxPrivacy.Checked = false;
            MO_checkBox_InitialAvailabilityDlg.Checked = false;
            MO_checkBoxShowPrevReceipt.Checked = false;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            int iGeneralProgOptionsCopy;
            String sTmp;

            iGeneralProgOptionsCopy = 0;

            // BIT_TOUCH_MODE_REQUIRED, BIT_DIRECT_TAP_INC, BIT_SHOW_EXTERNAL_PREVIEW sono definiti in un altro dialogo
            // vanno impostati qui altrimenti vengono azzerati

            if (GetTouchModeEnabled())
                iGeneralProgOptionsCopy = SetBit(iGeneralProgOptionsCopy, (int)GEN_PROGRAM_OPTIONS.BIT_TOUCH_MODE_REQUIRED);

            if (GetDirectTapIncEnabled())
                iGeneralProgOptionsCopy = SetBit(iGeneralProgOptionsCopy, (int)GEN_PROGRAM_OPTIONS.BIT_DIRECT_TAP_INC);

            if (MO_ckBoxExternalPreview.Checked)
                iGeneralProgOptionsCopy = SetBit(iGeneralProgOptionsCopy, (int)GEN_PROGRAM_OPTIONS.BIT_SHOW_EXTERNAL_PREVIEW);


            if (MO_checkBoxPlaceSett.Checked)
                iGeneralProgOptionsCopy = SetBit(iGeneralProgOptionsCopy, (int)GEN_PROGRAM_OPTIONS.BIT_PLACE_SETTINGS_REQUIRED);

            if (MO_checkBoxTable.Checked)
                iGeneralProgOptionsCopy = SetBit(iGeneralProgOptionsCopy, (int)GEN_PROGRAM_OPTIONS.BIT_TABLE_REQUIRED);

            if (MO_checkBox_Name.Checked)
                iGeneralProgOptionsCopy = SetBit(iGeneralProgOptionsCopy, (int)GEN_PROGRAM_OPTIONS.BIT_NAME_REQUIRED);

            if (MO_checkBoxPayment.Checked)
                iGeneralProgOptionsCopy = SetBit(iGeneralProgOptionsCopy, (int)GEN_PROGRAM_OPTIONS.BIT_PAYMENT_REQUIRED);

            if (MO_checkBox_ZeroPriceItems.Checked)
                iGeneralProgOptionsCopy = SetBit(iGeneralProgOptionsCopy, (int)GEN_PROGRAM_OPTIONS.BIT_ZERO_PRICE_ITEMS_ALLOWED);

            if (MO_checkBoxPrivacy.Checked)
                iGeneralProgOptionsCopy = SetBit(iGeneralProgOptionsCopy, (int)GEN_PROGRAM_OPTIONS.BIT_PRIVACY);

            if (MO_checkBox_Enter.Checked)
                iGeneralProgOptionsCopy = SetBit(iGeneralProgOptionsCopy, (int)GEN_PROGRAM_OPTIONS.BIT_ENTER_PRINT_RECEIPT_ENABLED);

            if (MO_checkBox_CAP.Checked)
                iGeneralProgOptionsCopy = SetBit(iGeneralProgOptionsCopy, (int)GEN_PROGRAM_OPTIONS.BIT_CAP_REQUIRED);


            // 0 = visualizzo, 1 = nascondo, tranne checkBox_Show_OSKeyb, MO_checkBox_Show_CAP
            if (!MO_checkBox_ShowSendMsg.Checked)
                iGeneralProgOptionsCopy = SetBit(iGeneralProgOptionsCopy, (int)GEN_PROGRAM_OPTIONS.BIT_SHOW_MSG_BUTTON);

            if (!MO_checkBox_ShowTakeAway.Checked)
                iGeneralProgOptionsCopy = SetBit(iGeneralProgOptionsCopy, (int)GEN_PROGRAM_OPTIONS.BIT_SHOW_TAKEAWAY_BUTTON);

            if (!MO_checkBox_ShowDiscount.Checked)
                iGeneralProgOptionsCopy = SetBit(iGeneralProgOptionsCopy, (int)GEN_PROGRAM_OPTIONS.BIT_SHOW_DISCOUNT_BUTTON);

            if (!MO_checkBox_Show_DB_Check.Checked)
                iGeneralProgOptionsCopy = SetBit(iGeneralProgOptionsCopy, (int)GEN_PROGRAM_OPTIONS.BIT_SHOW_DB_BUTTON);

            // altra regola per Btn_OSKeyb
            if (MO_checkBox_Show_OSKeyb.Checked)
                iGeneralProgOptionsCopy = SetBit(iGeneralProgOptionsCopy, (int)GEN_PROGRAM_OPTIONS.BIT_SHOW_TOUCH_KEYB_BUTTON);

            if (MO_checkBox_Show_CAP.Checked)
                iGeneralProgOptionsCopy = SetBit(iGeneralProgOptionsCopy, (int)GEN_PROGRAM_OPTIONS.BIT_SHOW_CAP_EDIT);

            // controllo _bListinoModificato
            if (SF_Data.iGeneralProgOptions != iGeneralProgOptionsCopy)
            {
                SF_Data.iGeneralProgOptions = iGeneralProgOptionsCopy;

                // solo CASSA_PRINCIPALE può salvare nel Listino
                if (SF_Data.iNumCassa == CASSA_PRINCIPALE)
                    _bListinoModificato = true;
            }

            if (MO_checkBox_InitialAvailabilityDlg.Checked)
                _iDispMngStatus = SetBit(0, BIT_SHOW_DISP_DLG);
            else
                _iDispMngStatus = ClearBit(_iDispMngStatus, BIT_SHOW_DISP_DLG);

            if (comboColorTheme.SelectedIndex != _iColorThemeIndex)
            {
                _iColorThemeIndex = comboColorTheme.SelectedIndex;
                WriteRegistry(COLOR_THEME_KEY, _iColorThemeIndex);
            }

            FrmMain.rFrmMain.MnuAnteprimaScontrino_Click(this, null);

            WriteRegistry(DISP_DLG_MNG_KEY, _iDispMngStatus);

            WriteRegistry(VIEW_PREV_RECEIPT_KEY, MO_checkBoxShowPrevReceipt.Checked ? 1 : 0);

            sTmp = String.Format("optionsDlg OK: {0}, {1}, {2}, {3:X6}", MO_checkBoxPlaceSett.Checked, MO_checkBoxTable.Checked, MO_checkBox_Name.Checked,
                                    SF_Data.iGeneralProgOptions);
            Logger.Info(sTmp);

            Close();
        }

    }
}
