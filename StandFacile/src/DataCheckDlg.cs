/***********************************************
  	NomeFile : StandFacile/DataCheckDlg.cs
    Data	 : 30.05.2026
  	Autore   : Mauro Artuso
 ***********************************************/

using System;
using System.Drawing;
using System.Windows.Forms;
using static StandCommonFiles.ComDef;
using static StandFacile.Define;
using static StandFacile.FrmMain;
using static StandFacile.OptionsDlg;

using static StandCommonFiles.CommonCl;

namespace StandFacile
{
    /// <summary>
    /// dialogo per la verifica dei dati obbligatori
    /// </summary>
    public partial class DataCheckDlg : Form
    {
        readonly ToolTip _tt = new ToolTip
        {
            InitialDelay = 50,
            ShowAlways = true
        };

        int _iTotaleParz;

        TErrMsg WrnMsg;

        /// <summary>
        /// costruttore con parametri che consente verifica rapida di ciò che manca
        /// </summary>
        public DataCheckDlg(String EditPlaceSettingsParam, String EditTavoloParam, String EditName_param, String Edit_CAP_param, int comboCashIndexParam,
            String EditCashParam, int iTotaleParzParam)
        {
            InitializeComponent();

            _tt.SetToolTip(btnCancel, "chiude il dialogo senza salvare nulla");
            _tt.SetToolTip(BtnPrt, "solo se ci sono tutti i dati richiesti,\r\navvia la stampa e chiude il dialogo");
            _tt.SetToolTip(btnOK, "solo se ci sono tutti i dati richiesti chiude il dialogo");

            DC_EditCoperti.Text = EditPlaceSettingsParam.Trim();
            DC_EditTavolo.Text = EditTavoloParam.Trim();
            DC_EditName.Text = EditName_param.Trim();
            DC_Edit_CAP.Text = Edit_CAP_param.Trim();
            DC_Edit_CASH.Text = EditCashParam.Trim();

            // se c'è un importo in contanti, imposto direttamente contanti come metodo di pagamento
            if (!String.IsNullOrEmpty(DC_Edit_CASH.Text))
                comboCashIndexParam = 0;

            _iTotaleParz = iTotaleParzParam;

            switch (comboCashIndexParam)
            {
                case 0:
                    radioContantiBtn.Checked = true;
                    break;
                case 1:
                    radioCardBtn.Checked = true;
                    break;
                case 2:
                    radioSatispayBtn.Checked = true;
                    break;
            }

            if (GetPlaceSettings_MandatoryFlag())
            {
                DC_lblCoperti.ForeColor = Color.Blue;
                DC_lblCoperti.Font = new Font("Tahoma", 12);
            }

            if (GetTable_MandatoryFlag())
            {
                DC_lblTavolo.ForeColor = Color.Blue;
                DC_lblTavolo.Font = new Font("Tahoma", 12);
            }

            if (GetName_MandatoryFlag())
            {
                DC_lblName.ForeColor = Color.Blue;
                DC_lblName.Font = new Font("Tahoma", 12);
            }

            if (Get_CAP_MandatoryFlag())
            {
                DC_lbl_CAP.ForeColor = Color.Blue;
                DC_lbl_CAP.Font = new Font("Tahoma", 12);
            }

            if (GetPayment_MandatoryFlag())
            {
                groupBox.ForeColor = Color.Blue;
                groupBox.Font = new Font("Tahoma", 12);
            }

            ShowDialog();
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateDataCheckParams();
        }

        private void RadioBtn_Click(object sender, EventArgs e)
        {
            UpdateDataCheckParams();
        }

        /// <summary>accetta solo numeri o backspace</summary>
        private void EditFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == '\b')))
                e.Handled = true;
        }

        /// <summary>accetta solo numeri o backspace</summary>
        private void EditCashFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == ',') || (e.KeyChar == '.') || (e.KeyChar == '\b')))
                e.Handled = true;
        }

        /// <summary>
        ///  funzione che imposta tutti i parametri necessari a DataCheckDlg<br/>
        ///  prelevandoli dai controlli e non dal Registro
        /// </summary>       
        void UpdateDataCheckParams()
        {
            rFrmMain.SetEditCoperto(DC_EditCoperti.Text.Trim());
            rFrmMain.SetEditTavolo(DC_EditTavolo.Text.Trim());
            rFrmMain.SetEditName(DC_EditName.Text.Trim());
            rFrmMain.SetEditCAP(DC_Edit_CAP.Text.Trim());

            DC_lbl_Cash.ForeColor = SystemColors.ControlDark;

            if (radioContantiBtn.Checked)
            {
                rFrmMain.SetPagamento_CASH(DC_Edit_CASH.Text);
                DC_lbl_Cash.ForeColor = Color.Blue;

                int iContante = EuroToInt(DC_Edit_CASH.Text, EURO_CONVERSION.EUROCONV_DONT_CARE, WrnMsg);

                if ((iContante != -1) && (iContante >= _iTotaleParz))
                {
                    DC_Edit_CASH.BackColor = Color.Aquamarine;
                }
                else
                {
                    DC_Edit_CASH.BackColor = Color.Red;
                }

            }
            else if (radioCardBtn.Checked)
                rFrmMain.SetPagamento_CARD();

            else if (radioSatispayBtn.Checked)
                rFrmMain.SetPagamento_SATISPAY();
            else
                rFrmMain.ResetPayment();
        }

        bool VerificaPayment()
        {
            int iContante = EuroToInt(DC_Edit_CASH.Text, EURO_CONVERSION.EUROCONV_DONT_CARE, WrnMsg);

            if ((iContante >= _iTotaleParz) && radioContantiBtn.Checked)
                return true;
            else
                return (radioCardBtn.Checked || radioSatispayBtn.Checked);
        }

        private void BtnPrt_Click(object sender, EventArgs e)
        {
            // avvia la stampa dell'ordine
            String[] sQueue_Object = new String[2] { ORDER_PRINT_START, "" };

            UpdateDataCheckParams();

            if ((!GetTable_MandatoryFlag() || !String.IsNullOrEmpty(DC_EditTavolo.Text.Trim())) &&
                (!GetName_MandatoryFlag() || (DC_EditName.Text.Trim().Length > 2)) &&
                (!Get_CAP_MandatoryFlag() || (DC_Edit_CAP.Text.Trim().Length > 2)) &&
                (!GetPlaceSettings_MandatoryFlag() || (!String.IsNullOrEmpty(DC_EditCoperti.Text.Trim()) && Convert.ToInt32(DC_EditCoperti.Text) >= 0)) &&
                (!GetPayment_MandatoryFlag() || VerificaPayment()))
            {
                FrmMain.EventEnqueue(sQueue_Object);
                Close();
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            UpdateDataCheckParams();

            if ((!GetTable_MandatoryFlag() || !String.IsNullOrEmpty(DC_EditTavolo.Text.Trim())) &&
                (!GetName_MandatoryFlag() || (DC_EditName.Text.Trim().Length > 2)) &&
                (!Get_CAP_MandatoryFlag() || (DC_Edit_CAP.Text.Trim().Length > 2)) &&
                (!GetPlaceSettings_MandatoryFlag() || (!String.IsNullOrEmpty(DC_EditCoperti.Text.Trim()) && Convert.ToInt32(DC_EditCoperti.Text) >= 0)) &&
                (!GetPayment_MandatoryFlag() || VerificaPayment()))
            {
                // pulisce inserimento contanti se è selezionato un metodo di pagamento diverso
                if (radioCardBtn.Checked || radioSatispayBtn.Checked)
                    rFrmMain.ClearPagamento_CASH();

                Close();
            }
        }

    }
}
