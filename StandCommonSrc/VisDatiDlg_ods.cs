/********************************************************************
    NomeFile : StandCommonSrc/VisDatiDlg_ods.cs
    Data	 : 22.07.2026
    Autore : Mauro Artuso

    https://www.nuget.org/packages/FreeDataExports
    https://www.nuget.org/packages/FreeDataExports/1.1.14#excel-export-xlsx-2019

    Classe di visualizzazione dei files Dati o Prezzi
 ********************************************************************/
using FreeDataExports;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static StandCommonFiles.ComDef;
using static StandCommonFiles.CommonCl;
using static StandFacile.dBaseIntf;
using static StandFacile.glb;

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
        private void Free_DataExport(bool bIsXlsParam)
        {
            bool bMatch;
            int i, j, iRow, iLastItemRow, iColumn, iUpperLimit, iCAP_lastRow;
            int iDebugPrezzo, iDebugQty;
            String sNomeFile, sDataDir, sTmp, sDisp;
            String sDebugTipo;
            DateTime columnDay;

            BtnExport.Enabled = false;
            IDataWorkbook ods_WorkBook = new DataExport().CreateODSv1_3();
            IDataWorkbook xls_WorkBook = new DataExport().CreateXLSX2019();
            xls_WorkBook.Format(DataType.Currency, @"""""#,##0.00");

            IDataWorksheet odsWorkSheet, xlsWorkSheet;

            String[,] sDataArray = new string[500, 100];

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

            Logger.Info("FrmVisDati : ods");

            try
            {
#if STANDFACILE
                sDataDir = DataManager.GetDataDir() + "\\";
#else
                sDataDir = sRootDir + "\\";
#endif
                xls_WorkBook.CreatedBy = "StandFacile.org";
                ods_WorkBook.CreatedBy = "StandFacile.org";

                if (VD_CheckBoxCashUnion.Checked)
                {
                    sNomeFile = "Dati_";
                    xlsWorkSheet = xls_WorkBook.AddWorksheet("Dati_");
                    odsWorkSheet = ods_WorkBook.AddWorksheet("Dati_");
                }
                else
                {
                    sNomeFile = String.Format("Dati_FreeExp_C{0}_", _iNumCassa);
                    xlsWorkSheet = xls_WorkBook.AddWorksheet(String.Format("Dati_C{0}", _iNumCassa));
                    odsWorkSheet = ods_WorkBook.AddWorksheet(String.Format("Dati_C{0}", _iNumCassa));
                }

                if (_SelRange == null)
                    _SelRange = new SelectionRange(GetActualDate(), GetActualDate());

                // se _sNomeTabella == "" selezionato un range di date, altrimenti si arriva da EsploraDB_Dlg
                if (String.IsNullOrEmpty(_sNomeTabella))
                {
                    if (_SelRange.Start == _SelRange.End)
                    {
                        _SelRange = new SelectionRange(_SelDate, _SelDate);

                        if (bIsXlsParam)
                            sNomeFile += _SelDate.ToString("yyMMdd'.xlsx'");
                        else
                            sNomeFile += _SelDate.ToString("yyMMdd'.ods'");
                    }
                    else
                    {
                        if (bIsXlsParam)
                            sNomeFile += (_SelRange.Start.ToString("yyMMdd") + _SelRange.End.ToString("_yyMMdd'.xlsx'"));
                        else
                            sNomeFile += (_SelRange.Start.ToString("yyMMdd") + _SelRange.End.ToString("_yyMMdd'.ods'"));
                    }
                }
                else
                {
                    if (bIsXlsParam)
                        sNomeFile = _sNomeTabella + ".xlsx";
                    else
                        sNomeFile = _sNomeTabella + ".ods";
                }

                if (File.Exists(sDataDir + sNomeFile))
                    File.Delete(sDataDir + sNomeFile);

                _iLastArticoloIndexP1 = MAX_ITEMS_NUM; // successivamente potrebbe incrementare

                iLastItemRow = 0;
                iCAP_lastRow = 0;
                j = 0;

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
                            sDataArray[iRow++, iColumn + 1] = sTmp;

                            sDataArray[iRow++, iColumn + 1] = Text.Trim(); // Caption

                            iRow++;

                            sDataArray[iRow++, iColumn + 1] = DB_Data.sHeaders[0];
                            sDataArray[iRow++, iColumn + 1] = DB_Data.sHeaders[1];

                            sDataArray[iRow++, iColumn + 1] = "Num. Scontrini emessi";

                            sDataArray[iRow++, iColumn + 1] = "Num. Scontrini Web";

                            //if (DB_Data.iNumAnnullati > 0)
                            sDataArray[iRow++, iColumn + 1] = "Num. Scontr. annullati e valore";
                            //else
                            //    sDataArray[iRow++, iColumn + 1] = "Num. Scontr. annullati";

                            // recupera l'ora dalla CASSA_PRINCIPALE
                            sDataArray[iRow++, iColumn + 1] = DB_Data.sDateTime;
                            sDataArray[iRow, iColumn + 1] = "articolo";
                            sDataArray[iRow + 1, iColumn + 2] = "prz. unitario";

                        } // end if
                        else
                            iRow = XLS_VOFFSET - 2; // rimpicciolisce se si aggiungono righe di informazioni

                        sDataArray[iRow - 4, iColumn + 3] = DB_Data.iActualNumOfReceipts.ToString();

                        sDataArray[iRow - 3, iColumn + 3] = DB_Data.iNumOfWebReceipts.ToString();

                        if (DB_Data.iNumAnnullati > 0)
                        {
                            sDataArray[iRow - 2, iColumn + 3] = DB_Data.iNumAnnullati.ToString();
                            sDataArray[iRow - 2, iColumn + 4] = IntToEuro(DB_Data.iTotaleAnnullato);
                        }
                        else
                        {
                            sDataArray[iRow - 2, iColumn + 3] = DB_Data.iNumAnnullati.ToString();
                        }

                        sDataArray[iRow - 1, iColumn + 3] = DB_Data.sDateTime.Trim().Substring(4, 8);

                        sDataArray[iRow, iColumn + 3] = "quant. venduta";

                        if (_SelRange.Start == _SelRange.End)
                            sDataArray[iRow, iColumn + 5] = "dispon.";

                        iRow++;

                        sDataArray[iRow, iColumn + 4] = "parziale";

                        if (!VD_CheckBoxRedColumns.Checked && (_SelRange.Start == _SelRange.End))
                            sDataArray[iRow, iColumn + 6] = "quant.esportazione";

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
                                        sDataArray[XLS_VOFFSET + j, 1] = _ArticoliPrimaColonna[j].sTipo + " (*)";
                                    else
                                        sDataArray[XLS_VOFFSET + j, 1] = _ArticoliPrimaColonna[j].sTipo;

                                    sDataArray[XLS_VOFFSET + j, 2] = IntToEuro(_ArticoliPrimaColonna[j].iPrezzoUnitario);
                                }

                                sDataArray[XLS_VOFFSET + j, iColumn + 3] = DB_Data.Articolo[i].iQuantitaVenduta.ToString();

                                if (DB_Data.Articolo[i].iGruppoStampa == (int)DEST_TYPE.DEST_COUNTER)
                                {
                                    if (DB_Data.Articolo[i].sTipo == _COPERTO)
                                        sDataArray[XLS_VOFFSET + j, iColumn + 4] = IntToEuro(DB_Data.Articolo[i].iPrezzoUnitario * DB_Data.Articolo[i].iQuantitaVenduta);
                                    else
                                        sDataArray[XLS_VOFFSET + j, iColumn + 4] = "0,00";
                                }
                                else
                                {
                                    if (DB_Data.Articolo[i].iGruppoStampa == (int)DEST_TYPE.DEST_BUONI)
                                        sDataArray[XLS_VOFFSET + j, iColumn + 4] = IntToEuro(-DB_Data.Articolo[i].iPrezzoUnitario * DB_Data.Articolo[i].iQuantitaVenduta);
                                    else
                                        sDataArray[XLS_VOFFSET + j, iColumn + 4] = IntToEuro(DB_Data.Articolo[i].iPrezzoUnitario * DB_Data.Articolo[i].iQuantitaVenduta);
                                }

                                if (_SelRange.Start == _SelRange.End)
                                    sDataArray[XLS_VOFFSET + j, iColumn + 5] = sDisp;

                                if (!VD_CheckBoxRedColumns.Checked && (_SelRange.Start == _SelRange.End))
                                    sDataArray[XLS_VOFFSET + j, iColumn + 6] = DB_Data.Articolo[i].iQtaEsportata.ToString();
                            }
                        }

                        // verifica lo storico e prosegue con iRow
                        if (iLastItemRow < (XLS_VOFFSET + _iLastArticoloIndexP1))
                            iLastItemRow = XLS_VOFFSET + _iLastArticoloIndexP1;

                        iRow = iLastItemRow;

                        // questa parte va scritta solo al secondo passaggio
                        if (iRepeatForLayout == 1)
                        {
                            sDataArray[iRow++, iColumn + 4] = "---------";

                            sDataArray[iRow, 3] = "TOTALE";
                            sDataArray[iRow++, iColumn + 4] = IntToEuro(DB_Data.iTotaleIncasso - DB_Data.iTotaleBuoniApplicati);

                            //if (DB_Data.iTotaleBuoniApplicati > 0)
                            {
                                iRow++;

                                sDataArray[iRow, 3] = "valore effettivo buoni applicati (*)";
                                sDataArray[iRow++, iColumn + 4] = IntToEuro(DB_Data.iTotaleBuoniApplicati);
                            }

                            //if ((DB_Data.iTotaleScontatoStd > 0) || (DB_Data.iTotaleScontatoFisso > 0) || (DB_Data.iTotaleScontatoGratis > 0))
                            {
                                iRow++;

                                sDataArray[iRow, 3] = "valore gratuiti";
                                sDataArray[iRow++, iColumn + 4] = IntToEuro(DB_Data.iTotaleScontatoGratis);

                                sDataArray[iRow, 3] = "valore sconto fisso";
                                sDataArray[iRow++, iColumn + 4] = IntToEuro(DB_Data.iTotaleScontatoFisso);

                                sDataArray[iRow, 3] = "valore sconto articoli";
                                sDataArray[iRow++, iColumn + 4] = IntToEuro(DB_Data.iTotaleScontatoStd);

                                sDataArray[iRow++, iColumn + 4] = "---------";
                                sDataArray[iRow, 3] = "TOTALE NETTO";
                                sDataArray[iRow++, iColumn + 4] = IntToEuro(DB_Data.iTotaleIncasso - DB_Data.iTotaleBuoniApplicati - DB_Data.iTotaleScontatoStd -
                                                                            DB_Data.iTotaleScontatoFisso - DB_Data.iTotaleScontatoGratis);
                            }

                            //if ((DB_Data.iTotaleCard > 0) || (DB_Data.iTotaleSatispay > 0))
                            {
                                iRow++;

                                sDataArray[iRow, 3] = "PAGAM. CARD";
                                sDataArray[iRow++, iColumn + 4] = IntToEuro(DB_Data.iTotaleCard);

                                sDataArray[iRow, 3] = "PAGAM. SATISPAY";
                                sDataArray[iRow++, iColumn + 4] = IntToEuro(DB_Data.iTotaleSatispay);

                                sDataArray[iRow, 3] = "PAGAM. CONT.";
                                sDataArray[iRow++, iColumn + 4] = IntToEuro(DB_Data.iTotaleIncasso - DB_Data.iTotaleBuoniApplicati - DB_Data.iTotaleScontatoStd - DB_Data.iTotaleScontatoFisso -
                                                                            DB_Data.iTotaleScontatoGratis - DB_Data.iTotaleCard - DB_Data.iTotaleSatispay);
                            }

                            //sere per sicurezza scrittura sDataArray
                            if (iCAP_lastRow < iRow)
                                iCAP_lastRow = iRow;

                            // ************************ CAP ************************
#if STANDFACILE
                            if (OptionsDlg.Get_CAP_ShowFlag())
                            {
                                iRow++;

                                if (iColumn == 0)
                                {
                                    _iCAP_vertPosStart = iRow; // serve alla formattazione

                                    sDataArray[iRow, 1] = "CAP_ID";
                                    sDataArray[iRow, 3] = "CAP";

                                    if (_SelRange.Start != _SelRange.End)
                                        sDataArray[iRow, 2] = "CAP_TOTALE";
                                }
                                else
                                    sDataArray[iRow, iColumn + 3] = "CAP";

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
                                            sDataArray[iRow + iListIndex, 2] = _lista_CAP_PrimaColonna[iListIndex].iCAP_count.ToString();

                                        sDataArray[iRow + iListIndex, iColumn + 3] = cap.iCAP_count.ToString();
                                    }
                                    else
                                    {
                                        _lista_CAP_PrimaColonna.Add(new TCAP
                                        {
                                            sCAP_ID = cap.sCAP_ID,
                                            iCAP_count = cap.iCAP_count
                                        });

                                        sDataArray[iCAP_lastRow, 1] = cap.sCAP_ID;

                                        if (_SelRange.Start != _SelRange.End)
                                            sDataArray[iCAP_lastRow, 2] = cap.iCAP_count.ToString();

                                        sDataArray[iCAP_lastRow, iColumn + 3] = cap.iCAP_count.ToString();

                                        iCAP_lastRow++;
                                        _iCAP_vertPosStop = iCAP_lastRow; // serve alla formattazione
                                    }
                                }
                            }
#endif

                        }

                        // aggiornamento indici
                        columnDay = columnDay.AddDays(+1);
                        iColumn += 2;

                    } // end while (columnDay <= _SelRange.End)
                } // for ... iRepeatForLayout


                // predisposizione tabella esportazione e formattazione

                const int iPRE_COL_TEXT = 12; // posizione di inizio dati fascia centrale

                String sCellContent = "";

                // Array per formattazione larghezza delle colonne ma solo per xls
                String[] sXlsColumnWidth = new String[100];

                for (i = 0; i < 100; i += 2)
                {
                    sXlsColumnWidth[i] = "10";
                    sXlsColumnWidth[i + 1] = "20";
                }

                sXlsColumnWidth[1] = "36"; // Articoli
                sXlsColumnWidth[2] = "14"; // prz. unitario

                // Array per formattazione larghezza delle colonne ma solo per ODS
                String[] sOdsColumnWidth = new String[100];

                for (i = 0; i < 100; i += 2)
                {
                    sOdsColumnWidth[i] = "16mm";
                    sOdsColumnWidth[i + 1] = "26mm";
                }

                sOdsColumnWidth[1] = "60mm"; // Articoli
                sOdsColumnWidth[2] = "24mm"; // prz. unitario
                sOdsColumnWidth[3] = "55mm"; // quant. venduta

                try
                {
                    for (i = 0; i < iCAP_lastRow; i++)
                    {
                        for (j = 0; j < 100; j++)
                        {
                            sCellContent = sDataArray[i, j];

                            // dati prima di iPRE_COL_TEXT
                            if ((i < iPRE_COL_TEXT - 2) && (j > 2))
                            {
                                xlsWorkSheet.AddCell(sCellContent, DataType.Number);
                                odsWorkSheet.AddCell(sCellContent, DataType.Number);
                            }

                            // dati fascia centrale esportazione
                            else if ((i > iPRE_COL_TEXT) && (i <= _iLastArticoloIndexP1 + iPRE_COL_TEXT))
                            {
                                if ((j == 0) || (j == 1) || ((j == 5) && sCellContent == "OK"))
                                {
                                    xlsWorkSheet.AddCell(sCellContent + "", DataType.String);
                                    odsWorkSheet.AddCell(sCellContent + "", DataType.String);
                                }
                                else if ((j == 2) || (j == 4))
                                {
                                    xlsWorkSheet.AddCell(sCellContent, DataType.Currency);
                                    odsWorkSheet.AddCell(sCellContent, DataType.Number);
                                }
                                else
                                {
                                    xlsWorkSheet.AddCell(sCellContent, DataType.Number);
                                    odsWorkSheet.AddCell(sCellContent, DataType.Number);
                                }
                            }

                            // dati finali esportazione
                            else if ((i > _iLastArticoloIndexP1 + iPRE_COL_TEXT) && (j >= 4))
                            {
                                if ((sCellContent == null) || sCellContent.Contains("---"))
                                {
                                    xlsWorkSheet.AddCell(sCellContent + "", DataType.String);
                                    odsWorkSheet.AddCell(sCellContent + "", DataType.String);
                                }
                                else
                                {
                                    xlsWorkSheet.AddCell(sCellContent, DataType.Currency);
                                    odsWorkSheet.AddCell(sCellContent, DataType.Number);
                                }
                            }

                            // dati CAP
                            else if ((i > _iCAP_vertPosStart) && (i <= _iCAP_vertPosStop))
                            {
                                xlsWorkSheet.AddCell(sCellContent + "", DataType.Number);
                                odsWorkSheet.AddCell(sCellContent + "", DataType.Number);
                            }

                            else
                            {
                                xlsWorkSheet.AddCell(sCellContent + "", DataType.String);
                                odsWorkSheet.AddCell(sCellContent + "", DataType.String);
                            }
                        }

                        xlsWorkSheet.ColumnWidths(sXlsColumnWidth);
                        xlsWorkSheet.AddRow();

                        odsWorkSheet.ColumnWidths(sOdsColumnWidth);
                        odsWorkSheet.AddRow();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("i,j,sDataArray[i, j]: {0}, {1}, {2}", i, j, sDataArray[i, j]);
                }

                sTmp = ods_WorkBook.GetErrors();

                Logger.Info("VisDatiDlg : EsportaDati");

                if (bIsXlsParam)
                    xls_WorkBook.Save(sDataDir + sNomeFile);
                else
                    ods_WorkBook.Save(sDataDir + sNomeFile);

                if (VD_CheckBoxExport.Checked)
                    System.Diagnostics.Process.Start(sDataDir + sNomeFile);

                BtnExport.Enabled = true;
            }
            catch (Exception)
            {
                BtnExport.Enabled = true;
                _WrnMsg.iErrID = WRN_EXN;
                WarningManager(_WrnMsg);
            }
        }


        /// <summary>Esportazione degli ordini</summary>
        private void Free_OrdersExport(bool bIsXlsParam)
        {
            bool bOrdineCaricato, bOnce, bBuoniApplicati, bBuoniApplicatiParz;
            int i, j, k, iUpperLimit;
            int iWS_Index, iDebugNumOfItems;

            // non si riferiscono a nessun ordine in particolare
            int iTotaleParz, iTotaleReceipt, iBuoniApplicatiReceipt, iBuoniApplicatiParz, iTotaleReceiptDovuto;
            int iStatusScontoReceipt, iScontoStdReceipt, iScontoFissoReceipt, iScontoGratisReceipt;

            String sNomeFile, sDataDir, sTmp;
            String sDateTime, sDebugTipo;
            DateTime columnDay;

            BtnExport.Enabled = false;

            bool[] bScontoGruppo = new bool[NUM_SEP_PRINT_GROUPS];

            IDataWorkbook xls_WorkBook = new DataExport().CreateXLSX2019();
            IDataWorkbook ods_WorkBook = new DataExport().CreateODSv1_3();

            xls_WorkBook.Format(DataType.Currency, @"""""#,##0.00");
            //ods_WorkBook.Format(DataType.Currency, @"""""#,##0.00");

            var ordini_xls = new List<IDataWorksheet>();
            var ordini_ods = new List<IDataWorksheet>();

            Logger.Info("FrmVisDati : dopo List<IDataWorksheet>()");

            try
            {
#if STANDFACILE
                sDataDir = DataManager.GetDataDir() + "\\";
#else
                sDataDir = sRootDir + "\\";
#endif

                xls_WorkBook.CreatedBy = "StandFacile.org";
                ods_WorkBook.CreatedBy = "StandFacile.org";

                if (VD_CheckBoxCashUnion.Checked)
                    sNomeFile = "Ordini_FreeXls_";
                else
                    sNomeFile = String.Format("Ordini_C{0}_FreeXls_", _iNumCassa);

                if (_SelRange == null)
                    _SelRange = new SelectionRange(GetActualDate(), GetActualDate());

                // se _sNomeTabella == "" selezionato un range di date, altrimenti si arriva da EsploraDB_Dlg
                if (String.IsNullOrEmpty(_sNomeTabella))
                {
                    if (_SelRange.Start == _SelRange.End)
                    {
                        _SelRange = new SelectionRange(_SelDate, _SelDate);

                        if (bIsXlsParam)
                            sNomeFile += _SelDate.ToString("yyMMdd'.xlsx'");
                        else
                            sNomeFile += _SelDate.ToString("yyMMdd'.ods'");
                    }
                    else
                    {
                        if (bIsXlsParam)
                            sNomeFile += (_SelRange.Start.ToString("yyMMdd") + _SelRange.End.ToString("_yyMMdd'.xlsx'"));
                        else
                            sNomeFile += (_SelRange.Start.ToString("yyMMdd") + _SelRange.End.ToString("_yyMMdd'.ods'"));
                    }
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

                    if (VD_CheckBoxCashUnion.Checked)
                    {
                        ordini_xls.Add(xls_WorkBook.AddWorksheet(String.Format("Ordini_{0}", columnDay.ToString("yyMMdd"))));
                        ordini_ods.Add(ods_WorkBook.AddWorksheet(String.Format("Ordini_{0}", columnDay.ToString("yyMMdd"))));
                    }
                    else
                    {
                        ordini_xls.Add(xls_WorkBook.AddWorksheet(String.Format("Ordini_{0}_C{1}", columnDay.ToString("yyMMdd"), _iNumCassa)));
                        ordini_ods.Add(ods_WorkBook.AddWorksheet(String.Format("Ordini_{0}_C{1}", columnDay.ToString("yyMMdd"), _iNumCassa)));
                    }

                    // Headers
                    j = 0;

                    // calcolo ultimo indice anche in date passate, no DataManager.CheckLastArticoloIndexP1()
                    iUpperLimit = CheckLastArticoloIndexP1();

                    sTmp = String.Format("{0}", DB_Data.sVersione);

                    ordini_xls[iWS_Index].AddRow()
                            .AddCell("", DataType.String)
                            .AddCell("", DataType.String);

                    ordini_xls[iWS_Index].AddRow()
                            .AddCell("", DataType.String)
                            .AddCell(sTmp, DataType.String);

                    ordini_xls[iWS_Index].AddRow()
                            .AddCell("", DataType.String)
                            .AddCell(Text.Trim(), DataType.String);

                    ordini_xls[iWS_Index].AddRow()
                            .AddCell("", DataType.String)
                            .AddCell(DB_Data.sHeaders[0], DataType.String);

                    ordini_xls[iWS_Index].AddRow()
                            .AddCell("", DataType.String)
                            .AddCell(DB_Data.sHeaders[1], DataType.String);

                    ordini_xls[iWS_Index].AddRow()
                            .AddCell("", DataType.String)
                            .AddCell("", DataType.String);

                    ordini_xls[iWS_Index].AddRow()
                            .AddCell("", DataType.String)
                            .AddCell("", DataType.String)
                            .AddCell("numero Scontrino", DataType.String)
                            .AddCell("articolo", DataType.String)
                            .AddCell("prezzo unitario", DataType.String)
                            .AddCell("quantità venduta", DataType.String)
                            .AddCell("parziale", DataType.String)
                            .AddCell("Totale Scontrino", DataType.String)
                            .AddCell("note", DataType.String);


                    ordini_ods[iWS_Index].AddRow()
                            .AddCell("", DataType.String)
                            .AddCell("", DataType.String);

                    ordini_ods[iWS_Index].AddRow()
                            .AddCell("", DataType.String)
                            .AddCell(sTmp, DataType.String);

                    ordini_ods[iWS_Index].AddRow()
                            .AddCell("", DataType.String)
                            .AddCell(Text.Trim(), DataType.String);

                    ordini_ods[iWS_Index].AddRow()
                            .AddCell("", DataType.String)
                            .AddCell(DB_Data.sHeaders[0], DataType.String);

                    ordini_ods[iWS_Index].AddRow()
                            .AddCell("", DataType.String)
                            .AddCell(DB_Data.sHeaders[1], DataType.String);

                    ordini_ods[iWS_Index].AddRow()
                            .AddCell("", DataType.String)
                            .AddCell("", DataType.String);

                    ordini_ods[iWS_Index].AddRow()
                            .AddCell("", DataType.String)
                            .AddCell("", DataType.String)
                            .AddCell("numero Scontrino", DataType.String)
                            .AddCell("articolo", DataType.String)
                            .AddCell("prezzo unitario", DataType.String)
                            .AddCell("quantità venduta", DataType.String)
                            .AddCell("parziale", DataType.String)
                            .AddCell("Totale Scontrino", DataType.String)
                            .AddCell("note", DataType.String);

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
                            sDateTime = "";

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

                                sDateTime = DB_Data.sDateTime;
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

                                if (bIsXlsParam)
                                {
                                    ordini_xls[iWS_Index].AddRow()
                                     .AddCell("", DataType.String)
                                     .AddCell(sDateTime, DataType.String)
                                     .AddCell(k, DataType.Number)
                                     .AddCell(DB_Data.Articolo[j].sTipo, DataType.String)
                                     .AddCell(DB_Data.Articolo[j].iPrezzoUnitario / 100.0f, DataType.Currency)
                                     .AddCell(DB_Data.Articolo[j].iQuantitaOrdine, DataType.Number)
                                     .AddCell(iTotaleParz / 100.0f, DataType.Currency)
                                     .AddCell("", DataType.Currency)
                                     .AddCell(DB_Data.Articolo[j].sNotaArt, DataType.String);
                                }
                                else
                                {
                                    ordini_ods[iWS_Index].AddRow()
                                         .AddCell("", DataType.String)
                                         .AddCell(sDateTime, DataType.String)
                                         .AddCell(k, DataType.Number)
                                         .AddCell(DB_Data.Articolo[j].sTipo, DataType.String)
                                         .AddCell(DB_Data.Articolo[j].iPrezzoUnitario / 100.0f, DataType.Number)
                                         .AddCell(DB_Data.Articolo[j].iQuantitaOrdine, DataType.Number)
                                         .AddCell(iTotaleParz / 100.0f, DataType.Number)
                                         .AddCell("", DataType.Number)
                                         .AddCell(DB_Data.Articolo[j].sNotaArt, DataType.String);
                                }
                            }
                        } // end for


                        if (!String.IsNullOrEmpty(DB_Data.sNota))
                        {
                            ordini_xls[iWS_Index].AddRow()
                             .AddCell("", DataType.String)
                             .AddCell("", DataType.String)
                             .AddCell(k, DataType.Number)
                             .AddCell("*** NOTA ***", DataType.String)
                             .AddCell("", DataType.String)
                             .AddCell("", DataType.String)
                             .AddCell("", DataType.String)
                             .AddCell("", DataType.String)
                             .AddCell(DB_Data.sNota, DataType.String);

                            ordini_ods[iWS_Index].AddRow()
                             .AddCell("", DataType.String)
                             .AddCell("", DataType.String)
                             .AddCell(k, DataType.Number)
                             .AddCell("*** NOTA ***", DataType.String)
                             .AddCell("", DataType.String)
                             .AddCell("", DataType.String)
                             .AddCell("", DataType.String)
                             .AddCell("", DataType.String)
                             .AddCell(DB_Data.sNota, DataType.String);
                        }

                        if (IsBitSet(iStatusScontoReceipt, BIT_SCONTO_STD) && StandCommonFiles.ReceiptAndCopies.TicketScontatoStdIsGood(DB_Data, bScontoGruppo))
                        {
                            iTotaleReceiptDovuto = iTotaleReceipt - iScontoStdReceipt;

                            if (iTotaleReceiptDovuto < 0)
                            {
                                iTotaleReceiptDovuto = 0;
                                iScontoStdReceipt = iTotaleReceipt;
                            }

                            ordini_xls[iWS_Index].AddRow()
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell(k, DataType.Number)
                                 .AddCell("*** SCONTO ***", DataType.String)
                                 .AddCell(iScontoStdReceipt / 100.0f, DataType.Currency)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.Number)
                                 .AddCell("", DataType.String);

                            ordini_xls[iWS_Index].AddRow()
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell(k, DataType.Number)
                                 .AddCell("*** TOTALE ***", DataType.String)
                                 .AddCell(iTotaleReceipt / 100.0f, DataType.Currency)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.Number)
                                 .AddCell("", DataType.String);

                            ordini_xls[iWS_Index].AddRow()
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell(k, DataType.Number)
                                 .AddCell("*** DIFF. DOVUTA ***", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell(iTotaleReceiptDovuto / 100.0f, DataType.Currency)
                                 .AddCell(DB_Data.sScontoText, DataType.String);


                            ordini_ods[iWS_Index].AddRow()
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell(k, DataType.Number)
                                 .AddCell("*** SCONTO ***", DataType.String)
                                 .AddCell(iScontoStdReceipt / 100.0f, DataType.Number)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.Number)
                                 .AddCell("", DataType.String);

                            ordini_ods[iWS_Index].AddRow()
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell(k, DataType.Number)
                                 .AddCell("*** TOTALE ***", DataType.String)
                                 .AddCell(iTotaleReceipt / 100.0f, DataType.Number)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.Number)
                                 .AddCell("", DataType.String);

                            ordini_ods[iWS_Index].AddRow()
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell(k, DataType.Number)
                                 .AddCell("*** DIFF. DOVUTA ***", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell(iTotaleReceiptDovuto / 100.0f, DataType.Number)
                                 .AddCell(DB_Data.sScontoText, DataType.String);
                        }
                        else if (IsBitSet(iStatusScontoReceipt, BIT_SCONTO_FISSO))
                        {
                            iTotaleReceiptDovuto = iTotaleReceipt - iScontoFissoReceipt;

                            if (iTotaleReceiptDovuto < 0)
                            {
                                iTotaleReceiptDovuto = 0;
                                iScontoFissoReceipt = iTotaleReceipt;
                            }

                            ordini_xls[iWS_Index].AddRow()
                                  .AddCell("", DataType.String)
                                  .AddCell("", DataType.String)
                                  .AddCell(k, DataType.Number)
                                  .AddCell("*** SCONTO ***", DataType.String)
                                  .AddCell(iScontoFissoReceipt / 100.0f, DataType.Currency)
                                  .AddCell("", DataType.String)
                                  .AddCell("", DataType.String)
                                  .AddCell("", DataType.Number)
                                  .AddCell("", DataType.String);

                            ordini_xls[iWS_Index].AddRow()
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell(k, DataType.Number)
                                 .AddCell("*** TOTALE ***", DataType.String)
                                 .AddCell(iTotaleReceipt / 100.0f, DataType.Currency)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.Number)
                                 .AddCell("", DataType.String);

                            ordini_xls[iWS_Index].AddRow()
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell(k, DataType.Number)
                                 .AddCell("*** DIFF. DOVUTA ***", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell(iTotaleReceiptDovuto / 100.0f, DataType.Currency)
                                 .AddCell(DB_Data.sScontoText, DataType.String);


                            ordini_ods[iWS_Index].AddRow()
                                  .AddCell("", DataType.String)
                                  .AddCell("", DataType.String)
                                  .AddCell(k, DataType.Number)
                                  .AddCell("*** SCONTO ***", DataType.String)
                                  .AddCell(iScontoFissoReceipt / 100.0f, DataType.Number)
                                  .AddCell("", DataType.String)
                                  .AddCell("", DataType.String)
                                  .AddCell("", DataType.Number)
                                  .AddCell("", DataType.String);

                            ordini_ods[iWS_Index].AddRow()
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell(k, DataType.Number)
                                 .AddCell("*** TOTALE ***", DataType.String)
                                 .AddCell(iTotaleReceipt / 100.0f, DataType.Number)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.Number)
                                 .AddCell("", DataType.String);

                            ordini_ods[iWS_Index].AddRow()
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell(k, DataType.Number)
                                 .AddCell("*** DIFF. DOVUTA ***", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell(iTotaleReceiptDovuto / 100.0f, DataType.Number)
                                 .AddCell(DB_Data.sScontoText, DataType.String);
                        }
                        else if (IsBitSet(iStatusScontoReceipt, BIT_SCONTO_GRATIS))
                        {
                            ordini_xls[iWS_Index].AddRow()
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell(k, DataType.Number)
                                 .AddCell("*** TOTALE ***", DataType.String)
                                 .AddCell(iTotaleReceipt / 100.0f, DataType.Currency)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.Number)
                                 .AddCell("", DataType.String);

                            ordini_xls[iWS_Index].AddRow()
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell(k, DataType.Number)
                                 .AddCell("*** DOVUTO ***", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell(0, DataType.Currency)
                                 .AddCell(DB_Data.sScontoText, DataType.String);

                            ordini_ods[iWS_Index].AddRow()
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell(k, DataType.Number)
                                 .AddCell("*** TOTALE ***", DataType.String)
                                 .AddCell(iTotaleReceipt / 100.0f, DataType.Number)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.Number)
                                 .AddCell("", DataType.String);

                            ordini_ods[iWS_Index].AddRow()
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell(k, DataType.Number)
                                 .AddCell("*** DOVUTO ***", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell("", DataType.String)
                                 .AddCell(0, DataType.Number)
                                 .AddCell(DB_Data.sScontoText, DataType.String);

                            iTotaleReceiptDovuto = 0;
                            iScontoGratisReceipt = iTotaleReceipt;
                        }
                        else
                        {
                            iTotaleReceiptDovuto = iTotaleReceipt;

                            if (DB_Data.bAnnullato)
                            {
                                ordini_xls[iWS_Index].AddRow()
                                  .AddCell("", DataType.String)
                                  .AddCell("", DataType.String)
                                  .AddCell(k, DataType.Number)
                                  .AddCell("*** ANNULLATO ***", DataType.String)
                                  .AddCell(iTotaleReceipt / 100.0f, DataType.Currency)
                                  .AddCell("", DataType.String)
                                  .AddCell("", DataType.String)
                                  .AddCell("", DataType.String)
                                  .AddCell("", DataType.String);

                                ordini_ods[iWS_Index].AddRow()
                                  .AddCell("", DataType.String)
                                  .AddCell("", DataType.String)
                                  .AddCell(k, DataType.Number)
                                  .AddCell("*** ANNULLATO ***", DataType.String)
                                  .AddCell(iTotaleReceipt / 100.0f, DataType.Number)
                                  .AddCell("", DataType.String)
                                  .AddCell("", DataType.String)
                                  .AddCell("", DataType.String)
                                  .AddCell("", DataType.String);
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

                                if (bIsXlsParam)
                                {
                                    ordini_xls[iWS_Index].AddRow()
                                       .AddCell("", DataType.String)
                                       .AddCell("", DataType.String)
                                       .AddCell(k, DataType.Number)
                                       .AddCell("*** TOTALE ***", DataType.String)
                                       .AddCell("", DataType.String)
                                       .AddCell("", DataType.String)
                                       .AddCell("", DataType.String)
                                       .AddCell(iTotaleReceipt / 100.0f, DataType.Currency)
                                       .AddCell(bBuoniApplicatiParz ? "*** applicato valore ridotto ***" : "", DataType.String);
                                }
                                else
                                {
                                    ordini_ods[iWS_Index].AddRow()
                                       .AddCell("", DataType.String)
                                       .AddCell("", DataType.String)
                                       .AddCell(k, DataType.Number)
                                       .AddCell("*** TOTALE ***", DataType.String)
                                       .AddCell("", DataType.String)
                                       .AddCell("", DataType.String)
                                       .AddCell("", DataType.String)
                                       .AddCell(iTotaleReceipt / 100.0f, DataType.Number)
                                       .AddCell(bBuoniApplicatiParz ? "*** applicato valore ridotto ***" : "", DataType.String);
                                }
                            }

                        }
                    }

                    // ************************ FORMATTAZIONE ************************
                    ordini_xls[iWS_Index].ColumnWidths("8", "30", "20", "25", "14", "14", "12", "16", "32");

                    // Array per formattazione larghezza delle colonne ma solo per ODS
                    String[] sOdsColumnWidth = new String[10];

                    sOdsColumnWidth[0] = "20mm";
                    sOdsColumnWidth[1] = "50mm";
                    sOdsColumnWidth[2] = "40mm";
                    sOdsColumnWidth[3] = "60mm";
                    sOdsColumnWidth[4] = "50mm";
                    sOdsColumnWidth[5] = "36mm";
                    sOdsColumnWidth[6] = "36mm";
                    sOdsColumnWidth[7] = "40mm";
                    sOdsColumnWidth[8] = "60mm";
                    sOdsColumnWidth[9] = "20mm";

                    ordini_ods[iWS_Index].ColumnWidths(sOdsColumnWidth);
                    ordini_ods[iWS_Index].AddRow();

                    // aggiornamento indici
                    columnDay = columnDay.AddDays(+1);
                } // end while (columnDay <= _SelRange.End)

                Logger.Info("VisDatiDlg : EsportaOrdini");

                if (bIsXlsParam)
                    xls_WorkBook.Save(sDataDir + sNomeFile);
                else
                    ods_WorkBook.Save(sDataDir + sNomeFile);


                if (VD_CheckBoxExport.Checked)
                    System.Diagnostics.Process.Start(sDataDir + sNomeFile);

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
