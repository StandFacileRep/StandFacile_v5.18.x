/********************************************************************
    NomeFile : StandCommonSrc/VisDatiDlg_xls.cs
    Data	 : 22.07.2026
    Autore   : Mauro Artuso

    Classe di visualizzazione dei files Dati o Prezzi
 ********************************************************************/
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static StandCommonFiles.ComDef;
using static StandCommonFiles.CommonCl;
using static StandFacile.dBaseIntf;
using static StandFacile.glb;
using Excel = Microsoft.Office.Interop.Excel;

namespace StandFacile
{
    /// <summary>
    /// classe di visualizzazione dei dati, utilizza quasi sempre DB_Data,
    /// tranne dove è richiesto SF_Data.iNumCassa
    /// </summary>
    public partial class VisDatiDlg : Form
    {
#pragma warning disable IDE0060

        /// <summary>Esportazione dei dati di riepilogo giornaliero</summary>
        private void Xls_DataExport()
        {
            bool bMatch;
            int i, j, iRow, iLastItemRow, iColumn, iUpperLimit, iCAP_lastRow;
            int iDebugPrezzo, iDebugQty;
            String sNomeFile, sDataDir, sTmp, sDisp;
            String sDebugTipo;
            DateTime columnDay;

            BtnExport.Enabled = false;

            Excel.Application xlApp = null;
            Excel.Workbook xlsWorkBook = null;
            Excel.Worksheet xlsWorkSheet = null;
            Excel.Range xlsRange, xlsRangeCell;

            object misValue = System.Reflection.Missing.Value;

            for (i = 0; i < MAX_ITEMS_NUM + EXTRA_ITEMS_NUM; i++)
            {
                _ArticoliPrimaColonna[i].sTipo = "";
                _ArticoliPrimaColonna[i].iPrezzoUnitario = 0;
                _ArticoliPrimaColonna[i].iQuantita_Scaricata = 0;
                _ArticoliPrimaColonna[i].iQuantitaOrdine = 0;
                _ArticoliPrimaColonna[i].iIndexListino = 0;
                _ArticoliPrimaColonna[i].iGruppoStampa = 0;
                _ArticoliPrimaColonna[i].iQuantitaVenduta = 0;
                _ArticoliPrimaColonna[i].iQtaEsportata = 0;
                _ArticoliPrimaColonna[i].iDisponibilita = DISP_OK;
            }

            Logger.Info("FrmVisDati : Xls prima di Excel.Application()");

            try
            {
#if STANDFACILE
                sDataDir = DataManager.GetDataDir() + "\\";
#else
                sDataDir = sRootDir + "\\";
#endif

                xlApp = new Excel.Application();
                xlsWorkBook = xlApp.Workbooks.Add(misValue);
                xlsWorkSheet = (Excel.Worksheet)xlsWorkBook.Worksheets.get_Item(1); // xls tab1

                if (VD_CheckBoxCashUnion.Checked)
                {
                    sNomeFile = "Dati_";
                    xlsWorkSheet.Name = "Dati_";
                }
                else
                {
                    sNomeFile = String.Format("Dati_C{0}_", _iNumCassa);
                    xlsWorkSheet.Name = String.Format("Dati_C{0}", _iNumCassa);
                }

                if (_SelRange == null)
                    _SelRange = new SelectionRange(GetActualDate(), GetActualDate());

                // se _sNomeTabella == "" selezionato un range di date, altrimenti si arriva da EsploraDB_Dlg
                if (String.IsNullOrEmpty(_sNomeTabella))
                {
                    if (_SelRange.Start == _SelRange.End)
                    {
                        _SelRange = new SelectionRange(_SelDate, _SelDate);
                        sNomeFile += _SelDate.ToString("yyMMdd'.xlsx'");
                    }
                    else
                        sNomeFile += (_SelRange.Start.ToString("yyMMdd") + _SelRange.End.ToString("_yyMMdd'.xlsx'"));
                }
                else
                    sNomeFile = _sNomeTabella + ".xlsx";

                if (File.Exists(sDataDir + sNomeFile))
                    File.Delete(sDataDir + sNomeFile);

                _iLastArticoloIndexP1 = MAX_ITEMS_NUM; // successivamente potrebbe incrementare

                iLastItemRow = 0;
                iCAP_lastRow = 0;

                _lista_CAP_PrimaColonna.Clear();

                for (int iRepeatForLayout = 0; iRepeatForLayout < 2; iRepeatForLayout++)
                {
                    iColumn = 0;
                    iUpperLimit = 0;
                    columnDay = _SelRange.Start;

                    while (columnDay <= _SelRange.End)
                    {
                        /***************** punto di caricamento dati DB ****************/

                        CAP_list.Clear();

                        //  _sNomeTabella è usato solo da EsploraDB_Dlg
                        if (String.IsNullOrEmpty(_sNomeTabella))
                        {
                            if (VD_CheckBoxCashUnion.Checked)
                                // iNumCassaParam == 0 legge senza filtro per cassa
                                _rdBaseIntf.dbCaricaDatidaOrdini(columnDay, 0);
                            else
                                _rdBaseIntf.dbCaricaDatidaOrdini(columnDay, _iNumCassa);
                        }

                        InitFormatStrings(dbGetLengthArticoli());

                        if (DB_Data.iActualNumOfReceipts <= 0)
                        {
                            columnDay = columnDay.AddDays(+1);
                            continue;
                        }

                        // Headers
                        if (iColumn == 0)
                        {
                            iRow = 2;
                            j = 0;

                            // compattazione
                            for (i = 0; (i < MAX_ITEMS_NUM); i++) // COPERTI inclusi
                                if (!(String.IsNullOrEmpty(DB_Data.Articolo[i].sTipo)))
                                {
                                    _ArticoliPrimaColonna[j] = DB_Data.Articolo[i];
                                    j++;
                                }

                            // calcolo ultimo indice anche in date passate, no DataManager.CheckLastArticoloIndexP1()
                            iUpperLimit = CheckLastArticoloIndexP1();

                            sTmp = String.Format("{0}", DB_Data.sVersione);
                            xlsWorkSheet.Cells[iRow++, 2] = sTmp;

                            xlsWorkSheet.Cells[iRow++, 2] = Text.Trim(); // Caption

                            iRow++;

                            xlsWorkSheet.Cells[iRow++, 2] = DB_Data.sHeaders[0];
                            xlsWorkSheet.Cells[iRow++, 2] = DB_Data.sHeaders[1];

                            xlsWorkSheet.Cells[iRow++, 2] = "Num. Scontrini emessi";

                            xlsWorkSheet.Cells[iRow++, 2] = "Num. Scontrini Web";

                            //if (DB_Data.iNumAnnullati > 0)
                            xlsWorkSheet.Cells[iRow++, 2] = "Num. Scontr. annullati e valore";
                            //else
                            //    xlsWorkSheet.Cells[iRow++, 2] = "Num. Scontr. annullati";

                            // recupera l'ora dalla CASSA_PRINCIPALE
                            xlsWorkSheet.Cells[iRow++, 2] = DB_Data.sDateTime;
                            xlsWorkSheet.Cells[iRow, 2] = "articolo";
                            xlsWorkSheet.Cells[iRow + 1, 3] = "prz. unitario";

                        } // end if
                        else
                            iRow = XLS_VOFFSET - 2; // rimpicciolisce se si aggiungono righe di informazioni

                        xlsWorkSheet.Cells[iRow - 4, iColumn + 4] = DB_Data.iActualNumOfReceipts;

                        xlsWorkSheet.Cells[iRow - 3, iColumn + 4] = DB_Data.iNumOfWebReceipts;

                        if (DB_Data.iNumAnnullati > 0)
                        {
                            xlsWorkSheet.Cells[iRow - 2, iColumn + 4] = DB_Data.iNumAnnullati;
                            xlsWorkSheet.Cells[iRow - 2, iColumn + 5] = (DB_Data.iTotaleAnnullato) / 100.0f;

                            xlsRangeCell = (Excel.Range)xlsWorkSheet.Cells[iRow - 2, iColumn + 5];
                            xlsRangeCell.NumberFormat = NUMERIC_CELL_FORMAT;
                        }
                        else
                        {
                            xlsWorkSheet.Cells[iRow - 2, iColumn + 4] = DB_Data.iNumAnnullati;
                        }

                        xlsWorkSheet.Cells[iRow - 1, iColumn + 4] = DB_Data.sDateTime.Trim().Substring(4, 8);

                        xlsWorkSheet.Cells[iRow, iColumn + 4] = "quant. venduta";

                        if (_SelRange.Start == _SelRange.End)
                            xlsWorkSheet.Cells[iRow, iColumn + 6] = "dispon.";

                        iRow++;

                        xlsWorkSheet.Cells[iRow, iColumn + 5] = "parziale";

                        if (!VD_CheckBoxRedColumns.Checked && (_SelRange.Start == _SelRange.End))
                            xlsWorkSheet.Cells[iRow, iColumn + 7] = "quant.esportazione";

                        // loop principale
                        for (i = 0; i < MAX_ITEMS_NUM + EXTRA_ITEMS_NUM; i++)
                        {
                            sDebugTipo = DB_Data.Articolo[i].sTipo;
                            iDebugPrezzo = DB_Data.Articolo[i].iPrezzoUnitario;
                            iDebugQty = DB_Data.Articolo[i].iQuantitaVenduta;

                            if (String.IsNullOrEmpty(DB_Data.Articolo[i].sTipo))
                                continue;

                            /************************************
                             *     controllo di sicurezza
                             ************************************/
                            bMatch = false;

                            for (j = 0; j < _iLastArticoloIndexP1; j++)
                            {
                                if (_ArticoliPrimaColonna[j].sTipo == DB_Data.Articolo[i].sTipo)
                                {
                                    bMatch = true;
                                    break;
                                } //
                            } // end for j

                            // aggiunge alla fine la voce altrimenti non trovata
                            if (!bMatch)
                            {
                                _ArticoliPrimaColonna[_iLastArticoloIndexP1] = DB_Data.Articolo[i];

                                if (_iLastArticoloIndexP1 < (MAX_ITEMS_NUM + EXTRA_ITEMS_NUM - 1))
                                {
                                    j = _iLastArticoloIndexP1;

                                    _iLastArticoloIndexP1++; // può arrivare a (MAX_NUM_ARTICOLI + EXTRA_ITEMS_NUM - 1) per non sforare
                                }
                                else
                                {
                                    _WrnMsg.sMsg = String.Format("{0}", DB_Data.Articolo[i].sTipo);
                                    _WrnMsg.iErrID = WRN_NVD;
                                    WarningManager(_WrnMsg);
                                }
                            }

                            if ((DB_Data.Articolo[i].iPrezzoUnitario > 0) ||
#if STANDFACILE
                                (!String.IsNullOrEmpty(DB_Data.Articolo[i].sTipo) && OptionsDlg._rOptionsDlg.GetZeroPriceEnabled()) ||
#endif
                                (DB_Data.Articolo[i].iGruppoStampa == (int)DEST_TYPE.DEST_COUNTER))
                            {
                                if (DB_Data.Articolo[i].iDisponibilita == DISP_OK)
                                    sDisp = "OK";
                                else
                                    sDisp = DB_Data.Articolo[i].iDisponibilita.ToString();

                                if ((columnDay == _SelRange.Start) || (iUpperLimit < _iLastArticoloIndexP1))
                                {
                                    iUpperLimit = _iLastArticoloIndexP1;

                                    if (DB_Data.Articolo[i].iGruppoStampa == (int)DEST_TYPE.DEST_BUONI)
                                        xlsWorkSheet.Cells[XLS_VOFFSET + j, 2] = _ArticoliPrimaColonna[j].sTipo + " (*)";
                                    else
                                        xlsWorkSheet.Cells[XLS_VOFFSET + j, 2] = _ArticoliPrimaColonna[j].sTipo;

                                    xlsWorkSheet.Cells[XLS_VOFFSET + j, 3] = (_ArticoliPrimaColonna[j].iPrezzoUnitario) / 100.0f;
                                }

                                xlsWorkSheet.Cells[XLS_VOFFSET + j, iColumn + 4] = DB_Data.Articolo[i].iQuantitaVenduta;

                                if (DB_Data.Articolo[i].iGruppoStampa == (int)DEST_TYPE.DEST_COUNTER)
                                {
                                    if (DB_Data.Articolo[i].sTipo == _COPERTO)
                                        xlsWorkSheet.Cells[XLS_VOFFSET + j, iColumn + 5] = (DB_Data.Articolo[i].iPrezzoUnitario * DB_Data.Articolo[i].iQuantitaVenduta) / 100.0f;
                                    else
                                        xlsWorkSheet.Cells[XLS_VOFFSET + j, iColumn + 5] = 0;
                                }
                                else
                                {
                                    if (DB_Data.Articolo[i].iGruppoStampa == (int)DEST_TYPE.DEST_BUONI)
                                        xlsWorkSheet.Cells[XLS_VOFFSET + j, iColumn + 5] = (-DB_Data.Articolo[i].iPrezzoUnitario * DB_Data.Articolo[i].iQuantitaVenduta) / 100.0f;
                                    else
                                        xlsWorkSheet.Cells[XLS_VOFFSET + j, iColumn + 5] = (DB_Data.Articolo[i].iPrezzoUnitario * DB_Data.Articolo[i].iQuantitaVenduta) / 100.0f;

                                }

                                if (_SelRange.Start == _SelRange.End)
                                    xlsWorkSheet.Cells[XLS_VOFFSET + j, iColumn + 6] = sDisp;

                                if (!VD_CheckBoxRedColumns.Checked && (_SelRange.Start == _SelRange.End))
                                    xlsWorkSheet.Cells[XLS_VOFFSET + j, iColumn + 7] = DB_Data.Articolo[i].iQtaEsportata;
                            }
                        }

                        // verifica lo storico e prosegue con iRow
                        if (iLastItemRow < (XLS_VOFFSET + _iLastArticoloIndexP1))
                            iLastItemRow = XLS_VOFFSET + _iLastArticoloIndexP1;

                        iRow = iLastItemRow;

                        // questa parte va scritta solo al secondo passaggio
                        if (iRepeatForLayout == 1)
                        {
                            xlsWorkSheet.Cells[iRow++, iColumn + 5] = "---------";

                            xlsWorkSheet.Cells[iRow, 4] = "TOTALE";
                            xlsWorkSheet.Cells[iRow++, iColumn + 5] = (DB_Data.iTotaleIncasso - DB_Data.iTotaleBuoniApplicati) / 100.0f;

                            //if (DB_Data.iTotaleBuoniApplicati > 0)
                            {
                                iRow++;

                                xlsWorkSheet.Cells[iRow, 4] = "valore effettivo buoni applicati (*)";
                                xlsWorkSheet.Cells[iRow++, iColumn + 5] = (DB_Data.iTotaleBuoniApplicati) / 100.0f;
                            }

                            //if ((DB_Data.iTotaleScontatoStd > 0) || (DB_Data.iTotaleScontatoFisso > 0) || (DB_Data.iTotaleScontatoGratis > 0))
                            {
                                iRow++;

                                xlsWorkSheet.Cells[iRow, 4] = "valore gratuiti";
                                xlsWorkSheet.Cells[iRow++, iColumn + 5] = (DB_Data.iTotaleScontatoGratis) / 100.0f;

                                xlsWorkSheet.Cells[iRow, 4] = "valore sconto fisso";
                                xlsWorkSheet.Cells[iRow++, iColumn + 5] = (DB_Data.iTotaleScontatoFisso) / 100.0f;

                                xlsWorkSheet.Cells[iRow, 4] = "valore sconto articoli";
                                xlsWorkSheet.Cells[iRow++, iColumn + 5] = (DB_Data.iTotaleScontatoStd) / 100.0f;

                                xlsWorkSheet.Cells[iRow++, iColumn + 5] = "---------";
                                xlsWorkSheet.Cells[iRow, 4] = "TOTALE NETTO";
                                xlsWorkSheet.Cells[iRow++, iColumn + 5] = (DB_Data.iTotaleIncasso - DB_Data.iTotaleBuoniApplicati - DB_Data.iTotaleScontatoStd -
                                                                            DB_Data.iTotaleScontatoFisso - DB_Data.iTotaleScontatoGratis) / 100.0f;
                            }

                            //if ((DB_Data.iTotaleCard > 0) || (DB_Data.iTotaleSatispay > 0))
                            {
                                iRow++;

                                xlsWorkSheet.Cells[iRow, 4] = "PAGAM. CARD";
                                xlsWorkSheet.Cells[iRow++, iColumn + 5] = (DB_Data.iTotaleCard) / 100.0f;

                                xlsWorkSheet.Cells[iRow, 4] = "PAGAM. SATISPAY";
                                xlsWorkSheet.Cells[iRow++, iColumn + 5] = (DB_Data.iTotaleSatispay) / 100.0f;

                                xlsWorkSheet.Cells[iRow, 4] = "PAGAM. CONT.";
                                xlsWorkSheet.Cells[iRow++, iColumn + 5] = (DB_Data.iTotaleIncasso - DB_Data.iTotaleBuoniApplicati - DB_Data.iTotaleScontatoStd - DB_Data.iTotaleScontatoFisso -
                                                                            DB_Data.iTotaleScontatoGratis - DB_Data.iTotaleCard - DB_Data.iTotaleSatispay) / 100.0f;
                            }

                            // ************************ FORMATTAZIONE ************************

                            // eseguito solo una volta, imposta larghezza B, C
                            if (iColumn == 0)
                            {
                                String sFormat = String.Format("B1:B{0}", iRow - 1); // fino ad iRow
                                xlsRange = xlsWorkSheet.get_Range(sFormat, Type.Missing);
                                xlsRange.EntireColumn.ColumnWidth = 30;

                                sFormat = String.Format("B{0}:B500", iRow); // dopo iRow
                                xlsRange = xlsWorkSheet.get_Range(sFormat, Type.Missing);
                                xlsRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

                                sFormat = String.Format("C12:C{0}", iRow - 1); // fino ad iRow
                                xlsRange = xlsWorkSheet.get_Range(sFormat, Type.Missing);
                                xlsRange.EntireColumn.ColumnWidth = 12;
                                xlsRange.NumberFormat = NUMERIC_CELL_FORMAT;

                                sFormat = String.Format("C{0}:C500", iRow); // dopo iRow
                                xlsRange = xlsWorkSheet.get_Range(sFormat, Type.Missing);
                                xlsRange.NumberFormat = "0";
                                xlsRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                            }

                            {
                                // imposta stringa di formato per Larghezza colonne,e formato numerico fino ad iRow
                                String sFormat = String.Format("{0}12:{0}{1}", Convert.ToChar(0X44 + iColumn), iRow); // 'D'

                                xlsRange = xlsWorkSheet.get_Range(sFormat, Type.Missing);
                                xlsRange.EntireColumn.ColumnWidth = 12;
                                xlsRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

                                sFormat = String.Format("{0}12:{0}{1}", Convert.ToChar(0X45 + iColumn), iRow); // 'E'

                                xlsRange = xlsWorkSheet.get_Range(sFormat, Type.Missing);
                                xlsRange.EntireColumn.ColumnWidth = 10;
                                xlsRange.NumberFormat = NUMERIC_CELL_FORMAT;
                                xlsRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                            }

                            {
                                // imposta stringa di formato per Larghezza colonne,e formato numerico dopo iRow
                                String sFormat = String.Format("{0}{1}:{0}500", Convert.ToChar(0X44 + iColumn), iRow); // 'D'

                                xlsRange = xlsWorkSheet.get_Range(sFormat, Type.Missing);
                                xlsRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

                                sFormat = String.Format("{0}{1}:{0}500", Convert.ToChar(0X45 + iColumn), iRow); // 'E'

                                xlsRange = xlsWorkSheet.get_Range(sFormat, Type.Missing);
                                xlsRange.NumberFormat = "0";
                                xlsRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                            }

                            // ************************ CAP ************************
#if STANDFACILE
                            if (OptionsDlg.Get_CAP_ShowFlag())
                            {
                                iRow++;

                                if (iColumn == 0)
                                {
                                    xlsWorkSheet.Cells[iRow, 2] = "CAP_ID";
                                    xlsWorkSheet.Cells[iRow, 4] = "CAP";

                                    if (_SelRange.Start != _SelRange.End)
                                        xlsWorkSheet.Cells[iRow, 3] = "CAP_TOTALE";
                                }
                                else
                                    xlsWorkSheet.Cells[iRow, iColumn + 4] = "CAP";

                                iRow++;

                                if (iCAP_lastRow < iRow)
                                    iCAP_lastRow = iRow;

                                var CAP_list_Ord = CAP_list.OrderBy(c => c.sCAP_ID).ToList();

                                foreach (var cap in CAP_list_Ord)
                                {
                                    int iListIndex = _lista_CAP_PrimaColonna.FindIndex(c => c.sCAP_ID == cap.sCAP_ID);

                                    if (iListIndex >= 0)
                                    {

                                        TCAP temp = _lista_CAP_PrimaColonna[iListIndex];    // copia della struct

                                        temp.iCAP_count = temp.iCAP_count + cap.iCAP_count; // incremento
                                        _lista_CAP_PrimaColonna[iListIndex] = temp;         // riscrivo nella lista

                                        if (_SelRange.Start != _SelRange.End)
                                            xlsWorkSheet.Cells[iRow + iListIndex, 3] = _lista_CAP_PrimaColonna[iListIndex].iCAP_count.ToString();

                                        xlsWorkSheet.Cells[iRow + iListIndex, iColumn + 4] = cap.iCAP_count;
                                    }
                                    else
                                    {
                                        _lista_CAP_PrimaColonna.Add(new TCAP
                                        {
                                            sCAP_ID = cap.sCAP_ID,
                                            iCAP_count = cap.iCAP_count
                                        });

                                        xlsWorkSheet.Cells[iCAP_lastRow, 2] = cap.sCAP_ID;

                                        if (_SelRange.Start != _SelRange.End)
                                            xlsWorkSheet.Cells[iCAP_lastRow, 3] = cap.iCAP_count.ToString();

                                        xlsWorkSheet.Cells[iCAP_lastRow, iColumn + 4] = cap.iCAP_count;

                                        iCAP_lastRow++;
                                    }
                                }
                            }
#endif

                            if (_SelRange.Start == _SelRange.End)
                            {
                                xlsRange = xlsWorkSheet.get_Range("F12:F500", Type.Missing);
                                xlsRange.EntireColumn.ColumnWidth = 10;
                                xlsRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                            }
                        }

                        // aggiornamento indici
                        columnDay = columnDay.AddDays(+1);
                        iColumn += 2;

                    } // end while (columnDay <= _SelRange.End)
                } // for ... iRepeatForLayout

                Logger.Info("VisDatiDlg : EsportaDati");

                xlsWorkBook.SaveAs(sDataDir + sNomeFile);
                xlsWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();


                if (VD_CheckBoxExport.Checked)
                    System.Diagnostics.Process.Start(sDataDir + sNomeFile);

                Marshal.ReleaseComObject(xlsWorkSheet);
                Marshal.ReleaseComObject(xlsWorkBook);
                Marshal.ReleaseComObject(xlApp);

                BtnExport.Enabled = true;
            }
            catch (Exception)
            {
                BtnExport.Enabled = true;
                _WrnMsg.iErrID = WRN_EXN;
                WarningManager(_WrnMsg);
            }
        }


        /// <summary>Esportazione xlsx degli ordini</summary>
        private void Xls_OrdersExport()
        {
            bool bOrdineCaricato, bOnce, bBuoniApplicati, bBuoniApplicatiParz;
            int i, j, k, iRow, iUpperLimit;
            int iWS_Index, iDebugNumOfItems;

            // non si riferiscono a nessun ordine in particolare
            int iTotaleParz, iTotaleReceipt, iBuoniApplicatiReceipt, iBuoniApplicatiParz, iTotaleReceiptDovuto;
            int iStatusScontoReceipt, iScontoStdReceipt, iScontoFissoReceipt, iScontoGratisReceipt;

            String sNomeFile, sDataDir, sTmp;
            String sDebugTipo;
            DateTime columnDay;

            BtnExport.Enabled = false;

            bool[] bScontoGruppo = new bool[NUM_SEP_PRINT_GROUPS];

            Excel.Application xlApp = null;
            Excel.Workbook xlsWorkBook = null;
            //Excel.Worksheet xlsWorkSheet = null;
            Excel.Range xlsRange;

            object missValue = System.Reflection.Missing.Value;

            var ordiniWS = new List<Excel.Worksheet>();

            Logger.Info("FrmVisDati : Xls prima di Excel.Application()");

            try
            {
#if STANDFACILE
                sDataDir = DataManager.GetDataDir() + "\\";
#else
                sDataDir = sRootDir + "\\";
#endif

                xlApp = new Excel.Application();
                xlsWorkBook = xlApp.Workbooks.Add(missValue);

                if (VD_CheckBoxCashUnion.Checked)
                    sNomeFile = "Ordini_";
                else
                    sNomeFile = String.Format("Ordini_C{0}_", _iNumCassa);

                if (_SelRange == null)
                    _SelRange = new SelectionRange(GetActualDate(), GetActualDate());

                // se _sNomeTabella == "" selezionato un range di date, altrimenti si arriva da EsploraDB_Dlg
                if (String.IsNullOrEmpty(_sNomeTabella))
                {
                    if (_SelRange.Start == _SelRange.End)
                    {
                        _SelRange = new SelectionRange(_SelDate, _SelDate);
                        sNomeFile += _SelDate.ToString("yyMMdd'.xlsx'");
                    }
                    else
                        sNomeFile += (_SelRange.Start.ToString("yyMMdd") + _SelRange.End.ToString("_yyMMdd'.xlsx'"));
                }
                else
                    sNomeFile = _sNomeTabella + ".xlsx";

                if (File.Exists(sDataDir + sNomeFile))
                    File.Delete(sDataDir + sNomeFile);

                _iLastArticoloIndexP1 = MAX_ITEMS_NUM; // successivamente potrebbe incrementare

                iWS_Index = -1;
                iUpperLimit = 0;
                columnDay = _SelRange.Start;

                while (columnDay <= _SelRange.End)
                {
                    /***************** punto di caricamento dati DB ****************/

                    //  _sNomeTabella è usato solo da EsploraDB_Dlg
                    if (String.IsNullOrEmpty(_sNomeTabella))
                    {
                        if (VD_CheckBoxCashUnion.Checked)
                            // iNumCassaParam == 0 legge senza filtro per cassa
                            _rdBaseIntf.dbCaricaDatidaOrdini(columnDay, 0);
                        else
                            _rdBaseIntf.dbCaricaDatidaOrdini(columnDay, _iNumCassa);
                    }

                    if (DB_Data.iActualNumOfReceipts <= 0)
                    {
                        columnDay = columnDay.AddDays(+1);
                        continue;
                    }

                    iWS_Index++;


                    if (iWS_Index > 0)
                    {
                        Excel.Worksheet last_WS = (Excel.Worksheet)xlsWorkBook.Worksheets[xlsWorkBook.Worksheets.Count - 1];
                        ordiniWS.Add(xlsWorkBook.Worksheets.Add(After: last_WS));
                    }
                    else
                        ordiniWS.Add(xlsWorkBook.Worksheets.Add());


                    if (VD_CheckBoxCashUnion.Checked)
                    {
                        ordiniWS[iWS_Index].Name = String.Format("Ordini_{0}", columnDay.ToString("yyMMdd"));
                    }
                    else
                    {
                        ordiniWS[iWS_Index].Name = String.Format("Ordini_{0}_C{1}", columnDay.ToString("yyMMdd"), _iNumCassa);
                    }

                    // Headers
                    iRow = 2;
                    j = 0;

                    // calcolo ultimo indice anche in date passate, no DataManager.CheckLastArticoloIndexP1()
                    iUpperLimit = CheckLastArticoloIndexP1();

                    sTmp = String.Format("{0}", DB_Data.sVersione);
                    ordiniWS[iWS_Index].Cells[iRow++, 2] = sTmp;

                    ordiniWS[iWS_Index].Cells[iRow++, 2] = Text.Trim(); // Caption

                    ordiniWS[iWS_Index].Cells[iRow++, 2] = DB_Data.sHeaders[0];
                    ordiniWS[iWS_Index].Cells[iRow++, 2] = DB_Data.sHeaders[1];
                    iRow++;

                    ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 1] = "numero Scontrino";
                    ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 2] = "articolo";
                    ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 3] = "prezzo unitario";
                    ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 4] = "quantità venduta";
                    ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 5] = "parziale";
                    ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 6] = "Totale Scontrino";
                    ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 7] = "note";

                    iRow++;

                    ordersProgressBar.Maximum = DB_Data.iActualNumOfReceipts;
                    VD_CheckBoxOrders.Text = "Esporta Ordini " + columnDay.ToString("dd/MM");
                    VD_CheckBoxOrders.Refresh();

                    // loop principale

                    for (k = 1; k <= DB_Data.iNumOfLastReceipt; k++)
                    {
                        bOnce = true;
                        ordersProgressBar.Value = k;

                        // non si riferiscono a nessun ordine in particolare
                        bBuoniApplicatiParz = false;
                        bBuoniApplicati = false;
                        iTotaleReceipt = 0;
                        iStatusScontoReceipt = 0;
                        iScontoStdReceipt = 0;
                        iScontoFissoReceipt = 0;
                        iScontoGratisReceipt = 0;
                        iBuoniApplicatiReceipt = 0;
                        iBuoniApplicatiParz = 0;
                        iTotaleReceiptDovuto = 0;

                        if (VD_CheckBoxCashUnion.Checked)
                            bOrdineCaricato = _rdBaseIntf.dbCaricaOrdine(columnDay, k, 0);
                        else
                            bOrdineCaricato = _rdBaseIntf.dbCaricaOrdine(columnDay, k, _iNumCassa);

                        iDebugNumOfItems = DB_Data.iNumOfReceiptItems;

                        // scontrino emesso da altra cassa
                        if (DB_Data.iNumOfReceiptItems == 0)
                            continue;

                        for (j = 0; j < DB_Data.iNumOfReceiptItems; j++)
                        {
                            sDebugTipo = DB_Data.Articolo[j].sTipo;

                            if (bOnce)
                            {
                                iStatusScontoReceipt = DB_Data.iStatusSconto;

                                for (i = 0; i < NUM_SEP_PRINT_GROUPS; i++)
                                    bScontoGruppo[i] = IsBitSet(DB_Data.iStatusSconto, 4 + i);

                                if (IsBitSet(DB_Data.iStatusSconto, BIT_SCONTO_STD))
                                    iScontoStdReceipt = DB_Data.iScontoStdReceipt;
                                else if (IsBitSet(DB_Data.iStatusSconto, BIT_SCONTO_FISSO))
                                    iScontoFissoReceipt = DB_Data.iScontoFissoReceipt;
                                else if (IsBitSet(DB_Data.iStatusSconto, BIT_SCONTO_GRATIS))
                                    iScontoGratisReceipt = DB_Data.iScontoGratisReceipt;

                                ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET] = DB_Data.sDateTime;
                                bOnce = false;
                            }

                            if (DB_Data.Articolo[j].iQuantitaOrdine > 0)
                            {
                                iTotaleParz = DB_Data.Articolo[j].iPrezzoUnitario * DB_Data.Articolo[j].iQuantitaOrdine;

                                if (DB_Data.Articolo[j].iGruppoStampa == (int)DEST_TYPE.DEST_BUONI)
                                {
                                    bBuoniApplicati = true;

                                    iBuoniApplicatiParz = iTotaleParz;
                                    iBuoniApplicatiReceipt += iTotaleParz;
                                    iTotaleReceipt -= iTotaleParz;
                                }
                                else
                                    iTotaleReceipt += iTotaleParz;

                                ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 1] = k;
                                ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 2] = DB_Data.Articolo[j].sTipo;
                                ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 3] = DB_Data.Articolo[j].iPrezzoUnitario / 100.0f;
                                ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 4] = DB_Data.Articolo[j].iQuantitaOrdine;
                                ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 5] = iTotaleParz / 100.0f;

                                if (!String.IsNullOrEmpty(DB_Data.Articolo[j].sNotaArt))
                                    ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 7] = DB_Data.Articolo[j].sNotaArt;

                                iRow++;
                            }
                        } // end for

                        if (!String.IsNullOrEmpty(DB_Data.sNota))
                        {
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 1] = k;
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 2] = "*** NOTA ***";
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 7] = DB_Data.sNota;
                            DB_Data.sNota = "";

                            iRow++;
                        }

                        if (IsBitSet(iStatusScontoReceipt, BIT_SCONTO_STD) && StandCommonFiles.ReceiptAndCopies.TicketScontatoStdIsGood(DB_Data, bScontoGruppo))
                        {
                            iTotaleReceiptDovuto = iTotaleReceipt - iScontoStdReceipt;

                            if (iTotaleReceiptDovuto < 0)
                            {
                                iTotaleReceiptDovuto = 0;
                                iScontoStdReceipt = iTotaleReceipt;
                            }
                            
                            //double fScontoStdReceipt = Math.Round(iScontoStdReceipt / 100.0f, 2);

                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 1] = k;
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 2] = "*** SCONTO ***";
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 3] = Math.Round(iScontoStdReceipt / 100.0f, 2);
                            iRow++;

                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 1] = k;
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 2] = "*** TOTALE ***";
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 3] = Math.Round(iTotaleReceipt / 100.0f, 2);
                            iRow++;

                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 1] = k;
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 2] = "*** DIFF. DOVUTA ***";
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 6] = Math.Round(iTotaleReceiptDovuto / 100.0f, 2);
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 7] = DB_Data.sScontoText;
                            iRow++;
                        }
                        else if (IsBitSet(iStatusScontoReceipt, BIT_SCONTO_FISSO))
                        {
                            iTotaleReceiptDovuto = iTotaleReceipt - iScontoFissoReceipt;

                            if (iTotaleReceiptDovuto < 0)
                            {
                                iTotaleReceiptDovuto = 0;
                                iScontoFissoReceipt = iTotaleReceipt;
                            }

                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 1] = k;
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 2] = "*** SCONTO ***";
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 3] = iScontoFissoReceipt / 100.0f;
                            iRow++;

                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 1] = k;
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 2] = "*** TOTALE ***";
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 3] = iTotaleReceipt / 100.0f;
                            iRow++;

                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 1] = k;
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 2] = "*** DIFF. DOVUTA ***";
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 6] = iTotaleReceiptDovuto / 100.0f;
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 7] = DB_Data.sScontoText;
                            iRow++;
                        }
                        else if (IsBitSet(iStatusScontoReceipt, BIT_SCONTO_GRATIS))
                        {
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 1] = k;
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 2] = "*** TOTALE ***";
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 3] = iTotaleReceipt / 100.0f;
                            iRow++;

                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 1] = k;
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 2] = "*** DOVUTO ***";
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 6] = 0;
                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 7] = DB_Data.sScontoText;
                            iRow++;

                            iTotaleReceiptDovuto = 0;
                            iScontoGratisReceipt = iTotaleReceipt;
                        }
                        else
                        {
                            iTotaleReceiptDovuto = iTotaleReceipt;

                            ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 1] = k;

                            if (DB_Data.bAnnullato)
                            {
                                ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 2] = "*** ANNULLATO ***";
                                ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 3] = iTotaleReceipt / 100.0f;
                            }
                            else
                            {
                                // causa presenza buoni è sempre possibile !
                                if ((iTotaleReceipt < 0) && bBuoniApplicati)
                                {
                                    // iBuoniApplicatiReceipt dimuisce dato che dataIdParam.iTotaleReceipt < 0
                                    iBuoniApplicatiParz += iTotaleReceipt;
                                    iBuoniApplicatiReceipt += iTotaleReceipt;

                                    bBuoniApplicatiParz = true;
                                    iTotaleReceipt = 0;
                                }

                                ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 2] = "*** TOTALE ***";
                                ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 6] = iTotaleReceipt / 100.0f;

                                if (bBuoniApplicatiParz)
                                    ordiniWS[iWS_Index].Cells[iRow, XLS_H_OFFSET + 7] = "*** applicato valore ridotto ***";
                            }

                            iRow++;
                        }
                    }

                    // ************************ FORMATTAZIONE ************************
                    // eseguito solo una volta, imposta larghezza B, C
                    String sFormat = String.Format("B1:B{0}", iRow + 100);
                    xlsRange = ordiniWS[iWS_Index].get_Range(sFormat, Type.Missing);
                    xlsRange.EntireColumn.ColumnWidth = 30;

                    sFormat = String.Format("C1:C{0}", iRow + 100);
                    xlsRange = ordiniWS[iWS_Index].get_Range(sFormat, Type.Missing);
                    xlsRange.EntireColumn.ColumnWidth = 20;
                    xlsRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

                    sFormat = String.Format("D1:D{0}", iRow + 100);
                    xlsRange = ordiniWS[iWS_Index].get_Range(sFormat, Type.Missing);
                    xlsRange.EntireColumn.ColumnWidth = 25;
                    xlsRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

                    sFormat = String.Format("E1:E{0}", iRow + 100);
                    xlsRange = ordiniWS[iWS_Index].get_Range(sFormat, Type.Missing);
                    xlsRange.EntireColumn.ColumnWidth = 14;
                    xlsRange.NumberFormat = NUMERIC_CELL_FORMAT;

                    sFormat = String.Format("F1:F{0}", iRow + 100);
                    xlsRange = ordiniWS[iWS_Index].get_Range(sFormat, Type.Missing);
                    xlsRange.EntireColumn.ColumnWidth = 14;

                    sFormat = String.Format("G1:G{0}", iRow + 100);
                    xlsRange = ordiniWS[iWS_Index].get_Range(sFormat, Type.Missing);
                    xlsRange.EntireColumn.ColumnWidth = 12;
                    xlsRange.NumberFormat = NUMERIC_CELL_FORMAT;

                    sFormat = String.Format("H1:H{0}", iRow + 100);
                    xlsRange = ordiniWS[iWS_Index].get_Range(sFormat, Type.Missing);
                    xlsRange.EntireColumn.ColumnWidth = 16;
                    xlsRange.NumberFormat = NUMERIC_CELL_FORMAT;

                    sFormat = String.Format("I1:I{0}", iRow + 100);
                    xlsRange = ordiniWS[iWS_Index].get_Range(sFormat, Type.Missing);
                    xlsRange.EntireColumn.ColumnWidth = 32;
                    xlsRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

                    // aggiornamento indici
                    columnDay = columnDay.AddDays(+1);
                } // end while (columnDay <= _SelRange.End)

                Logger.Info("VisDatiDlg : EsportaOrdini");

                xlsWorkBook.SaveAs(sDataDir + sNomeFile);
                xlsWorkBook.Close(true, missValue, missValue);
                xlApp.Quit();


                if (VD_CheckBoxExport.Checked)
                    System.Diagnostics.Process.Start(sDataDir + sNomeFile);

                //Marshal.ReleaseComObject(xlsWorkSheet);
                Marshal.ReleaseComObject(xlsWorkBook);
                Marshal.ReleaseComObject(xlApp);

                BtnExport.Enabled = true;
            }
            catch (Exception)
            {
                BtnExport.Enabled = true;
                _WrnMsg.iErrID = WRN_EXN;
                WarningManager(_WrnMsg);
            }
        }
    }
}
