/**************************************************
	NomeFile : StandFacile/EditDispArticoliDlg.cs
	Data	 : 01.12.2025
	Autore	 : Mauro Artuso
 **************************************************/
using System;
using System.Windows.Forms;

using static StandCommonFiles.ComDef;
using static StandCommonFiles.CommonCl;


using static StandFacile.glb;

namespace StandFacile
{
    /// <summary>classe per l'immissione della disponibilità degli Articoli</summary>
    public partial class EditDispArticoliDlg : Form
    {
        static int _iPt;
        /// <summary>riferimento DispDlg</summary>
        public static EditDispArticoliDlg rDispDlg;

        /// <summary>costruttore</summary>
        public EditDispArticoliDlg()
        {
            InitializeComponent();
            rDispDlg = this;

            EAA_TipoEdit.MaxLength = iMAX_ART_CHAR;
        }

        /// <summary>
        /// si passa un indice dell'array fondamentale
        /// </summary>
        public void Init(int iPt)
        {
            int i;
            String sTmp;

            _iPt = iPt;

            EAA_TipoEdit.Text = SF_Data.Articolo[_iPt].sTipo;
            EAA_TipoEdit.Text = CenterJustify(EAA_TipoEdit.Text, iMAX_RECEIPT_CHARS);

            i = SF_Data.Articolo[_iPt].iGruppoStampa;
            EAA_lblDescGruppo.Text = sConstGruppi[i].ToUpper();

            if (SF_Data.Articolo[_iPt].iDisponibilita == DISP_OK)
                EAA_DispEdit.Text = "OK";
            else
                EAA_DispEdit.Text = SF_Data.Articolo[_iPt].iDisponibilita.ToString();

            sTmp = String.Format("FrmDispDlg Init, articolo {0}", _iPt);
            Logger.Info(sTmp);

            if (!Visible && !String.IsNullOrEmpty(EAA_TipoEdit.Text))
                ShowDialog();
        }

        /************************************************
          funzione di verifica della correttezza dei dati
          immessi, modifica direttamente l'array globale
         ************************************************/
        private void BtnOK_Click(object sender, EventArgs e)
        {
            int iDisp;

            EAA_DispEdit.Text = EAA_DispEdit.Text.Trim();

            try
            {
                if (EAA_DispEdit.Text.ToUpper() == "OK")
                    iDisp = DISP_OK;
                else if (!String.IsNullOrEmpty(EAA_DispEdit.Text))
                    iDisp = Convert.ToInt32(EAA_DispEdit.Text); // conversione
                else
                    iDisp = -1; // campo vuoto
            }

            catch (Exception)
            {
                // Errore di conversione !
                WarningManager(WRN_ECQ);
                return;
            }

            if (iDisp == -1)
                WarningManager(WRN_CQZ); // Quantità nulla
            else  // se non ci sono errori uscita con chiusura Form
            {
                SF_Data.Articolo[_iPt].iDisponibilita = iDisp;

                DataManager.SalvaDati(SF_Data);
                Close();
            }
        }

        private void BtnAzzera_Click(object sender, EventArgs e)
        {
            EAA_DispEdit.Text = "0";
        }

        private void BtnRipristina_Click(object sender, EventArgs e)
        {
            EAA_DispEdit.Text = "OK";
        }

        private void DispDlg_Shown(object sender, EventArgs e)
        {
            EAA_DispEdit.Focus();
        }

        private void EditDispArticoliDlg_KeyDown(object sender, KeyEventArgs e)
        {
            int iKey;

            if (e == null)
                iKey = (int)KEY_NONE;
            else
                iKey = (int)e.KeyValue;

            switch (iKey)
            {
                case KEY_ESC:
                    Close();
                    break;

                default:
                    break;
            } // END switch
        }

    }
}
