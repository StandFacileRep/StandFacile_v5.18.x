/***********************************************
  	NomeFile : StandFacile/MainForm.cs
    Data	 : 14.08.2026
  	Autore   : Mauro Artuso
 ***********************************************/

// #define FONT_CHECK

using System;
using System.Drawing;
using System.Windows.Forms;

using static StandFacile.glb;
using static StandFacile.Config;
using static StandFacile.Define;
using static StandFacile.dBaseIntf;
using static StandFacile.OptionsDlg;

using static StandCommonFiles.ComDef;
using static StandCommonFiles.CommonCl;

using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace StandFacile
{

    /// <summary>
    /// form principale
    /// </summary>
    public partial class FrmMain : Form
    {
        const int toolStripR_WIDTH_H = 230;
        const int toolStripR_WIDTH_V = 100;
        const int toolStripR_HEIGHT_H = 75;
        const int toolStripR_HEIGHT_V = 260;

        /// <summary>
        /// abilita/disabilita le varie voci del Menù Principale
        /// </summary>
        void CheckMenuItems()
        {
            // bottoni e/o menù rilevanti
            if (MnuEditItemsAvailab.Checked)
            {
                // Menù File e Stampa
                MnuPrintTest.Enabled = false;
                MnuPrintFile.Enabled = false;
                MnuExportPricelist.Enabled = false;
                MnuImportPricelist.Enabled = false;
                MnuSessionClose.Enabled = false;

                // Menù Modifica
                MnuEdit.Enabled = true;
                MnuEditItemsAvailab.Enabled = true;
                MnuOrderCancel.Enabled = false;
                MnuChangePayment.Enabled = false;

                // Menù Visualizza
                MnuView.Enabled = false;

                // Menù Impostazioni
                MnuSetup.Enabled = false;

                // Bottoni
                BtnViewPricelist.Enabled = false;
                BtnSendMsg.Enabled = false;
                BtnX10.Enabled = false;
                BtnTakeAway.Enabled = false;
                BtnSconto.Enabled = false;
                BtnScontrino.Enabled = false;
                Btn_DB_Check.Enabled = false;

                // Bottoni Touch
                btnPlus.Enabled = false;
                btnMinus.Enabled = false;
                btnCanc.Enabled = false;

                MF_lblName.Enabled = false;
                EditName.Enabled = false;
                MF_lbl_CAP.Enabled = false;
                Edit_CAP.Enabled = false;
                MF_lblTable.Enabled = false;
                EditTable.Enabled = false;
                MF_lblPlaceSett.Enabled = false;
                EditPlaceSett.Enabled = false;
                MF_lblNote.Enabled = false;
                EditNote.Enabled = false;
                MF_lblChange.Enabled = false;
                EditChange.Enabled = false;
                MF_lblPaidCash.Enabled = false;
                EditPaidCash.Enabled = false;

                comboCashPos.Enabled = false;
                EditStatus_QRC.Enabled = false;
                MF_lblReadQrc.Enabled = false;
            }
            else if (MnuSetupPricelist.Checked)
            {
                // Menù File e Stampa
                MnuPrintTest.Enabled = false;
                MnuPrintFile.Enabled = false;
                MnuExportPricelist.Enabled = false;
                MnuImportPricelist.Enabled = false;
                MnuSessionClose.Enabled = false;

                // Menù Modifica
                MnuEdit.Enabled = false;
                MnuEditItemsAvailab.Enabled = false;

                // Menù Visualizza
                MnuView.Enabled = false;

                // Menù Impostazioni
                MnuSetup.Enabled = true;
                MnuExpert.Enabled = false;
                MnuSetupNetwork.Enabled = false;
                MnuSetupGenPrinter.Enabled = false;
                MnuSetupWinPrinter.Enabled = false;
                MnuSetupLegacyPrinter.Enabled = false;
                MnuSetupLocalCopies.Enabled = false;
                MnuSetupNetworkCopies.Enabled = false;
                MnuSetupOptions.Enabled = false;
                MnuChangePassword.Enabled = false;
                MnuSetupHeader.Enabled = false;
                MnuSetupTabsGrid.Enabled = false;
                MnuFileDiConfigurazione.Enabled = false;
                MnuSetupPricelist.Enabled = true;

                // Bottoni
                BtnViewPricelist.Enabled = false;
                //BtnViewPricelist.Checked = false;

                BtnSendMsg.Enabled = false;
                BtnX10.Enabled = false;
                BtnTakeAway.Enabled = false;
                BtnSconto.Enabled = false;
                BtnScontrino.Enabled = false;
                Btn_DB_Check.Enabled = false;

                sStatusText = "Modifica Listino : Esc per uscire";

                // Bottoni Touch
                btnPlus.Enabled = false;
                btnMinus.Enabled = false;
                btnCanc.Enabled = false;

                MF_lblName.Enabled = false;
                EditName.Enabled = false;
                MF_lbl_CAP.Enabled = false;
                Edit_CAP.Enabled = false;
                MF_lblTable.Enabled = false;
                EditTable.Enabled = false;
                MF_lblPlaceSett.Enabled = false;
                EditPlaceSett.Enabled = false;
                MF_lblNote.Enabled = false;
                EditNote.Enabled = false;
                MF_lblChange.Enabled = false;
                EditChange.Enabled = false;
                MF_lblPaidCash.Enabled = false;
                EditPaidCash.Enabled = false;

                comboCashPos.Enabled = false;
                EditStatus_QRC.Enabled = false;
                MF_lblReadQrc.Enabled = false;
            }
            // con BtnVisListino->Enabled = false -->  BtnVisListino->Down == true sempre
            else if (BtnViewPricelist.Checked && BtnViewPricelist.Enabled)
            {
                // Menù File e Stampa
                MnuPrintTest.Enabled = false;
                MnuPrintFile.Enabled = false;
                MnuExportPricelist.Enabled = false;
                MnuImportPricelist.Enabled = false;
                MnuSessionClose.Enabled = false;

                // Menù Modifica
                MnuEdit.Enabled = false;

                // Menù Visualizza
                MnuView.Enabled = false;

                // Menù Impostazioni
                MnuSetup.Enabled = false;

                // Bottoni
                // BtnVisListino.Enabled = false;
                BtnSendMsg.Enabled = false;
                BtnX10.Enabled = false;
                BtnTakeAway.Enabled = false;
                BtnSconto.Enabled = false;
                BtnScontrino.Enabled = false;
                Btn_DB_Check.Enabled = false;

                // Bottoni Touch
                btnPlus.Enabled = false;
                btnMinus.Enabled = false;
                btnCanc.Enabled = false;

                MF_lblName.Enabled = false;
                EditName.Enabled = false;
                MF_lbl_CAP.Enabled = false;
                Edit_CAP.Enabled = false;
                MF_lblTable.Enabled = false;
                EditTable.Enabled = false;
                MF_lblPlaceSett.Enabled = false;
                EditPlaceSett.Enabled = false;
                MF_lblNote.Enabled = false;
                EditNote.Enabled = false;
                MF_lblChange.Enabled = false;
                EditChange.Enabled = false;
                MF_lblPaidCash.Enabled = false;
                EditPaidCash.Enabled = false;

                comboCashPos.Enabled = false;
                EditStatus_QRC.Enabled = false;
                MF_lblReadQrc.Enabled = false;
            }
            else
            {
                /*******************************************
                        nessun bottone o menù rilevante            
                 *******************************************/

                // più sopra poteva essere disabilitato
                MnuExpert.Enabled = true;

                // Bottoni Touch
                btnPlus.Enabled = true;
                btnMinus.Enabled = true;
                btnCanc.Enabled = true;

                MainGrid.Enabled = true; // sicurezza

                MF_lblName.Enabled = true;
                EditName.Enabled = true;
                MF_lbl_CAP.Enabled = true;
                Edit_CAP.Enabled = true;
                MF_lblTable.Enabled = true;
                EditTable.Enabled = true;
                MF_lblPlaceSett.Enabled = true;
                EditPlaceSett.Enabled = true;
                MF_lblNote.Enabled = true;
                EditNote.Enabled = true;
                MF_lblChange.Enabled = true;
                EditChange.Enabled = true;
                MF_lblPaidCash.Enabled = true;
                EditPaidCash.Enabled = true;

                comboCashPos.Enabled = true;

                EditStatus_QRC.Enabled = true;
                MF_lblReadQrc.Enabled = true;

                if (MnuExpert.Checked)
                {
                    // Menù File e Stampa

                    if (DataManager.CheckIf_CassaSec_and_NDB()) // cassa secondaria e DB
                    {
                        MnuExportPricelist.Enabled = false;
                        MnuImportPricelist.Enabled = false;
                        MnuSessionClose.Enabled = false;
                        MnuSetupHeader.Enabled = false;
                        MnuSetupTabsGrid.Enabled = false;
                        MnuSetupOptions.Enabled = true;
                        MnuSetupPricelist.Enabled = false;
                    }
                    else
                    {
                        MnuExportPricelist.Enabled = true;
                        MnuImportPricelist.Enabled = true;
                        MnuSessionClose.Enabled = true;
                        MnuSetupHeader.Enabled = true;
                        MnuSetupTabsGrid.Enabled = true;
                        MnuSetupOptions.Enabled = true;
                        MnuSetupPricelist.Enabled = true;
                    }

                    // Menù Modifica
                    // Menù Visualizza
                    MnuViewTodayIncome.Enabled = true;
                    MnuViewDateIncome.Enabled = true;
                    MnuEsploraDB.Enabled = true;

                    // Menù Impostazioni
                    MnuChangePassword.Enabled = true;
                    MnuSetupNetwork.Enabled = true;
                    MnuSetupGenPrinter.Enabled = true;
                    MnuSetupWinPrinter.Enabled = true;
                    MnuSetupLegacyPrinter.Enabled = true;
                    MnuSetupLocalCopies.Enabled = true;
                    MnuSetupNetworkCopies.Enabled = true;
                    MnuFileDiConfigurazione.Enabled = true;

                }
                else // non Esperto
                {
                    // Menù File e Stampa
                    MnuExportPricelist.Enabled = false;
                    MnuImportPricelist.Enabled = false;
                    MnuSessionClose.Enabled = false;

                    // Menù Modifica
                    // Menù Visualizza
                    if (IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_PRIVACY))
                    {
                        MnuViewTodayIncome.Enabled = false;
                        MnuViewDateIncome.Enabled = false;
                        MnuEsploraDB.Enabled = false;
                        MnuViewDateOrders.Enabled = false;
                    }
                    else
                    {
                        MnuViewTodayIncome.Enabled = true;
                        MnuViewDateIncome.Enabled = true;
                        MnuEsploraDB.Enabled = true;
                        MnuViewDateOrders.Enabled = true;
                    }

                    // Menù Impostazioni
                    MnuSetupNetwork.Enabled = false;
                    MnuSetupGenPrinter.Enabled = false;
                    MnuSetupWinPrinter.Enabled = false;
                    MnuSetupLegacyPrinter.Enabled = false;
                    MnuSetupLocalCopies.Enabled = false;
                    MnuSetupNetworkCopies.Enabled = false;
                    MnuChangePassword.Enabled = false;
                    MnuSetupOptions.Enabled = false;
                    MnuSetupHeader.Enabled = false;
                    MnuFileDiConfigurazione.Enabled = false;
                    MnuSetupTabsGrid.Enabled = false;
                    MnuSetupPricelist.Enabled = false;
                }

                // cassa secondaria e DB
                if (DataManager.CheckIf_CassaSec_and_NDB())
                    MnuEditItemsAvailab.Enabled = false;
                else
                    MnuEditItemsAvailab.Enabled = true;


                // tutti i Menù abilitati
                MnuEdit.Enabled = true;
                MnuView.Enabled = true;
                MnuSetup.Enabled = true;
                MnuQuickHelp.Enabled = true;

                // Menù File e Stampa
                MnuPrintTest.Enabled = true;
                MnuPrintFile.Enabled = true;

                // Menù Modifica
                MnuOrderCancel.Enabled = true;
                MnuChangePayment.Enabled = true;

                // Menù Visualizza
                MnuViewTodayOrders.Enabled = true;

                MnuEsploraOrdiniWeb.Enabled = NetConfigDlg.rNetConfigDlg.GetWebOrderEnabled();
                MnuViewPricelist.Enabled = true;
                MnuReceiptPreview.Enabled = true;

                // più sopra poteva essere disabilitato
                MnuExpert.Enabled = true;

                // Bottoni
                BtnViewPricelist.Enabled = true;
                //    altrimenti non si visualizza il listino
                //    BtnVisListino.Checked = false;

                BtnSendMsg.Enabled = true;
                BtnSendMsg.Checked = false;

                BtnX10.Enabled = true;
                BtnX10.Checked = false;

                BtnTakeAway.Enabled = true;

                //BtnAsporto.Checked = false;
                BtnSconto.Enabled = true;

                // ripristina lo stato dopo che si sono consultati i prezzi
                if ((SF_Data.iStatusSconto & 0x0000000F) != 0)
                {
                    BtnSconto.Checked = true;
                    BtnSconto.Image = Properties.Resources.sconto_si;
                }
                else
                {
                    BtnSconto.Checked = false;
                    BtnSconto.Image = Properties.Resources.sconto_no;
                }

                BtnScontrino.Enabled = true;
                BtnScontrino.Checked = false;

                Btn_DB_Check.Enabled = true;

                if (_bListinoModificato)
                {
                    DataManager.SalvaListino();

                    DataManager.SalvaDati(SF_Data); // così si visualizzano prezzi e dati aggiornati
                    SetTabsAppearance();
                }

                sStatusText = "Pronto";
            }

            // minimizza transizioni grafiche
            if (BtnViewPricelist.Checked)
            {
                FormResize(null, null);
                MainGrid_Redraw(this, null);
            }
            else
            {
                MainGrid_Redraw(this, null);
                FormResize(null, null);
            }
        }

        /*****************************************
         *       gestione pressione tasti
         *****************************************/
        private void MainGrid_KeyDown(object sender, KeyEventArgs e)
        {
            int i, iD, iU;
            int iKey = (int)e.KeyValue;
            int iPageNumTmp;

            String sTmp;

            if (GetTouchModeEnabled())
                iPageNumTmp = PAGES_NUM_TABM;
            else
                iPageNumTmp = PAGES_NUM_TXTM;

            if (!MnuSetupPricelist.Checked && !BtnViewPricelist.Checked)
            {
                // intercettazione qrcode sparato sulla griglia
                scannerInputQueue.Enqueue(iKey);

                if (scannerInputQueue.Count > 8)
                {
                    EditStatus_QRC.Text = "";
                    EditStatus_QRC.Focus();

                    DataManager.ClearGrid();
                }
            }

            ClearBC_FocusTimer();

            // punto unico _iCellPt =
            _iCellPt = MainGrid.CurrentCell.ColumnIndex * MainGrid.RowCount + MainGrid.CurrentCell.RowIndex + iArrayOffset;

            //Console.WriteLine("iKey = {0}, e.Modifiers = {1}, Ctrl = {2}", e.KeyValue, e.Modifiers, e.Control);

            if (e.Modifiers == Keys.Control)
                _bCtrlIsPressed = true;
            else
                _bCtrlIsPressed = false;

            if (e.Modifiers == Keys.Alt)
                _bAltIsPressed = true;
            else
                _bAltIsPressed = false;

            switch (iKey)
            {
                case KEY_HOME:
                    MainGrid.CurrentCell = MainGrid.Rows[0].Cells[0];

                    if (e.Modifiers == Keys.Control)
                        TabSet.SelectedIndex = 0;

                    iKey = KEY_NONE;
                    MainGrid.Focus();
                    break;

                case KEY_END:
                    MainGrid.CurrentCell = MainGrid.Rows[MainGrid.RowCount - 1].Cells[MainGrid.ColumnCount - 1];

                    if (e.Modifiers == Keys.Control)
                        TabSet.SelectedIndex = iPageNumTmp - 1;

                    iKey = KEY_NONE;
                    MainGrid.Focus();
                    break;

                case KEY_ESC:

                    // reset selezioni Menù
                    if (MnuEditItemsAvailab.Checked)
                    {
                        MnuEditItemsAvailab.Checked = false;
                        MnuModDispArticoli_Click(this, null);
                    }

                    if (MnuSetupPricelist.Checked)
                    {
                        EditPlaceSett.Text = _sCopertiPrev;
                        MnuSetupPricelist.Checked = false;
                        MnuSetupListino_Click(this, null);
                    }

                    if (BtnViewPricelist.Checked && BtnViewPricelist.Enabled)
                    {
                        EditPlaceSett.Text = _sCopertiPrev;
                        BtnViewPricelist.Checked = false;
                    }

                    // ci passa se si modifica l'header altrimenti
                    // ci pensa CheckMenuItems();
                    if (_bListinoModificato)
                        DataManager.SalvaListino();

                    // default TAB
                    TabSet.SelectedIndex = 0;
                    MainGrid.Focus();
                    CheckMenuItems();

                    break;

                case KEY_INS:
                case KEY_PLUS:
                case KEY_PLUS_NUM:
                    if (e.Modifiers == Keys.Control)
                    {
                        // inserisce oltre la Pagina corrente, entro l'ultima pagina
                        if (String.IsNullOrEmpty(SF_Data.Articolo[iLastGridIndex * iPageNumTmp - 1].sTipo) && (MnuSetupPricelist.Checked == true))
                        {
                            for (i = iLastGridIndex * iPageNumTmp - 1; i > _iCellPt; i--)
                                SF_Data.Articolo[i] = SF_Data.Articolo[i - 1];

                            SF_Data.Articolo[_iCellPt] = new TArticolo(0);

                            _bListinoModificato = true;
                        }
                    }
                    else
                    {
                        // inserisce entro la Pagina corrente
                        if (String.IsNullOrEmpty(SF_Data.Articolo[iArrayOffset + iLastGridIndex - 1].sTipo) && (MnuSetupPricelist.Checked == true))
                        {
                            for (i = iArrayOffset + iLastGridIndex - 1; i > _iCellPt; i--)
                                SF_Data.Articolo[i] = SF_Data.Articolo[i - 1];

                            SF_Data.Articolo[_iCellPt] = new TArticolo(0);

                            _bListinoModificato = true;
                        }
                    }

                    iKey = KEY_NONE;
                    break;

                case KEY_DEL:
                case KEY_MINUS:
                case KEY_MIN_NUM:

                    if (String.IsNullOrEmpty(SF_Data.Articolo[_iCellPt].sTipo) && (MnuSetupPricelist.Checked == true))
                    {
                        if (e.Modifiers == Keys.Control)
                        {
                            // cancella spostando da oltre la Pagina corrente
                            for (i = _iCellPt; i < iLastGridIndex * iPageNumTmp - 1; i++)
                                SF_Data.Articolo[i] = SF_Data.Articolo[i + 1];

                            SF_Data.Articolo[iLastGridIndex * iPageNumTmp - 1] = new TArticolo(0);
                        }
                        else
                        {
                            // cancella entro la Pagina corrente
                            for (i = _iCellPt; i < iArrayOffset + iLastGridIndex - 1; i++)
                                SF_Data.Articolo[i] = SF_Data.Articolo[i + 1];

                            SF_Data.Articolo[iArrayOffset + iLastGridIndex - 1] = new TArticolo(0);
                        }

                        _bListinoModificato = true;
                        iKey = KEY_NONE;
                    }
                    else if ((!MnuSetupPricelist.Checked) && (!MnuEditItemsAvailab.Checked) && (iKey != KEY_MIN_NUM))
                    {
                        // così poi aggiorna il TP Totale Parziale
                        iKey = '0';
                    }

                    break;

                case KEY_F1:
                    EditPlaceSett.Focus();
                    break;
                case KEY_F2:
                    EditTable.Focus();
                    break;
                case KEY_F3:
                    EditPaidCash.Focus();
                    break;
                case KEY_F4:
                    EditNote.Focus();
                    break;

                case KEY_F5:
                    BtnVisListino_Click(this, null);
                    break;
                case KEY_F6:
                    BtnSendMsg_Click(this, null);
                    break;
                case KEY_F7:
                    BtnX10.Checked = !BtnX10.Checked;
                    break;
                case KEY_F8:
                    BtnTakeAway.Checked = !BtnTakeAway.Checked;
                    BtnTakeAway_Click(this, null);
                    break;
                case KEY_F9:
                    BtnSconto_Click(this, null);
                    break;
                case KEY_F10:
                    BtnScontrino_Click(this, null);
                    break;
                case KEY_ENTER:
                    // viene processato come Keys.Enter per evitare Key_Down
                    //if (OptionsDlg._rOptionsDlg.GetEnterPrintReceipt())
                    //{
                    //    BtnScontrino_Click(this, null);
                    //}
                    break;

                case '0':
                case KEYNUMPAD0:
                    if (e.Modifiers == Keys.Control)
                    {
                        sTmp = String.Format("FrmMain : premuto 0 + = {0}", e.Modifiers);
                        Logger.Info(sTmp);

                        // Ctrl + 0
                        SetEditStatus_QRC("");

                        DataManager.ClearGrid();
                        _iAnteprimaTotParziale = AnteprimaDlg.rAnteprimaDlg.RedrawReceipt();
                    }
                    break;

                // stampa copia locale scontrino normale
                case 'A':
                    if (e.Modifiers == Keys.Control)
                        SF_Data.Articolo[_iCellPt].iOptionsFlags = ClearBit(SF_Data.Articolo[_iCellPt].iOptionsFlags, BIT_STAMPA_SINGOLA_NELLA_LOCAL_COPY);
                    break;

                // Elimina tutti dati del giorno
                case 'E':
                    if (MnuExpert.Checked && (e.Modifiers == (Keys.Alt | Keys.Control)))
                    {
                        sTmp = String.Format("FrmMain : premuto E + {0}", e.Modifiers);
                        Logger.Info(sTmp);

                        // Ctrl + Alt + E
                        EraseAllaData();
                        return; //  altrimenti il successivo FormResize() genera eccezioni
                    }
                    break;

                // modifica Listino
                case 'L':
                    if (MnuExpert.Checked && !BtnViewPricelist.Checked && (e.Modifiers == (Keys.Alt | Keys.Control)))
                    {
                        sTmp = String.Format("FrmMain : premuto E + {0}", e.Modifiers);
                        Logger.Info(sTmp);

                        // Ctrl + Alt + L
                        BtnViewPricelist.Checked = true;
                        MnuSetupPricelist.Checked = true;

                        _sCopertiPrev = EditPlaceSett.Text;
                        EditPlaceSett.Text = String.Format("{0,4:0.00}", SF_Data.Articolo[MAX_ITEMS_NUM - 1].iPrezzoUnitario / 100.0f);

                        CheckMenuItems();
                        return; //  altrimenti il successivo FormResize() genera eccezioni
                    }
                    break;

                case 'C':
                    if (e.Modifiers == Keys.Control)
                    {
                        comboCashPos.SelectedIndex = (comboCashPos.SelectedIndex + 1) % (sConst_PaymentType.Length - 1);
                        scannerInputQueue.Clear();
                    }

                    _iAnteprimaTotParziale = AnteprimaDlg.rAnteprimaDlg.RedrawReceipt();
                    break;

                case 'P':
                    if (e.Modifiers == Keys.Control)
                    {
                        MnuAnteprimaScontrino_Click("Ctrl_P", null);
                        scannerInputQueue.Clear();
                    }
                    break;

                // stampa copia locale scontrino singola
                case 'S':
                    if ((e.Modifiers == Keys.Control) && PrintLocalCopiesConfigDlg.GetTicketNoPriceCopy())
                        SF_Data.Articolo[_iCellPt].iOptionsFlags = SetBit(SF_Data.Articolo[_iCellPt].iOptionsFlags, BIT_STAMPA_SINGOLA_NELLA_LOCAL_COPY);
                    break;

                default:
                    break;
            } // end switch

            // gestione Keypad numerico
            if ((iKey >= KEYNUMPAD0) && (iKey <= KEYNUMPAD9))
            {
                iKey -= 48;
            }

            /************************************************************************************
             *  non si è in modo modifica disponibilità, non si è in modo modifica del Listino,
             *  non si stanno consultando i prezzi
             ************************************************************************************/
            if ((iKey >= '0') && (iKey <= '9') && !String.IsNullOrEmpty(SF_Data.Articolo[_iCellPt].sTipo) &&
                !MnuSetupPricelist.Checked &&       // non si è in modo modifica del Listino
                !BtnViewPricelist.Checked &&       // non si stanno consultando i prezzi
                !MnuEditItemsAvailab.Checked)    // non si sta modificando la disponibilità
            {
                if (SF_Data.Articolo[_iCellPt].iDisponibilita != 0) //
                {
                    if (BtnX10.Checked) // Q.tà ordinazioni a 2 cifre
                    {
                        iD = (SF_Data.Articolo[_iCellPt].iQuantitaOrdine) % 10;
                        iU = (iKey - '0');
                        SF_Data.Articolo[_iCellPt].iQuantitaOrdine = iD * 10 + iU;

                        BtnX10.Checked = false;
                        sStatusText = "Pronto";
                    }
                    else
                    {
                        iU = (iKey - '0');
                        SF_Data.Articolo[_iCellPt].iQuantitaOrdine = iU;
                    }
                }
                else // azzeramento consentito per ordini web non possibili
                {
                    iU = (iKey - '0');

                    if (iU == 0)
                        SF_Data.Articolo[_iCellPt].iQuantitaOrdine = 0;
                }

                _iAnteprimaTotParziale = AnteprimaDlg.rAnteprimaDlg.RedrawReceipt();
            }
            // per sicurezza si azzerano in caso numeri di fuori griglia
            else if ((iKey == '0') && String.IsNullOrEmpty(SF_Data.Articolo[_iCellPt].sTipo) &&
                !MnuSetupPricelist.Checked &&      // non si è in modo modifica del Listino
                !BtnViewPricelist.Checked &&      // non si stanno consultando i prezzi
                !MnuEditItemsAvailab.Checked)   // non si sta modificando la disponibilità
            {
                SF_Data.Articolo[_iCellPt].iQuantitaOrdine = 0;

                _iAnteprimaTotParziale = AnteprimaDlg.rAnteprimaDlg.RedrawReceipt();
            }

            if (MnuSetupPricelist.Checked)
                FormResize(this, null);

            if (SF_Data.Articolo[_iCellPt].iQuantitaOrdine == 0)
            {
                // reset EditNota
                EditNote.BackColor = Color.Gainsboro;
                SF_Data.Articolo[_iCellPt].sNotaArt = "";
            }

            MainGrid_Redraw(this, null);
        }

        private void MainGrid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
                _bCtrlIsPressed = true;
            else
                _bCtrlIsPressed = false;

            if ((EditNote.BackColor == Color.LightBlue) && !_bCtrlIsPressed)
            {
                // reset EditNota
                EditNote.BackColor = Color.Gainsboro;
                EditNote.Text = _sEditNoteCopy;
                EditNote.MaxLength = iMAX_RECEIPT_CHARS;
                MF_lblNote.Text = "Nota:";

                MainGrid_Redraw(this, null);
            }

            Console.WriteLine("MainGrid_KeyUp: {0}", _bCtrlIsPressed);
        }

        private void MainGrid_Resize(object sender, EventArgs e)
        {
            if (rFrmMain == null)
                return;

            Console.WriteLine(String.Format("MainGrid_Resize: {0}, {1}", rFrmMain.Size.Width, rFrmMain.Size.Height));
            FormResize(sender, null);
        }

        /********************************************************
         *	chiama il dialogo di modifica del record TArticolo
         ********************************************************/
        private void MainGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // punto unico _iPt_DoubleClick =
            _iCellPt = e.ColumnIndex * MainGrid.RowCount + e.RowIndex + iArrayOffset;

            if (MnuEditItemsAvailab.Checked)
            {
                EditDispArticoliDlg rDispDlg = new EditDispArticoliDlg();
                rDispDlg.Init(_iCellPt);

                FormResize(null, null);
                MainGrid_Redraw(this, null);
                rDispDlg.Dispose();
            }
            else if (MnuSetupPricelist.Checked)
            {
                EditArticoloDlg rModificaArticoloDlg = new EditArticoloDlg();
                rModificaArticoloDlg.Init(_iCellPt, true);

                _bListinoModificato |= EditArticoloDlg.GetListinoModificato();

                EditPlaceSett.Text = String.Format("{0,4:0.00}", SF_Data.Articolo[MAX_ITEMS_NUM - 1].iPrezzoUnitario / 100.0f);

                CheckMenuItems();
                rModificaArticoloDlg.Dispose();
            }

            bSkipDrag = true; // evitare un BeginDrag sul doppio click
        }

        /*****************************
         *     Inizio di un Drag
         *****************************/
        private void MainGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // il click del mouse annulla il conteggio per barcode scanner detect
            scannerInputQueue.Clear();

            iSwapStartIndex = e.ColumnIndex * MainGrid.RowCount + e.RowIndex + iArrayOffset;

            if (MnuSetupPricelist.Checked && (e.Button == MouseButtons.Left) && !bSkipDrag && !bMouseWrongPos)
            {
                bStartDrag = true;
                Cursor = Cursors.Hand;
            }

            bSkipDrag = false;
        }

        /*******************************************************
         *	Fine di un Drag, si molla il tasto Left del mouse
         *******************************************************/
        private void MainGrid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            int m, n, iLastArticoloPageIndex;
            int ToCellX, ToCellY;
            TArticolo tmpArticolo;

            // altrimenti può rimanere true
            bPageDxProximity = false;
            bPageSxProximity = false;

            if (MnuSetupPricelist.Checked && (e.Button == MouseButtons.Left) && bStartDrag)
            {
                ToCellX = e.ColumnIndex;
                ToCellY = e.RowIndex;

                m = ToCellX * MainGrid.RowCount + ToCellY + iArrayOffset;
                n = iSwapStartIndex;

                if (GetTouchModeEnabled())
                    iLastArticoloPageIndex = SF_Data.iGridRows * SF_Data.iGridCols * PAGES_NUM_TABM;
                else
                    iLastArticoloPageIndex = SF_Data.iGridRows * SF_Data.iGridCols * PAGES_NUM_TXTM;

                // controllo per evitare sforamenti del vettore
                if ((m < iLastArticoloPageIndex) && (n < iLastArticoloPageIndex) && (n != m))
                {
                    tmpArticolo = SF_Data.Articolo[m];

                    SF_Data.Articolo[m] = SF_Data.Articolo[n];
                    SF_Data.Articolo[n] = tmpArticolo;
                    _bListinoModificato = true;
                }

                bStartDrag = false;
                Cursor = Cursors.Default;

                DataManager.CheckLastArticoloIndexP1();

                FormResize(null, null);
                MainGrid_Redraw(this, null);
            }
        }

        // il mouse pointer è dentro MainGrid
        private void MainGrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.ColumnIndex >= 0) && (e.ColumnIndex < MainGrid.ColumnCount) && (e.RowIndex >= 0) && (e.RowIndex < MainGrid.RowCount) &&
                (e.Button != MouseButtons.Left))
            {
                Cursor = Cursors.Default;
            }

            bMouseWrongPos = false; // il mouse pointer è dentro MainGrid
        }

        // il mouse pointer è fuori MainGrid, non funziona
        private void MainGrid_DragLeave(object sender, EventArgs e)
        {
            if (MnuSetupPricelist.Checked)
            {
                Cursor = Cursors.No;
                bMouseWrongPos = true; // il mouse pointer non è in MainGrid
            }
        }

        // simula MainGridDragOver verifica la posizione rispetto ai bordi
        private void MainGrid_MouseMove(object sender, MouseEventArgs e)
        {
            bool bModArtVisibile;

            if (EditArticoloDlg.rModificaArticoloDlg != null)
                bModArtVisibile = EditArticoloDlg.rModificaArticoloDlg.Visible;
            else
                bModArtVisibile = false;

            if (((e.Y < 5) || ((MainGrid.Height - e.Y) < 5)) && MnuSetupPricelist.Checked && !bModArtVisibile && bStartDrag)
            {
                // esce da MainGrid
                Cursor = Cursors.No;
                bPageDxProximity = false;
                bPageSxProximity = false;
            }
            else if (((MainGrid.Width - e.X) < 50) && MnuSetupPricelist.Checked && !bModArtVisibile && bStartDrag)
            {
                // si sposta a destra
                MainGrid.Cursor = Cursors.AppStarting;
                bPageDxProximity = true;
            }
            else if ((e.X < 50) && MnuSetupPricelist.Checked && !bModArtVisibile && bStartDrag)
            {
                // si sposta a sinistra
                MainGrid.Cursor = Cursors.AppStarting;
                bPageSxProximity = true;
            }
            else if (bStartDrag && !bMouseWrongPos)
            {
                Cursor = Cursors.Hand;
                bPageDxProximity = false;
                bPageSxProximity = false;
            }
            else if (bMouseWrongPos)
            {
                Cursor = Cursors.No;
                bPageDxProximity = false;
                bPageSxProximity = false;
            }
            else
            {
                Cursor = Cursors.Default;
                bPageDxProximity = false;
                bPageSxProximity = false;
            }

            if (BtnViewPricelist.Checked && BtnViewPricelist.Enabled)
                _iVisPrzTimeout = TIMEOUT_VIS_PREZZI;
        }

        /// <summary>
        /// special processing for KEY_TAB, KEY_UP, KEY_DOWN, KEY_LEFT, KEY_RIGHT
        /// </summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            int iPageNumTmp, iRow, iCol;

            if (GetTouchModeEnabled())
                iPageNumTmp = PAGES_NUM_TABM;
            else
                iPageNumTmp = PAGES_NUM_TXTM;

            // gestione TABS
            if ((MainGrid.Focused || TabSet.Focused) && (keyData == (Keys.Tab | Keys.Control))) // indietro
            {
                TabSet.SelectedIndex = (TabSet.SelectedIndex + iPageNumTmp - 1) % iPageNumTmp;
                return true;
            }
            else if ((MainGrid.Focused || TabSet.Focused) && (keyData == Keys.Tab)) // avanti
            {
                TabSet.SelectedIndex = (TabSet.SelectedIndex + 1) % iPageNumTmp;
                return true;
            }
            else if ((MainGrid.Focused || TabSet.Focused) && (
                (keyData == Keys.Up) || (keyData == Keys.Down) || (keyData == Keys.Left) || (keyData == Keys.Right) ||
                (keyData == Keys.Home) || (keyData == Keys.End) || (keyData == Keys.Escape)))
            {
                // il movimento con frecce annulla il conteggio per barcode scanner detect
                scannerInputQueue.Clear();

                MainGrid.Focus();

                if (VerificaQuantita())
                    return base.ProcessCmdKey(ref msg, keyData);
                else
                    return true; // cursore rimane sul posto
            }
            else if ((MainGrid.Focused || TabSet.Focused) && (keyData == Keys.Enter))
            {
                if (OptionsDlg._rOptionsDlg.GetEnterPrintReceipt())
                    BtnScontrino_Click(this, null);

                return true; // cursore rimane sul posto
            }
            else if (EditNote.Focused && (keyData == Keys.Enter))
            {
                if (EditNote.BackColor == Color.LightBlue)
                {
                    // acquisisce Nota Articolo
                    SF_Data.Articolo[_iCellPt].sNotaArt = EditNote.Text;

                    EditNote.BackColor = Color.Gainsboro;
                    EditNote.Text = _sEditNoteCopy;
                    EditNote.MaxLength = iMAX_RECEIPT_CHARS;
                    MF_lblNote.Text = "Nota:";

                    MainGrid_Redraw(this, null);
                }

                return true; // cursore rimane sul posto
            }
            // gestione scorrimento UP nella matrice
            else if (MainGrid.Focused && MnuSetupPricelist.Checked && (keyData == (Keys.Up | Keys.Control)))
            {
                _iCellPt = MainGrid.CurrentCell.ColumnIndex * MainGrid.RowCount + MainGrid.CurrentCell.RowIndex + iArrayOffset;
                String sTime = DateTime.Now.ToString("HH.mm.ss");

                iRow = _iCellPt % MainGrid.RowCount;
                iCol = (_iCellPt % (MainGrid.RowCount * MainGrid.ColumnCount)) / MainGrid.RowCount;

                Console.WriteLine("ProcessCmdKey1: KEY_UP _iCellPt = {0}, {1}, {2}, {3}", _iCellPt, iRow, iCol, sTime);

                if (_iCellPt > 0)
                {
                    Console.WriteLine("ProcessCmdKey2: KEY_UP");

                    TArticolo tmpArticolo = new TArticolo(SF_Data.Articolo[_iCellPt - 1]);

                    SF_Data.Articolo[_iCellPt - 1] = SF_Data.Articolo[_iCellPt];
                    SF_Data.Articolo[_iCellPt] = tmpArticolo;

                    // siamo lungo il bordo superiore, cambio colonna
                    if (iRow == 0)
                    {
                        Console.WriteLine("ProcessCmdKey3: KEY_UP cambio colonna");

                        if (iCol > 0)
                            MainGrid.CurrentCell = MainGrid.Rows[MainGrid.RowCount - 1].Cells[iCol - 1];
                        else
                            MainGrid.CurrentCell = MainGrid.Rows[MainGrid.RowCount - 1].Cells[MainGrid.ColumnCount - 1];

                        SelectTab(_iCellPt - 1);
                        MainGrid.Focus();
                    }
                    else
                        MainGrid.CurrentCell = MainGrid.Rows[iRow - 1].Cells[iCol];

                    _bListinoModificato = true;

                    FormResize(null, null);
                    MainGrid_Redraw(this, null);

                    return true;
                }
            }
            // gestione scorrimento DOWN nella matrice
            else if (MainGrid.Focused && MnuSetupPricelist.Checked && (keyData == (Keys.Down | Keys.Control)))
            {
                _iCellPt = MainGrid.CurrentCell.ColumnIndex * MainGrid.RowCount + MainGrid.CurrentCell.RowIndex + iArrayOffset;
                String sTime = DateTime.Now.ToString("HH.mm.ss");

                iRow = _iCellPt % MainGrid.RowCount;
                iCol = (_iCellPt % (MainGrid.RowCount * MainGrid.ColumnCount)) / MainGrid.RowCount;

                Console.WriteLine("ProcessCmdKey1: KEY_DOWN _iCellPt = {0}, {1}, {2}, {3}", _iCellPt, iRow, iCol, sTime);

                if (_iCellPt < (iLastGridIndex * iPageNumTmp - 1))
                {
                    Console.WriteLine("ProcessCmdKey2: KEY_DOWN");

                    TArticolo tmpArticolo = new TArticolo(SF_Data.Articolo[_iCellPt + 1]);

                    SF_Data.Articolo[_iCellPt + 1] = SF_Data.Articolo[_iCellPt];
                    SF_Data.Articolo[_iCellPt] = tmpArticolo;

                    // siamo lungo il bordo superiore, cambio colonna
                    if (iRow == MainGrid.RowCount - 1)
                    {
                        Console.WriteLine("ProcessCmdKey3: KEY_DOWN cambio colonna");

                        if (iCol < (MainGrid.ColumnCount - 1))
                            MainGrid.CurrentCell = MainGrid.Rows[0].Cells[iCol + 1];
                        else
                            MainGrid.CurrentCell = MainGrid.Rows[0].Cells[0];

                        SelectTab(_iCellPt + 1);
                        MainGrid.Focus();
                    }
                    else
                        MainGrid.CurrentCell = MainGrid.Rows[iRow + 1].Cells[iCol];

                    _bListinoModificato = true;

                    FormResize(null, null);
                    MainGrid_Redraw(this, null);

                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void EditStatus_QRC_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool bResult;
            int iNumScontrino, iRDB_StatusWeb, iGruppo, iLength;
            String sLog, sStrBarcode, sStrNum, sStrDay, sStrGruppo;
            String JSON_Type = "";

            //Dictionary<int, object> dict = null;

            iFocus_QRC_Timeout = QRC_FOCUS_TIMEOUT;

            /*************************
                      ENTER
             *************************/
            if (e.KeyChar == '\r')
            {
                // scarta edit vuoti
                if (String.IsNullOrEmpty(EditStatus_QRC.Text))
                    return;
                else
                {
                    sStrBarcode = EditStatus_QRC.Text;
                    sStrBarcode = sStrBarcode.Trim();

                    iLength = sStrBarcode.Length;

                    try
                    {
                        Dictionary<String, object> dict = null;

                        try
                        {
                            // ottiene la tabella dell'output JSON
                            var jss = new JavaScriptSerializer();
                            string sTmpJson = "";

                            Logger.Info("EditStatus_QRC_KeyPress: " + sStrBarcode);

                            // rimozione carattere di controllo Datalogic
                            sStrBarcode = sStrBarcode.Replace(((char)26).ToString(), "");
                            sStrBarcode = sStrBarcode.Replace(@"\000026", "");
                            sStrBarcode = sStrBarcode.Replace("\000026", "");

                            // correzione tastiera Italiana 142, QRcode non produce le parentesi !
                            if ((sStrBarcode[0] != '{') && sStrBarcode.Contains(_JS_ORDER))
                                sTmpJson = '{' + sStrBarcode + '}';
                            else
                                sTmpJson = sStrBarcode;


                            dict = jss.Deserialize<dynamic>(sTmpJson);

                            JSON_Type = dict["-10"].ToString();
                        }
                        catch (Exception)
                        {
                        }

                        // compatibilità con versioni precedenti
                        if (JSON_Type == _JS_ORDER)
                        {
                            // ottiene la tabella dell'output JSON
                            var jss = new JavaScriptSerializer();

                            dbAzzeraDatiOrdine(ref DB_Data);

                            DB_Data.iNumOrdineWeb = Convert.ToInt32(dict["-9"]);

                            if (dict.ContainsKey("-8"))
                                DB_Data.bAnnullato = (Convert.ToInt32(dict["-8"]) > 0);

                            if (dict.ContainsKey("-7"))
                                DB_Data.bStampato = (Convert.ToInt32(dict["-7"]) > 0);

                            DB_Data.iNumCassa = Convert.ToInt32(dict["-6"]);
                            DB_Data.iStatusReceipt = Convert.ToInt32(dict["-5"]);

                            iRDB_StatusWeb = Convert.ToInt32(dict["-5"]); // GetInt32("status");

                            DB_Data.iStatusReceipt = iRDB_StatusWeb & 0xFFF1;
                            // | BIT_CARICATO_DA_WEB doppione utile per la comprensione
                            DB_Data.iStatusReceipt = SetBit(DB_Data.iStatusReceipt, (int)STATUS_FLAGS.BIT_CARICATO_DA_WEB);

                            // shift per rialineare i bit da web e maschera bit sconti
                            DB_Data.iStatusSconto = (iRDB_StatusWeb >> 1) & 0x0007;

                            if (dict.ContainsKey("-4"))
                            {
                                try
                                {
                                    var jsonObj = jss.Deserialize<dynamic>(dict["-4"].ToString());
                                    DB_Data.sNome = String.Format("{0} {1}", (string)jsonObj[0], (string)jsonObj[1]);
                                }
                                catch (Exception)
                                {
                                    DB_Data.sNome = dict["-4"].ToString();
                                }
                            }

                            if (dict.ContainsKey("-3"))
                                DB_Data.sTavolo = dict["-3"].ToString();

                            if (dict.ContainsKey("-2"))
                                DB_Data.sNota = dict["-2"].ToString();

                            DB_Data.sPL_Checksum = dict["-1"].ToString();

                            // sparato il QRCode di test
                            if (DB_Data.sPL_Checksum == QRC_TEST_CKS)
                            {
                                if (sStrBarcode == QRC_TEST)
                                {
                                    WrnMsg.sMsg = QRC_TEST;
                                    WrnMsg.iErrID = WRN_TQR;

                                    WarningManager(WrnMsg);

                                    bResult = false;
                                    EditStatus_QRC.Text = ""; // pulizia
                                    return;
                                }
                            }

                            int iIndex, iQuantitaOrdine;

                            foreach (var item in dict)
                            {
                                if (Convert.ToInt32(item.Key) >= 0)
                                {
                                    iIndex = Convert.ToInt32(item.Key);
                                    iQuantitaOrdine = Convert.ToInt32(item.Value);

                                    DB_Data.Articolo[iIndex].iQuantitaOrdine = iQuantitaOrdine;
                                }
                            }

                            if (DB_Data.bAnnullato || DB_Data.bStampato)
                                bResult = false;
                            else
                            {
                                sLog = String.Format("Mainform : CKW = {0}, {1}", DataManager.GetWebListinoChecksum(), sStrBarcode);
                                Logger.Info(sLog);

                                _bQRCodeRunning = true;

                                // ************* caricamento in SF_Data e MainForm *************
                                bResult = DataManager.CaricaOrdine_QR_code();
                            }

                            if (!bResult)
                                EditStatus_QRC.Text = ""; // pulizia

                            sLog = String.Format("Mainform : QR_code = {0}, {1}", DB_Data.iNumOrdineWeb, bResult);
                            Logger.Info(sLog);

                            if (CheckService(Define.CFG_SERVICE_STRINGS._AUTO_QRCODE_TEST))
                            {
                                // emissione scontrino
                                BtnScontrino_Click(this, null);
                                MainGrid_Redraw(this, null);
                            }
                        }

                        // sparato barcode con checksum corretto
                        else if (StandCommonFiles.Barcode_EAN13.VerifyChecksum(sStrBarcode))
                        {
                            // lo spazio è solo per allineamento
                            sStrNum = sStrBarcode.Substring(8, 4); // numero Scontrino

                            // ribaltamento formato data
                            sStrDay = sStrBarcode.Substring(6, 2) + sStrBarcode.Substring(4, 2) + sStrBarcode.Substring(2, 2);

                            sStrGruppo = sStrBarcode.Substring(0, 2);       // Gruppo

                            iNumScontrino = Convert.ToInt32(sStrNum);
                            iGruppo = Convert.ToInt32(sStrGruppo);

                            if (CheckService(Define.CFG_SERVICE_STRINGS._AUTO_QRCODE_TEST))
                            {
                                // emissione scontrino
                                BtnScontrino_Click(this, null);
                                MainGrid_Redraw(this, null);
                            }
                        }
                        else
                        {
                            EditStatus_QRC.Text = "";
                            return;
                        }

                    }
                    catch (Exception)
                    {
                        EditStatus_QRC.Text = "";
                        WarningManager(WRN_QRE);
                    }

                    // EditStatus_BC.Text = ""; // è la stampa scontrino che farà pulizia !
                    return;
                }
            }
        }

        /// <summary>
        /// calcola la dimensione delle celle della griglia<br/>
        /// e ridisegna il contenuto della MainForm
        /// </summary>
        public void FormResize(object sender, EventArgs e)
        {
            int i, j, k, h;
            int iThresholdConst = MF_lblPlaceSett.Height + EditPlaceSett.Height + MF_lblPlaceSett.Top + 1;

            const int iStdEditDistance = 59;
            const int iCompactEditDistance = 34;

            int iRowsHeight, iPrimoGruppoStampa, iGruppoStampa, iTextRightMargin;
            String sText, sLogStr;

            float fColumnsWidth, fTextSize;

            // tutto dipende dal topPanel
            topPanel.Width = this.Size.Width - 26;

            if (panelRight.Height == 0)
                return;

            // per evitare che sia troppo stretto in modo touch
            TabSet.Width = 600;

            if (GetTouchModeEnabled())
            {
                TabSet.Height = 44;
                TabSet.Font = new Font("Tahoma", 11.25f);

                topPanel.Height = 60;
                toolStripTop.Left = 6;
                toolStripTop.Width = topPanel.Width - 2 * toolStripTop.Left - 20;
                BtnSep_T6.Visible = true;
                BtnScontrino.Size = new Size(80, 60);
            }
            else
            {
                TabSet.Height = 32;
                TabSet.Font = new Font("Tahoma", 12);

                topPanel.Height = 42;
                toolStripTop.Left = 60;
                toolStripTop.Width = topPanel.Width - 2 * toolStripTop.Left - 20;
                BtnSep_T6.Visible = false;
                BtnScontrino.Size = new Size(45, 38);
            }

            // ******** visibilità pulsanti: Btn_OSKeyb segue altra regola *********
            BtnSendMsg.Visible = !IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_SHOW_MSG_BUTTON);
            BtnSep_T2.Visible = BtnSendMsg.Visible;

            BtnTakeAway.Visible = !IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_SHOW_TAKEAWAY_BUTTON);
            BtnSep_T4.Visible = BtnTakeAway.Visible;

            BtnSconto.Visible = !IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_SHOW_DISCOUNT_BUTTON);
            BtnSep_T5.Visible = BtnSconto.Visible;

            Btn_DB_Check.Visible = !IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_SHOW_DB_BUTTON);
            BtnSep_T7.Visible = Btn_DB_Check.Visible;

            // altra regola per Btn_OSKeyb
            Btn_OSKeyb.Visible = IsBitSet(SF_Data.iGeneralProgOptions, (int)GEN_PROGRAM_OPTIONS.BIT_SHOW_TOUCH_KEYB_BUTTON);
            BtnSep_T6.Visible = Btn_OSKeyb.Visible;

            // tutto dipende dal topPanel
            toolStripTop.Height = topPanel.Height - 2;

            // posizionamento verticale elementi
            TabSet.Top = MainMenu.Height + topPanel.Height + topPanel.Margin.Top + topPanel.Margin.Bottom;

            MainGrid.Top = TabSet.Top + TabSet.Height;

            if (MnuReceiptPreview.Checked && !GetShowExternalPreview() || PREVIEW_DEBUG)
            {
                previewLeftPanel.Width = _iPreviewPanelWidthCopy; // c'è il resize()
                previewLeftPanel.Visible = true;
                checkBoxLogoPreview.Visible = true;
                picBox.Width = previewLeftPanel.Width - 16; // spazio per scrollbar

                panelGrip.Width = 8;
                panelGrip.Visible = true;
            }
            else
            {
                previewLeftPanel.Width = 2;
                previewLeftPanel.Visible = false;
                checkBoxLogoPreview.Visible = false;
                picBox.Width = previewLeftPanel.Width;

                panelGrip.Width = 2;
                panelGrip.Visible = false;
            }

            panelGrip.Left = previewLeftPanel.Left + previewLeftPanel.Width;
            previewLeftPanel.Top = TabSet.Top + TabSet.Height;
            panelGrip.Top = previewLeftPanel.Top;

            // dock
            panelGrip.Dock = DockStyle.Right;
            panelGrip.Cursor = Cursors.SizeWE;

            picBox.Left = 0;
            picBox.Top = 0;

            //picBox.Image = AnteprimaDlg.bmpCanvas;

            if (previewLeftPanel.Visible)
            {
                if ((AnteprimaDlg.rAnteprimaDlg != null) && (AnteprimaDlg.rAnteprimaDlg.GetPictureBox_Size().Height > MainGrid.Height))
                    picBox.Height = AnteprimaDlg.rAnteprimaDlg.GetPictureBox_Size().Height;
                else
                    picBox.Height = MainGrid.Height;

                previewLeftPanel.Height = MainGrid.Height - PREVIEW_BOTTOM_MARGIN;
                panelGrip.Height = MainGrid.Height;
            }

            MainGrid.Left = previewLeftPanel.Width + panelGrip.Width + previewLeftPanel.Location.X - 6;

            toolStripButtons_R.Left = topPanel.Width - toolStripButtons_R.Width - previewLeftPanel.Location.X + 10;

            if (_iButtonStatus == (int)BUTTONS_STATUS_FLAGS.BIT_WIDE) // RButtons orizzontali
            {
                toolStripButtons_R.Top = MainGrid.Top;

                toolStripButtons_R.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
                toolStripButtons_R.Size = new Size(toolStripR_WIDTH_H, toolStripR_HEIGHT_H);

                toolStripButtons_R.Items[0].Margin = new Padding(1, 1, 1, 1);
                toolStripButtons_R.Items[1].Margin = new Padding(1, 1, 1, 1);
                toolStripButtons_R.Items[2].Margin = new Padding(1, 1, 1, 1);

                toolStripButtons_R.Visible = true;
                toolStripButtons_R.Enabled = true;

                panelRight.Visible = true;
                panelRight.Enabled = true;

                panelRight.Top = toolStripButtons_R.Top + toolStripButtons_R.Height;
                panelRight.Height = MainGrid.Height - toolStripButtons_R.Height + 2;

                btnNavLeft.Visible = false;
                btnNavRight.Visible = true;

                MF_lblTable.Visible = true;
                EditTable.Visible = true;
                MF_lblName.Visible = true;
                EditName.Visible = true;
                MF_lbl_CAP.Visible = OptionsDlg.Get_CAP_ShowFlag();
                Edit_CAP.Visible = OptionsDlg.Get_CAP_ShowFlag();
                MF_lblTotal.Visible = true;
                MF_lblPaidCash.Visible = true;
                MF_lblChange.Visible = true;

                Edit_TotCorrente.Visible = true;

                EditTable.Top = EditPlaceSett.Top + iStdEditDistance;
                EditName.Top = EditTable.Top + iStdEditDistance;
                Edit_CAP.Top = EditName.Top + iStdEditDistance;
                EditPaidCash.Top = EditChange.Top - iStdEditDistance;

                MF_lblPlaceSett.Text = "COPERTI";
                MF_lblPlaceSett.Left = 69;

                MF_lblTable.Text = "TAVOLO";
                MF_lblPaidCash.Text = "PAG. CONTANTI";

                if (panelRight.Height > (7 * iThresholdConst) + 6)
                {
                    Logger.Info("FormResize: Trh = 7*");
                }
                else
                {
                    MF_lbl_CAP.Visible = false;
                    Edit_CAP.Visible = false;
                }

            }
            else if (_iButtonStatus == (int)BUTTONS_STATUS_FLAGS.BIT_NARROW) // RButtons verticali
            {
                toolStripButtons_R.Top = TabSet.Top;

                toolStripButtons_R.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
                toolStripButtons_R.Size = new Size(toolStripR_WIDTH_V, toolStripR_HEIGHT_V);

                toolStripButtons_R.Items[0].Margin = new Padding(1, 10, 1, 1);
                toolStripButtons_R.Items[1].Margin = new Padding(1, 5, 1, 1);
                toolStripButtons_R.Items[2].Margin = new Padding(1, 5, 1, 1);

                toolStripButtons_R.Visible = true;
                toolStripButtons_R.Enabled = true;

                panelRight.Visible = true;
                panelRight.Enabled = true;

                panelRight.Top = toolStripButtons_R.Top + toolStripButtons_R.Height;
                panelRight.Height = MainGrid.Height - toolStripButtons_R.Height + 28;

                btnNavLeft.Visible = false;
                btnNavRight.Visible = true;

                MF_lblTotal.Visible = true;
                Edit_TotCorrente.Visible = true;
                Edit_CAP.Visible = OptionsDlg.Get_CAP_ShowFlag();

                sLogStr = String.Format("FormResize: pRH = {0}, Trh = {1}", panelRight.Height, iThresholdConst);
                Logger.Info(sLogStr);

                // può generare sfarfallio, ma ottiene maggiore precisione
                EditTable.Top = EditPlaceSett.Top + iStdEditDistance;
                EditName.Top = EditTable.Top + iStdEditDistance;
                EditPaidCash.Top = EditChange.Top - iStdEditDistance;

                MF_lblTable.Visible = true;
                MF_lblName.Visible = true;
                MF_lbl_CAP.Visible = OptionsDlg.Get_CAP_ShowFlag();

                MF_lblTotal.Visible = true;
                MF_lblPaidCash.Visible = true;
                MF_lblChange.Visible = true;

                if (panelRight.Height > (7 * iThresholdConst) + 6)
                {
                    Logger.Info("FormResize: Trh = 7*");
                }
                else
                {
                    MF_lbl_CAP.Visible = false;
                    Edit_CAP.Visible = false;

                    if (panelRight.Height > (6 * iThresholdConst) + 6)
                    {
                        Logger.Info("FormResize: Trh = 6*");
                    }
                    else
                    {
                        MF_lblTotal.Visible = false;
                        Edit_TotCorrente.Visible = false;

                        if (panelRight.Height > (5 * iThresholdConst) + 6)
                        {
                            Logger.Info("FormResize: Trh = 5*");
                        }
                        else
                        {
                            MF_lblPaidCash.Visible = false;

                            if (panelRight.Height > (4.5 * iThresholdConst) + 6)
                            {
                                Logger.Info("FormResize: Trh = 4.5*");
                            }
                            else
                            {
                                MF_lblChange.Visible = false;
                                EditPaidCash.Top = EditChange.Top - iCompactEditDistance;

                                if (panelRight.Height > (4 * iThresholdConst) + 16)
                                {
                                    Logger.Info("FormResize: Trh = 4*");
                                }
                                else
                                {
                                    MF_lblName.Visible = false;
                                    EditName.Top = EditTable.Top + iCompactEditDistance;

                                    if (panelRight.Height > (3.5 * iThresholdConst) + 16)
                                    {
                                        Logger.Info("FormResize: Trh = 3.5*");
                                    }
                                    else
                                    {
                                        MF_lblTable.Visible = false;
                                        EditTable.Top = EditPlaceSett.Top + iCompactEditDistance;
                                        EditName.Top = EditTable.Top + iCompactEditDistance;
                                        Logger.Info("FormResize: Trh = 3*");
                                    }
                                }
                            }
                        }
                    }
                }


                MF_lblPlaceSett.Text = "COP.";
                MF_lblPlaceSett.Left = 42;

                MF_lblTable.Text = "TAV.";
                MF_lblPaidCash.Text = "PAG.";
            }
            else // Hide
            {
                toolStripButtons_R.Size = new Size(0, 0);
                toolStripButtons_R.Visible = false;
                toolStripButtons_R.Enabled = false;

                panelRight.Visible = false;
                panelRight.Enabled = false;

                btnNavLeft.Top = TabSet.Top;
                btnNavLeft.Left = MainGrid.Width + previewLeftPanel.Width + panelGrip.Width - 38;

                btnNavLeft.Visible = true;
                btnNavRight.Visible = false;
            }

            // indicazione alternativa del Totale
            toolStripTop_TC_lbl.Visible = !Edit_TotCorrente.Visible;

            TabSet.ItemSize = new Size(80, TabSet.Height - 3);

            panelRight.Left = toolStripButtons_R.Left;
            panelRight.Width = toolStripButtons_R.Width;

            int iEditWidth = toolStripButtons_R.Width - 12;

            EditPlaceSett.Width = iEditWidth;
            EditTable.Width = iEditWidth;
            EditName.Width = iEditWidth;
            Edit_CAP.Width = iEditWidth;

            MF_lblPlaceSett.Width = iEditWidth;
            MF_lblTable.Width = iEditWidth;
            MF_lblName.Width = iEditWidth;
            MF_lbl_CAP.Width = iEditWidth;

            Edit_TotCorrente.Width = iEditWidth;
            EditPaidCash.Width = iEditWidth;
            EditChange.Width = iEditWidth;
            MF_lblTotal.Width = iEditWidth;
            MF_lblPaidCash.Width = iEditWidth;
            MF_lblChange.Width = iEditWidth;

            // funzione che determina BtnSep_T8.Margin per centrare toolStripTop_TC_lbl,
            // ma per ricalcolare serve aver impostato _iToolStripTop_MarginTotal = 0;

            if (toolStripTop_TC_lbl.Visible && (_iToolStripTop_MarginTotal == 0))
            {
                //Console.WriteLine(String.Format("FormResize tsItem \n"));
                //Console.WriteLine(String.Format("FormResize tsItem = \"{0}\"", toolStripTop_TC_lbl.Text));

                foreach (ToolStripItem tsItem in toolStripTop.Items)
                {
                    if (!tsItem.Visible)
                        continue;

                    if (tsItem.Equals(BtnSep_T8))
                        _iToolStripTop_MarginTotal += (tsItem.Width + 20); // ignora tsItem.Margin.Left
                    else
                        _iToolStripTop_MarginTotal += (tsItem.Width + tsItem.Margin.Left + tsItem.Margin.Right);

                    // Console.WriteLine(String.Format("FormResize tsItem = {0},{1},{2},{3}", tsItem.Name, tsItem.Width, tsItem.Margin.Left, tsItem.Margin.Right));
                }
            }

            iTextRightMargin = ((toolStripTop.Width - toolStripTop.Padding.Left - toolStripTop.Padding.Right - _iToolStripTop_MarginTotal) / 2);

            // Console.WriteLine(String.Format("FormResize iTextRightMargin = {0}", iTextRightMargin));
            //Logger.Info("FormResize iTextRightMargin = {0}", iTextRightMargin);

            if (iTextRightMargin > 0)
                BtnSep_T8.Margin = new Padding(iTextRightMargin, 0, 20, 0);
            else
                BtnSep_T8.Margin = new Padding(0, 0, 20, 0);


            toolStripTop.Refresh();

            BtnViewPricelist.Size = BtnScontrino.Size;
            BtnSendMsg.Size = BtnScontrino.Size;
            BtnX10.Size = BtnScontrino.Size;
            BtnTakeAway.Size = BtnScontrino.Size;
            BtnSconto.Size = BtnScontrino.Size;
            Btn_DB_Check.Size = BtnScontrino.Size;

            // imposta la larghezza della griglia in base alla larghezza della form principale
            MainGrid.Width = topPanel.Width - previewLeftPanel.Width - panelGrip.Width - toolStripButtons_R.Width - previewLeftPanel.Location.X * 2 + 10;

            // imposta l'altezza della griglia in base all'altezza della form principale
            MainGrid.Height = Height - MainMenu.Size.Height - toolStripTop.Size.Height - TabSet.Height -
                                StatusBar_Upper.Size.Height - StatusBar.Size.Height - 52;

            // imposta altezza delle righe sulla base della altezza della finestra
            if ((WindowState != FormWindowState.Minimized) && (MainGrid.RowCount > 0))
            {
                iPrimoGruppoStampa = CheckFirstGroupIndex();
                _prevStyle.ForeColor = _gridStyle[_iColorTheme, iPrimoGruppoStampa].ForeColor;
                _prevStyle.BackColor = _gridStyle[_iColorTheme, iPrimoGruppoStampa].BackColor;

                bool bChars33 = IsBitSet(SF_Data.iGenericPrintOptions, (int)GEN_PRINTER_OPTS.BIT_CHARS33_PRINT_REQUIRED);

                if (MnuSetupPricelist.Checked || BtnViewPricelist.Checked)
                {
                    if (GetTouchModeEnabled())
                        sText = bChars33 ? "12345678901234567890123" : "123456789012345678";
                    else
                        // String.Format(" {0,2} {1,-18} {2,5:0.00}", // width=28
                        sText = bChars33 ? "123456789012345678901234567809123" : "1234567890123456789012345678";
                }
                else
                {
                    if (GetTouchModeEnabled())
                        sText = bChars33 ? "12345678901234567809123" : "123456789012345678";
                    else
                        // String.Format("{0,3} {1,-18} {2,2}" : // width=25
                        sText = bChars33 ? "123456789012345678901234567890" : "1234567890123456789012345";
                }

                if ((MainGrid.Height % MainGrid.RowCount) < 3)
                    iRowsHeight = (MainGrid.Height / MainGrid.RowCount) - 1; // evita scroll verticale griglia
                else
                    iRowsHeight = MainGrid.Height / MainGrid.RowCount;


                for (i = 0; i < MainGrid.RowCount; i++)
                    MainGrid.Rows[i].Height = iRowsHeight;

                fColumnsWidth = MainGrid.Columns[0].Width;

                fTextSize = TextRenderer.MeasureText(sText, MainGrid.DefaultCellStyle.Font).Width;
                _fFontWidth = fColumnsWidth / sText.Length + 0.5f;

                // avvio form
                if (_fFontWidth < 5.0)
                    _fFontWidth = ((float)iRowsHeight * 0.45f);

                //Console.WriteLine("_fFontWidth = {0}, {1}, {2}, {3}", _fFontWidth, fColumnsWidth, fTextSize, sText.Length);

                MainGrid.Font = new Font(MainGrid.DefaultCellStyle.Font.Name, _fFontWidth);

                // Grid appearance
                MainGrid.GridColor = _gridCrossStyle[_iColorTheme].ForeColor;
                MainGrid.DefaultCellStyle.SelectionForeColor = _selectedCellStyle[_iColorTheme].ForeColor;
                MainGrid.DefaultCellStyle.SelectionBackColor = _selectedCellStyle[_iColorTheme].BackColor;
                MainGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                //sText += (Environment.NewLine + "\r\n --------------");
            }

            // prepara l'aspetto della stringa visualizzata nelle celle
            for (k = 0; ((k < iLastGridIndex) && (MainGrid.RowCount > 0)); k++)
            {
                i = k % MainGrid.RowCount;
                j = k / MainGrid.RowCount;

                h = k + iArrayOffset;

                iGruppoStampa = SF_Data.Articolo[h].iGruppoStampa;

                if (MnuSetupPricelist.Checked || BtnViewPricelist.Checked)
                {
                    if (String.IsNullOrEmpty(SF_Data.Articolo[h].sTipo))
                    {
                        MainGrid.Rows[i].Cells[j].Style = new DataGridViewCellStyle(_prevStyle);
                    }
                    else
                    {
                        MainGrid.Rows[i].Cells[j].Style.ForeColor = _gridStyle[_iColorTheme, iGruppoStampa].ForeColor;
                        MainGrid.Rows[i].Cells[j].Style.BackColor = _gridStyle[_iColorTheme, iGruppoStampa].BackColor;

                        if ((iGruppoStampa != (int)DEST_TYPE.DEST_BUONI) && (iGruppoStampa != (int)DEST_TYPE.DEST_COUNTER))
                            _prevStyle = new DataGridViewCellStyle(MainGrid.Rows[i].Cells[j].Style);

                        MainGrid.Rows[i].Cells[j].Style.Font = new Font(MainGrid.DefaultCellStyle.Font.Name, _fFontWidth, FontStyle.Regular);
                    }
                }
                else
                {
                    // Disponibilità zero colore rosso
                    if (SF_Data.Articolo[h].iDisponibilita == 0)
                    {
                        MainGrid.Rows[i].Cells[j].Style.ForeColor = _zeroAvailabilityStyle[_iColorTheme].ForeColor;
                        MainGrid.Rows[i].Cells[j].Style.BackColor = _gridStyle[_iColorTheme, iGruppoStampa].BackColor;

                        MainGrid.Rows[i].Cells[j].Style.Font = new Font(MainGrid.DefaultCellStyle.Font.Name, _fFontWidth, FontStyle.Bold);
                    }
                    else if (String.IsNullOrEmpty(SF_Data.Articolo[h].sTipo))
                    {
                        MainGrid.Rows[i].Cells[j].Style = new DataGridViewCellStyle(_prevStyle);
                    }
                    else
                    {
                        MainGrid.Rows[i].Cells[j].Style.ForeColor = _gridStyle[_iColorTheme, iGruppoStampa].ForeColor;
                        MainGrid.Rows[i].Cells[j].Style.BackColor = _gridStyle[_iColorTheme, iGruppoStampa].BackColor;

                        if ((iGruppoStampa != (int)DEST_TYPE.DEST_BUONI) && (iGruppoStampa != (int)DEST_TYPE.DEST_COUNTER))
                            _prevStyle = new DataGridViewCellStyle(MainGrid.Rows[i].Cells[j].Style);

                        MainGrid.Rows[i].Cells[j].Style.Font = new Font(MainGrid.DefaultCellStyle.Font.Name, _fFontWidth, FontStyle.Regular);
                    }
                }

                // Grid appearance: estende il colore dell'angolo in basso a destra a tutta la griglia (in particolare al bordo inferiore)
                if (h == MainGrid.RowCount * MainGrid.ColumnCount + iArrayOffset - 1)
                    MainGrid.BackgroundColor = MainGrid.Rows[i].Cells[j].Style.BackColor;
            }

            //topPanel.Refresh();
            //TabSet.Refresh();

            toolStripButtons_R.Refresh();
            //panelRight.Refresh();
            MainGrid.Refresh();
        } // end FormResize

        /// <summary>
        /// ridisegna il contenuto della griglia principale
        /// </summary>
        public void MainGrid_Redraw(object sender, EventArgs e)
        {
            bool bTouchRequired;
            int i, j, k, h;
            String sTipoTmp, sTickQty, sDispQty, sPrzTmp, sGrpTmp, sCellText;
            String sToolTip;

            // prepara la stringa visualizzata nelle celle
            for (k = 0; ((k < iLastGridIndex) && (MainGrid.RowCount > 0)); k++)
            {
                i = k % MainGrid.RowCount;
                j = k / MainGrid.RowCount;

                h = k + iArrayOffset;

                if (!String.IsNullOrEmpty(SF_Data.Articolo[h].sTipo) && IsBitSet(SF_Data.Articolo[h].iOptionsFlags, BIT_STAMPA_SINGOLA_NELLA_LOCAL_COPY))
                    sTipoTmp = SF_Data.Articolo[h].sTipo.Insert(0, "$ ");
                else
                    sTipoTmp = SF_Data.Articolo[h].sTipo;

                if (SF_Data.Articolo[h].iQuantitaOrdine != 0)
                    sTickQty = SF_Data.Articolo[h].iQuantitaOrdine.ToString();
                else
                    sTickQty = "";

                if (SF_Data.Articolo[h].iDisponibilita != DISP_OK)
                    sDispQty = SF_Data.Articolo[h].iDisponibilita.ToString();
                else
                    sDispQty = "";

                sCellText = "";

                bTouchRequired = GetTouchModeEnabled();

                if (MnuSetupPricelist.Checked || BtnViewPricelist.Checked)
                {

                    sPrzTmp = IntToEuro(SF_Data.Articolo[h].iPrezzoUnitario);

                    sGrpTmp = sConstGruppiShort[SF_Data.Articolo[h].iGruppoStampa];

                    // ******** allineamento *******
                    // 89 123456789012345678 9876.00
                    // fPrint.WriteLine("{0,2} {1,-18} {2,5}", // width=28
                    if (String.IsNullOrEmpty(SF_Data.Articolo[h].sTipo))
                        sCellText = "";
                    else if (bTouchRequired)
                        sCellText = String.Format(sGRD_FMT_TCH, sGrpTmp, sPrzTmp, Environment.NewLine, CenterJustify(SF_Data.Articolo[h].sTipo, 18));
                    else
                        sCellText = String.Format(sGRD_FMT_STD, sGrpTmp, SF_Data.Articolo[h].sTipo, sPrzTmp);

                    // impostazione dei ToolTip di cella
                    if (String.IsNullOrEmpty(SF_Data.Articolo[h].sTipo))
                        sToolTip = "";
                    else
                    {
                        sToolTip = string.Format("Articolo: {0}\n", SF_Data.Articolo[h].sTipo);

                        sToolTip += string.Format("   prezzo: {0}\n", IntToEuro(SF_Data.Articolo[h].iPrezzoUnitario));

                        sToolTip += string.Format("   gruppo stampa: {0}\n", SF_Data.sCopiesGroupsText[SF_Data.Articolo[h].iGruppoStampa]);

                        sToolTip += string.Format("   {0}: {1}\n", "gruppo breve", sConstGruppiShort[SF_Data.Articolo[h].iGruppoStampa]);

                        sToolTip += string.Format("   {0}: {1}\n", "indice listino", SF_Data.Articolo[h].iIndexListino);
                    }

                    MainGrid.Rows[i].Cells[j].ToolTipText = sToolTip;
                }
                else
                {
                    // work_mode
                    // solo se disponibilità zero colore rosso
                    if (SF_Data.Articolo[h].iDisponibilita == 0)
                    {
                        MainGrid.Rows[i].Cells[j].Style.ForeColor = _zeroAvailabilityStyle[_iColorTheme].ForeColor;
                        MainGrid.Rows[i].Cells[j].Style.BackColor = _gridStyle[_iColorTheme, SF_Data.Articolo[h].iGruppoStampa].BackColor;

                        MainGrid.Rows[i].Cells[j].Style.Font = new Font(MainGrid.DefaultCellStyle.Font.Name, _fFontWidth, FontStyle.Bold);
                    }

                    if (bTouchRequired)
                    {
                        if (string.IsNullOrEmpty(sDispQty))
                            sCellText = String.Format(sGRDZ_FMT_TCH, sTickQty, Environment.NewLine, CenterJustify(sTipoTmp, 18));
                        else
                            sCellText = String.Format(sGRDW_FMT_TCH, sDispQty, sTickQty, Environment.NewLine, CenterJustify(sTipoTmp, 18));
                    }
                    else
                        sCellText = String.Format(sGRDW_FMT_STD, sDispQty, sTipoTmp, sTickQty);

                    // impostazione dei ToolTip di cella
                    if (String.IsNullOrEmpty(SF_Data.Articolo[h].sTipo) || String.IsNullOrEmpty(SF_Data.Articolo[h].sNotaArt))
                    {
                        MainGrid.Rows[i].Cells[j].ToolTipText = "";
                    }
                    else
                    {
                        sToolTip = string.Format("Nota: {0}", SF_Data.Articolo[h].sNotaArt);
                        MainGrid.Rows[i].Cells[j].ToolTipText = sToolTip;
                    }
                }

#if FONT_CHECK
                if (!_bPrimaEsecuzione && (((i + j + iArrayOffset) % 6) == 0))
                    MainGrid.Rows[i].Cells[j].Value = sText;
                else
                    MainGrid.Rows[i].Cells[j].Value = sCellText;
#else
                if (!_bPrimaEsecuzione)
                    MainGrid.Rows[i].Cells[j].Value = sCellText;
#endif
            }

            // aggiorna il web checksum in caso di modifica Listino
            Text = String.Format("{0} {1} {2} {1} webcks Listino = {3}   {4}", TITLE, "   ", RELEASE_SW, DataManager.GetWebListinoChecksum(), _sShortDBType);

            if (previewLeftPanel.Visible)
            {
                picBox.Image = AnteprimaDlg.bmpCanvas;

                //previewLeftPanel.AutoScrollPosition = new Point(-AnteprimaDlg.rAnteprimaDlg.panel.AutoScrollPosition.X,
                //                                                -AnteprimaDlg.rAnteprimaDlg.panel.AutoScrollPosition.Y);

                if ((AnteprimaDlg.rAnteprimaDlg != null) && (AnteprimaDlg.rAnteprimaDlg.GetPictureBox_Size().Height > MainGrid.Height))
                    picBox.Height = AnteprimaDlg.rAnteprimaDlg.GetPictureBox_Size().Height;
                else
                    picBox.Height = MainGrid.Height;
            }

            MainGrid.Refresh();
        } // end MainGrid_Redraw

        bool bPreviewPanelResizing = false;
        int iResizeStartX = 0;
        int iResizeStartWidth = 0;

        private void panelGrip_MouseDown(object sender, MouseEventArgs e)
        {
            bPreviewPanelResizing = true;
            iResizeStartX = Cursor.Position.X;
            iResizeStartWidth = previewLeftPanel.Width;
        }

        private void panelGrip_MouseMove(object sender, MouseEventArgs e)
        {
            int delta = Cursor.Position.X - iResizeStartX;
            int iNewWidth = iResizeStartWidth + delta;

            if (bPreviewPanelResizing)
            {
                iNewWidth = Math.Max(PREV_MIN_WIDTH, Math.Min(PREV_MAX_WIDTH, iNewWidth));
                previewLeftPanel.Width = iNewWidth;

                picBox.Width = previewLeftPanel.Width - 16; // spazio per scrollbar
                panelGrip.Left = previewLeftPanel.Left + previewLeftPanel.Width;

                // se si scommenta poi ci sono molti trascinamenti della grafica
                //AnteprimaDlg.rAnteprimaDlg.AnteprimaDlg_Resize(iNewWidth);

                //FormResize(null, null);
                //MainGrid_Redraw(this, null);
            }
        }

        private void panelGrip_MouseUp(object sender, MouseEventArgs e)
        {
            bPreviewPanelResizing = false;

            AnteprimaDlg.rAnteprimaDlg.AnteprimaDlg_Resize(previewLeftPanel.Width);
            _iPreviewPanelWidthCopy = previewLeftPanel.Width;

            FormResize(null, null);
            MainGrid_Redraw(this, null);
        }

    } // end class
} // end namespace


