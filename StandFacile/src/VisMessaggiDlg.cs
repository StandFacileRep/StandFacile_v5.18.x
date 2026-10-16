/***************************************************************************
	NomeFile : StandFacile/VisMessaggi.cs
    Data	 : 22.09.2026
	Autore	 : Mauro Artuso

 ***************************************************************************/

using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;
using static StandCommonFiles.ComDef;

using static StandCommonFiles.CommonCl;

using static StandFacile.glb;
using static StandFacile.Define;
using static StandFacile.Config;
using static StandFacile.dBaseIntf;

namespace StandFacile
{
    /// <summary>
    /// classe per la visualizzazione dei messaggi
    /// </summary>
    public partial class VisMessaggiDlg : Form
    {
#pragma warning disable IDE0044

        bool _bNuovoMessaggioReq, _bMessaggioCaricato;
        int _iNum, _iEscPosPrinterType;

        static bool _bNewMessage;

        static PrinterSettings settings = new PrinterSettings();
        static String sDefaultPrinter;

        /// <summary>riferimento a VisMessaggiDlg</summary>
        public static VisMessaggiDlg rVisMessaggiDlg;

        /// <summary>numero minimo di righe visualizzate</summary>
        public const int MIN_ROWS_NUMBER = 10;

        TErrMsg WrnMsg;

        readonly ToolTip _tt = new ToolTip
        {
            InitialDelay = 50,
            ShowAlways = true
        };

        /// <summary>
        /// costruttore
        /// </summary>
        public VisMessaggiDlg()
        {
            InitializeComponent();

            rVisMessaggiDlg = this;

            _bNewMessage = false;
            int i;

            _iNum = 0;

            // stampante Windows di Default
            sDefaultPrinter = settings.PrinterName;

            //  l'ultimo elemento del vettore è la stampante messaggi, poi di riepilogo, poi la Locale ( = non quella delle copie)
            sGlbWinPrinterParams.sMsgPrinterModel = ReadRegistry(WIN_MSG_PRINTER_MODEL_KEY, sDefaultPrinter);
            sGlbWinPrinterParams.iMsgPrinterModel = 0;

            PrintersListCombo.Items.Clear();

            i = 0;

            if (!CheckService(CFG_COMMON_STRINGS._HIDE_LEGACY_PRINTER))
                PrintersListCombo.Items.Add(_LEGACY_PRINTER);

            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                PrintersListCombo.Items.Add(printer);

                if (printer == sGlbWinPrinterParams.sMsgPrinterModel)
                {
                    if (CheckService(CFG_COMMON_STRINGS._HIDE_LEGACY_PRINTER))
                        sGlbWinPrinterParams.iMsgPrinterModel = i;
                    else
                        sGlbWinPrinterParams.iMsgPrinterModel = i + 1;  // tiene conto di _LEGACY_PRINTER
                }

                i++;
            }

            // inizializzazione stampanti ESC POS
            _iEscPosPrinterType = ReadRegistry(WIN_ESC_POS_MODEL_KEY, 0);
            checkBox_escpos.Checked = IsBitSet(iEscPosPrinterType, NUM_SEP_PRINT_GROUPS + 2);

            checkBox_escpos_Click(this, EventArgs.Empty);

            // imposta nel combo la stampante Locale
            if ((sGlbWinPrinterParams.iMsgPrinterModel >= 0) && (sGlbWinPrinterParams.iMsgPrinterModel < PrintersListCombo.Items.Count))
            {
                if (IsBitSet(iEscPosPrinterType, NUM_SEP_PRINT_GROUPS + 2))
                    PrintersListCombo.Text = sGlbWinPrinterParams.sMsgPrinterModel;
                else
                    PrintersListCombo.SelectedIndex = sGlbWinPrinterParams.iMsgPrinterModel;
            }
            else
                PrintersListCombo.SelectedIndex = 0;

            _tt.SetToolTip(PrintersListCombo, "seleziona la stampante per il messaggio");
            _tt.SetToolTip(btnSend, "invia un Messaggio a StandCucina");
            _tt.SetToolTip(BtnPrintMsg, "stampa un Messaggio");
            _tt.SetToolTip(btnExit, "esce");
        }

        /// <summary>
        /// visualizzazione del messaggio iNum
        /// </summary>
        public void VisualizzaMessaggio(int iNum)
        {
            String sNomeFileMsg, sTmp;

            _bNewMessage = false;

            textEdit_Messaggi.Clear();
            textEdit_Messaggi.ReadOnly = true;

            VM_ckBoxAllCashDesk.Enabled = true;
            VM_lblRemChar.Enabled = false;
            BtnPrev.Enabled = true;
            BtnNext.Enabled = true;

            if (bUSA_NDB())
                SF_Data.iNumOfMessages = _rdBaseIntf.dbGetNumOfMessagesFromDB();

            if (iNum > SF_Data.iNumOfMessages)
            {
                _iNum = SF_Data.iNumOfMessages;

                if (_iNum == 0)
                    _iNum++; // non ha senso visualizzare lo zero
            }
            else if (iNum < 1)
                _iNum = 1;
            else
                _iNum = iNum;

            // devo sempre sapere su che cassa DB_Data.iNumCassa si trova
            // il messaggio corrente, quindi leggo prima
            _bMessaggioCaricato = _rdBaseIntf.dbCaricaMessaggio(_iNum, VM_ckBoxAllCashDesk.Checked);

            if (IsBitSet(DB_Data.iStatusReceipt, (int)STATUS_FLAGS.BIT_RECEIPT_STAMPATO_DA_STANDCUCINA))
            {
                textEdit_Messaggi.BackColor = System.Drawing.Color.Gold;
                textEdit_Messaggi.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                textEdit_Messaggi.BackColor = System.Drawing.Color.Teal;
                textEdit_Messaggi.ForeColor = System.Drawing.SystemColors.Window;
            }

            sNomeFileMsg = String.Format(NOME_FILE_MESSAGGIO, DB_Data.iNumCassa, _iNum);

            sTmp = String.Format("VisMessaggiDlg : visualizza {0}", sNomeFileMsg);
            Logger.Info(sTmp);

            VM_toolStripMsgNum.Text = String.Format("Messaggio Num. : {0}", _iNum);
            VM_toolStripTotalMsg.Text = String.Format("Presenti : {0}", SF_Data.iNumOfMessages);

            if (_bMessaggioCaricato) // se esiste nel DB
            {
                textEdit_Messaggi.Text = DB_Data.sMessaggio.Replace("\n", "\r\n");

                VM_toolStripCashNum.Text = String.Format("{0}", sConstCassaType[DB_Data.iNumCassa - 1]);
            }
            else
            {
                textEdit_Messaggi.AppendText("\r\n Messaggio non caricabile !");
                VM_toolStripCashNum.Text = "Cassa n. -";
            }

            textEdit_Messaggi.Select(0, 0);
            _bNuovoMessaggioReq = false;

            // solo visualizzazione e non invio
            btnSend.Enabled = false;

            // solo con DB di rete
            VM_ckBoxAllCashDesk.Enabled = bUSA_NDB();

            if (!Visible)
                ShowDialog();
        }

        /// <summary>
        /// compone un nuovo messaggio
        /// </summary>
        public void NuovoMessaggioCucina()
        {
            // Limita la lunghezza del messaggio :
            // 3 righe sono di intestazione + altre 6 = 9*28 = 252 < 255

            _bNewMessage = true;

            textEdit_Messaggi.Clear();
            textEdit_Messaggi.ReadOnly = false;

            VM_ckBoxAllCashDesk.Enabled = false;
            VM_lblRemChar.Enabled = true;
            BtnPrev.Enabled = false;
            BtnNext.Enabled = false;
            textEdit_Messaggi.MaxLength = MAX_RECEIPT_CHARS * 6;

            VM_lblRemChar.Text = String.Format("Caratteri rimanenti : {0}", textEdit_Messaggi.MaxLength - textEdit_Messaggi.TextLength);

            _iNum = SF_Data.iNumOfMessages + 1;

            VM_toolStripMsgNum.Text = "Nuovo Messaggio";
            VM_toolStripTotalMsg.Text = String.Format("Presenti : {0}", SF_Data.iNumOfMessages);
            VM_toolStripCashNum.Text = String.Format("{0}", sConstCassaType[DB_Data.iNumCassa - 1]);

            _bNuovoMessaggioReq = true;
            BtnPrev.Enabled = false;
            BtnNext.Enabled = false;
            btnSend.Enabled = true;
            ShowDialog();
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            VisualizzaMessaggio(_iNum - 1);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            VisualizzaMessaggio(_iNum + 1);
        }

        private void VisTicketsDlg_KeyDown(object sender, KeyEventArgs e)
        {
            int iKey = (int)e.KeyValue;

            // in questo caso vanno gestiti solo i bottoni OK, Cancel
            if (_bNuovoMessaggioReq && (iKey != KEY_ESC))
                return;

            switch (iKey)
            {
                case KEY_LEFT:
                case KEY_UP:
                    VisualizzaMessaggio(_iNum - 1);
                    break;

                case KEY_RIGHT:
                case KEY_DOWN:
                    VisualizzaMessaggio(_iNum + 1);
                    break;

                case KEY_HOME:
                    VisualizzaMessaggio(1);
                    break;
                case KEY_END:
                    VisualizzaMessaggio(MAX_NUM_MSG);
                    break;
                case KEY_ESC:
                    Close();
                    break;
                case KEY_PAGEUP:
                    VisualizzaMessaggio(_iNum - 10);
                    break;
                case KEY_PAGEDOWN:
                    VisualizzaMessaggio(_iNum + 10);
                    break;
            }
        }

        /*************************************************
            Il nuovo messaggio viene qui scritto su file
         *************************************************/
        private void BtnOk_Click(object sender, EventArgs e)
        {
            int iNewMessageNum;
            String sNomeFileMsg, sActualDateStr;

            if ((_iNum == (SF_Data.iNumOfMessages + 1)) && (textEdit_Messaggi.Lines.Length > 0))
            {
                // controllo coerenza
                if (bUSA_NDB())
                    iNewMessageNum = _rdBaseIntf.dbNewMessageNumRequest();
                else
                    iNewMessageNum = (SF_Data.iNumOfMessages + 1);

                if (iNewMessageNum > 0)
                {
                    _iNum = iNewMessageNum;

                    SF_Data.iNumOfMessages = iNewMessageNum;

                    sNomeFileMsg = String.Format(NOME_FILE_MESSAGGIO, SF_Data.iNumCassa, _iNum);

                    _rdBaseIntf.dbSalvaMessaggio(textEdit_Messaggi.Lines, sNomeFileMsg);
                    DataManager.SalvaDati(SF_Data);

                    Logger.Info("VisMessaggiDlg : nuovo Messaggio da MainForm");
                }
                else
                {
                    sActualDateStr = GetActualDate().ToString("dd/MM/yy");

                    WrnMsg.iErrID = WRN_DNA;
                    WrnMsg.sMsg = String.Format("- PC Locale : {0}\n\n- Database : {1}\n", sActualDateStr, dbGetDateFromDB());
                    WarningManager(WrnMsg);
                }
            }

            Close();
        }

        /*********************************************************
          importante gestire il Focus correttamente, altrimenti
          le volte successive il Focus è sui bottoni
         *********************************************************/
        private void VisMessaggiDlg_Shown(object sender, EventArgs e)
        {
            textEdit_Messaggi.Focus();
        }

        private void TextEdit_Messaggi_KeyUp(object sender, KeyEventArgs e)
        {
            if (VM_lblRemChar.Enabled)
                VM_lblRemChar.Text = String.Format("Caratteri rimanenti : {0}", textEdit_Messaggi.MaxLength - textEdit_Messaggi.TextLength);
        }

        private void checkBox_escpos_Click(object sender, EventArgs e)
        {
            if (checkBox_escpos.Checked)
                PrintersListCombo.DropDownStyle = ComboBoxStyle.DropDown; // editabile
            else
                PrintersListCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// salva il Messaggio su file e lo invia alla stampante
        /// </summary>
        private void BtnPrintMsg_Click(object sender, EventArgs e)
        {
            int i, iEqRowsNumber;
            String sMessage, sTmp, sNomeFileMsg;
            StreamWriter fTxtFile;
            TData dataIdentifierParam;

            // memorizza se serve la stampante selezionata
            if (sGlbWinPrinterParams.sMsgPrinterModel != PrintersListCombo.Text)
            {
                sGlbWinPrinterParams.sMsgPrinterModel = PrintersListCombo.Text;
                sGlbWinPrinterParams.iMsgPrinterModel = PrintersListCombo.SelectedIndex;

                WriteRegistry(WIN_MSG_PRINTER_MODEL_KEY, sGlbWinPrinterParams.sMsgPrinterModel);
            }

            _iEscPosPrinterType = UpdateBit(_iEscPosPrinterType, checkBox_escpos.Checked, NUM_SEP_PRINT_GROUPS + 2);

            if (iEscPosPrinterType != _iEscPosPrinterType)
            {
                iEscPosPrinterType = _iEscPosPrinterType;
                WriteRegistry(WIN_ESC_POS_MODEL_KEY, _iEscPosPrinterType);
            }

            if (textEdit_Messaggi.Lines.Length > 0)
            {
                if (_bNewMessage)
                {
                    dataIdentifierParam = SF_Data;
                    BtnOk_Click(sender, null);
                }
                else
                    dataIdentifierParam = DB_Data;

                iEqRowsNumber = 1; // riga di partenza

                sNomeFileMsg = DataManager.GetMessagesDir() + "\\" + String.Format(NOME_FILE_MESSAGGIO, dataIdentifierParam.iNumCassa, _iNum);
                fTxtFile = File.CreateText(sNomeFileMsg);

                if (fTxtFile != null)
                {
                    sMessage = ""; // nel DB si salvano 255 char max

                    // inserisce Headers
                    if (_bNewMessage)
                    {
                        sTmp = CenterJustify(dataIdentifierParam.sHeaders[0], MAX_RECEIPT_CHARS);
                        if (!String.IsNullOrEmpty(dataIdentifierParam.sHeaders[0]))
                        {
                            sMessage += String.Format("{0}\n\n", sTmp);
                            iEqRowsNumber++; iEqRowsNumber++;
                        }

                        sTmp = String.Format("{0,-22}C.{1}", GetDateTimeString(), dataIdentifierParam.iNumCassa);
                        sTmp = CenterJustify(sTmp, MAX_RECEIPT_CHARS);
                        sMessage += String.Format("{0}\n\n", sTmp);
                        iEqRowsNumber++; iEqRowsNumber++;

                        sTmp = String.Format("{0}{1,4}", "Messaggio Numero =", _iNum);
                        sTmp = CenterJustify(sTmp, MAX_RECEIPT_CHARS);
                        sMessage += String.Format("{0}\n\n", sTmp);
                        iEqRowsNumber++; iEqRowsNumber++;
                    }

                    for (i = 0; i < textEdit_Messaggi.Lines.Length; i++)
                    {
                        sMessage += String.Format(" {0}\n", textEdit_Messaggi.Lines[i]);

                        iEqRowsNumber++;
                    }

                    sMessage = sMessage.Replace("'", "''"); // prepara la query
                    fTxtFile.WriteLine("{0}", sMessage);

                    do
                    {
                        fTxtFile.WriteLine();
                        iEqRowsNumber++;
                    }
                    while (iEqRowsNumber < MIN_ROWS_NUMBER);

                    fTxtFile.Close();

                    // Invio alla Stampante
                    Logger.Info("VisMessaggiDlg : stampa di " + sNomeFileMsg);

                    PrintFileToDestination(PrintersListCombo.Text, checkBox_escpos.Checked, sNomeFileMsg, (int)PRINT_QUEUE_ACTION.PRINT_NOW);

                    //if (PrintNetCopiesConfigDlg.GetNetPrinterTypeIsWindows(PrintersListCombo.Text))
                    //{
                    //    if (checkBox_escpos.Checked)
                    //        Printer_ESCPOS.PrintFile(sNomeFileMsg, sGlbWinPrinterParams, 0, PrintersListCombo.Text);
                    //    else
                    //        Printer_Windows.PrintFile(sNomeFileMsg, sGlbWinPrinterParams, 0, PrintersListCombo.Text);
                    //}
                    //else
                    //    Printer_Legacy.PrintFile(sNomeFileMsg, sGlbLegacyPrinterParams, (int)PRINT_QUEUE_ACTION.PRINT_NOW);

                    // aggiorna se serve il flag BIT_TICKET_STAMPATO_DA_STANDCUCINA per contrassegnare la stampa avvenuta, attenzione al '-'
                    if (!IsBitSet(dataIdentifierParam.iStatusReceipt, (int)STATUS_FLAGS.BIT_RECEIPT_STAMPATO_DA_STANDCUCINA))
                    {
                        _rdBaseIntf.dbEditStatus(-_iNum, SetBit(dataIdentifierParam.iStatusReceipt, (int)STATUS_FLAGS.BIT_RECEIPT_STAMPATO_DA_STANDCUCINA));

                        textEdit_Messaggi.BackColor = System.Drawing.Color.Gold;
                        textEdit_Messaggi.ForeColor = System.Drawing.Color.Black;
                    }
                }
            }
        }

        /// <summary>
        /// compone un messaggio di annullo scontrino
        /// </summary>
        public void ScriviMessaggioAnnullo(int iScaricoParam)
        {

            String sTmp;

            VM_lblRemChar.Enabled = false;
            BtnPrev.Enabled = true;
            BtnNext.Enabled = true;

            textEdit_Messaggi.Clear();
            textEdit_Messaggi.AppendText(" ***** ATTENZIONE *****\r\n");
            textEdit_Messaggi.AppendText("\r\n");

            sTmp = String.Format(" Lo scontrino numero {0}\r\n", iScaricoParam);
            textEdit_Messaggi.AppendText(sTmp);

            textEdit_Messaggi.AppendText("\r\n");

            textEdit_Messaggi.AppendText(" e' stato ANNULLATO !\r\n");

            _iNum = SF_Data.iNumOfMessages + 1;

            BtnOk_Click(this, null);
        }

    }
}
