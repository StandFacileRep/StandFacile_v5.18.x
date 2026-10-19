/****************************************************************************
	NomeFile : StandCommonSrc/Printer_ESCPOS.cs
    Data	 : 18.10.2026
	Autore   : Mauro Artuso

	Descrizione :
	Questo file contiene la classe per la gestione della stampante ESCPOS
    
    https://github.com/lukevp/ESC-POS-.NET
    https://github.com/jesusvlo/RawPrint.NetStd

    STAMPANTE_ESCPOS : 180dpi, carta 72mm 512 dot

    STAMPANTE_ESCPOS : 203dpi, carta 72mm 576 dot
    STAMPANTE_ESCPOS : 203dpi, carta 52.6mm 420 dot
    
     Font A : 12x24, Font B : 9x17

     con carta 80mm, Font A x1 si ha 576:12=48 caratteri per riga
     con carta 80mm, Font B x1 si ha 576: 9=64 caratteri per riga
     con carta 80mm, Font B x2 si ha 576:18=32 caratteri per riga

     con carta 80mm, Font A x1 si ha 512:12=42 caratteri per riga
     con carta 80mm, Font B x1 si ha 512: 9=56 caratteri per riga
     con carta 80mm, Font B x2 si ha 512:18=28 caratteri per riga

     con carta 52.6mm, Font A x1 si ha 420:12=35 caratteri per riga
     con carta 52.6mm, Font B x1 si ha 420: 9=46 caratteri per riga
     con carta 52.6mm, Font B x2 si ha 420:18=23 caratteri per riga

 ****************************************************************************/

using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Drawing;
using System.Threading;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using static StandCommonFiles.CommonCl;
using static StandCommonFiles.ComDef;

using StandFacile;
using static StandFacile.glb;
using static StandFacile.Config;
using ESCPOS_NET.Emitters;
using RawPrint.NetStd;





#if STAND_CUCINA
using static StandFacile.Define; // serve a StandCucina
#else
using static StandFacile.dBaseIntf;
#endif

namespace StandCommonFiles
{
    class Printer_ESCPOS
    {
#pragma warning disable IDE0044
#pragma warning disable IDE0059
#pragma warning disable IDE1006

        const int BARCODE_HEIGHT = 100;
        //const String WIDE_CONST_STRING = "*********_*********_********";

        static int iTM_T88_LMARGIN_SCNT_FSTD = 6;
        const int TM_T88_LMARGIN_SCNT_FRID = 0;
        const int TM_T88_LMARGIN_DATA_RID = 2;
        const int TM_T88_LMARGIN_DATA = 2;

        static bool _bIsDati, _bIsTicket;
        static bool _bLogoCheck_T, _bLogoCheck_B;
        static bool _bTicketNumFound;
        static bool _bSkipNumeroScontrino = false;

        static bool _bCassaInline;
        static int _iInitialRowsToAdd, _finalRowsToAdd;
        static int _iLMargin = 0;

        public static int _printerWidth { get; private set; } = 576; // 203dpi, carta 72mm

#if STANDFACILE
        /// <summary>imposta l'intervallo tra le stampe</summary>
        static int iPrint_WaitInterval = 200;
#endif

        static int _iGruppoStampa;

        static Char[] _cGruppoStampa = { '9', '9' };
        static String _sDataStr = "";
        static String _sOrdineNum = "";

        static TErrMsg _WrnMsg;

        static Image _imgTmp_T, _imgTmp_B, _img_T, _img_B;
        static float _fHZoomedWidth_T, _fVZoomedHeight_T, _fHZoomedWidth_B, _fVZoomedHeight_B;

        static StreamReader _fileToPrint;

        static TWinPrinterParams _sWinPrinterParams;
        static String _sFileToPrintParam;

        static string sMsgPrinter;

        static string _printerName;
        static List<byte> _bytes = new List<byte>();

        private static Printer _rawPrinter;

        //private static ImmediateNetworkPrinter _ETH_printer;

        private static EPSON _emitter;
        private static IPAddress _IP_Address = null;

        private static PrintStyle _iStyle = PrintStyle.None;

        /****************************************************
            STAMPA su stampante gestita da driver windows
         ****************************************************/
        public static byte[] PrintFile(String sFileToPrintParam, bool bIs_USB_ETH_Printer = true)
        {
            return PrintFile(sFileToPrintParam, sGlbWinPrinterParams, NUM_SEP_PRINT_GROUPS, "", bIs_USB_ETH_Printer); // OK
        }

        /// <summary>
        ///  STAMPA su stampante gestita da driver windows,<br/>
        ///  diversa per le 10 copie + scontrino principale + riepilogo + messaggi<br/>
        ///  iPrinterIndexPrm da 0 a NUM_SEP_PRINT_GROUPS - 1   identifica stampante copie,<br/>
        ///  iPrinterIndexPrm == NUM_SEP_PRINT_GROUPS      identifica stampante Receipt,<br/>
        ///  iPrinterIndexPrm == NUM_SEP_PRINT_GROUPS + 1  identifica stampante Riepilogo,<br/>
        ///  iPrinterIndexPrm == NUM_SEP_PRINT_GROUPS + 2  identifica stampante Messaggi,<br/>
        ///  iPrinterIndexPrm == NUM_SEP_PRINT_GROUPS + 3  identifica apertura cassetto
        /// </summary>
        public static byte[] PrintFile(String sFileToPrintParam, TWinPrinterParams sWinPrinterParam, int iPrinterIndexPrm, string sPrinterNameParam = "", bool bIs_USB_ETH_Printer = true)
        {
            int iPos;
            string sTmp, sFileName, sTmpPrinterName, sTmp_IP_addr = "";

            bool ipAddress_IsValid = false;

            _emitter = new EPSON();
            _rawPrinter = new Printer();

            _sWinPrinterParams = sWinPrinterParam;
            _sFileToPrintParam = sFileToPrintParam;

            if (String.IsNullOrEmpty(sPrinterNameParam))
            {
                if (iPrinterIndexPrm == NUM_SEP_PRINT_GROUPS + 2)  // stampa Messaggi
                    _printerName = _sWinPrinterParams.sMsgPrinterModel;
                else if (iPrinterIndexPrm == NUM_SEP_PRINT_GROUPS + 1) // stampa Riepilogo
                    _printerName = _sWinPrinterParams.sSumPrinterModel;
                else if (iPrinterIndexPrm == (NUM_SEP_PRINT_GROUPS)) // stampa Tickets
                    _printerName = _sWinPrinterParams.sRcpPrinterModel;
                else
                    _printerName = _sWinPrinterParams.sPrinterModel[iPrinterIndexPrm];
            }
            else
                _printerName = sPrinterNameParam; // serve alle prove di stampa

            sMsgPrinter = String.Format("{0}, index: {1}", _printerName, iPrinterIndexPrm);

            // estrazione IP Address dal nome stampante
            try
            {
                if (String.IsNullOrEmpty(sPrinterNameParam))
                {
                    if (iPrinterIndexPrm == NUM_SEP_PRINT_GROUPS + 2)  // stampa Messaggi
                        sTmpPrinterName = sWinPrinterParam.sMsgPrinterModel;
                    else if (iPrinterIndexPrm == NUM_SEP_PRINT_GROUPS + 1) // stampa Riepilogo
                        sTmpPrinterName = sWinPrinterParam.sSumPrinterModel;
                    else if (iPrinterIndexPrm == (NUM_SEP_PRINT_GROUPS)) // stampa Tickets
                        sTmpPrinterName = sWinPrinterParam.sRcpPrinterModel;
                    else
                        sTmpPrinterName = sWinPrinterParam.sPrinterModel[iPrinterIndexPrm];

                    sTmp_IP_addr = ExtractIPv4(sTmpPrinterName);
                    ipAddress_IsValid = IPAddress.TryParse(sTmp_IP_addr, out _IP_Address);
                }
                else
                {
                    sTmp_IP_addr = ExtractIPv4(sPrinterNameParam);
                    ipAddress_IsValid = IPAddress.TryParse(sTmp_IP_addr, out _IP_Address);
                }
            }
            catch (Exception)
            {
                ipAddress_IsValid = false;
            }

            _bLogoCheck_T = true;
            _bLogoCheck_B = true;

            // init
            _sOrdineNum = "0123"; // per sampleText
            _sDataStr = GetActualDate().ToString("ddMMyy");

            sFileName = Path.GetFileName(_sFileToPrintParam);

            // accetta anche Legacy con Logo grafico
            if (bIs_USB_ETH_Printer || (sGlbLegacyPrinterParams.iLogoBmp == 1))
            {
                _imgTmp_T = WinPrinterDlg._rWinPrinterDlg.GetWinPrinterLogo(true);
                _imgTmp_B = WinPrinterDlg._rWinPrinterDlg.GetWinPrinterLogo(false);

                // controlli sul Logo Top
                if (String.IsNullOrEmpty(_sWinPrinterParams.sLogoName_T))
                    _bLogoCheck_T = false;
                else
                {
                    // verifica che esista anche il nome del file Logo
                    if ((_sWinPrinterParams.iLogoWidth_T < 50) || (_sWinPrinterParams.iLogoWidth_T > (LOGO_WIDTH + 100)) ||
                       (_sWinPrinterParams.iLogoHeight_T < 50) || (_sWinPrinterParams.iLogoHeight_T > (LOGO_HEIGHT + 100)))
                        _bLogoCheck_T = false;
                }

                // controlli sul Logo Bottom
                if (String.IsNullOrEmpty(_sWinPrinterParams.sLogoName_B))
                    _bLogoCheck_B = false;
                else
                {
                    // verifica che esista anche il nome del file Logo
                    if ((_sWinPrinterParams.iLogoWidth_B < 50) || (_sWinPrinterParams.iLogoWidth_B > (LOGO_WIDTH + 100)) ||
                       (_sWinPrinterParams.iLogoHeight_B < 50) || (_sWinPrinterParams.iLogoHeight_B > (LOGO_HEIGHT + 100)))
                        _bLogoCheck_B = false;
                }

                if (_bLogoCheck_T)
                {
                    // Zoom logo Top
                    _fHZoomedWidth_T = _imgTmp_T.Width * _sWinPrinterParams.iLogoZoomValue / 100.0f;
                    _fVZoomedHeight_T = _imgTmp_T.Height * _sWinPrinterParams.iLogoZoomValue / 100.0f;

                    _img_T = new Bitmap((int)_fHZoomedWidth_T, (int)_fVZoomedHeight_T);

                    using (Graphics g = Graphics.FromImage(_img_T))
                    {
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.DrawImage(_imgTmp_T, new Rectangle(0, 0, (int)_fHZoomedWidth_T, (int)_fVZoomedHeight_T));
                    }
                }

                if (_bLogoCheck_B)
                {
                    // Zoom logo Bottom
                    _fHZoomedWidth_B = _imgTmp_B.Width * _sWinPrinterParams.iLogoZoomValue / 100.0f;
                    _fVZoomedHeight_B = _imgTmp_B.Height * _sWinPrinterParams.iLogoZoomValue / 100.0f;

                    _img_B = new Bitmap((int)_fHZoomedWidth_B, (int)_fVZoomedHeight_B);

                    using (Graphics g = Graphics.FromImage(_img_B))
                    {
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.DrawImage(_imgTmp_B, new Rectangle(0, 0, (int)_fHZoomedWidth_B, (int)_fVZoomedHeight_B));
                    }
                }
            }
            else
            {
                if (sGlbLegacyPrinterParams.iLogoBmp == 0)
                {
                    _bLogoCheck_T = false;
                    _bLogoCheck_B = false;
                }
            }


            _iGruppoStampa = 0;
            _bIsDati = false;
            _bIsTicket = false;

            _bCassaInline = IsBitSet(SF_Data.iGenericPrintOptions, (int)GEN_PRINTER_OPTS.BIT_CASSA_INLINE);

            _iInitialRowsToAdd = GetNumberOfSetBits(SF_Data.iGenericPrintOptions, (int)GEN_PRINTER_OPTS.BIT_EMPTY_ROWS_INITIAL, 4);
            _finalRowsToAdd = GetNumberOfSetBits(SF_Data.iGenericPrintOptions, (int)GEN_PRINTER_OPTS.BIT_EMPTY_ROWS_FINAL, 4);

            if (sFileName.Contains("_TT") || sFileName.Contains("_TN"))
            {
#if STANDFACILE || STAND_MONITOR
                // gruppi in fase di emissione ordine
                if (IsBitSet(SF_Data.iStatusReceipt, (int)STATUS_FLAGS.BIT_CARICATO_DA_WEB))
                {
                    _iGruppoStampa = NUM_WEB_SALE_GRP;
                }
#endif
                if (sFileName.Contains("_TT"))
                {
                    _bIsTicket = true;

                    _bTicketNumFound = false; // forza ricerca stringa

                    if (CheckService(CFG_COMMON_STRINGS._ESCPOS_PRINTER_58mm))
                    {
                        _printerWidth = 384;

                        _iStyle = PrintStyle.None;
                        _iLMargin = TM_T88_LMARGIN_SCNT_FRID;
                    }
                    else if (CheckService(CFG_COMMON_STRINGS._ESCPOS_PRINTER_XL))
                    {
                        _iLMargin = 0;
                        _iStyle = PrintStyle.FontB | PrintStyle.DoubleWidth | PrintStyle.DoubleHeight;
                    }
                    else
                    {
                        _iStyle = PrintStyle.None;
                        _iLMargin = iTM_T88_LMARGIN_SCNT_FSTD;
                    }
                }
                else // copia locale
                {
                    _bTicketNumFound = true;

                    _iStyle = PrintStyle.FontB | PrintStyle.DoubleWidth | PrintStyle.DoubleHeight;
                    _iLMargin = TM_T88_LMARGIN_SCNT_FRID;
                }
            }
            else if (sFileName.Contains("_CT") || sFileName.Contains("CT_")) // copia in rete
            {
                _bTicketNumFound = false;

                iPos = sFileName.IndexOf("_G");
                _iGruppoStampa = Convert.ToInt32(sFileName[iPos + 2]) - 48;

                _iStyle = PrintStyle.FontB | PrintStyle.DoubleWidth | PrintStyle.DoubleHeight;
                _iLMargin = TM_T88_LMARGIN_SCNT_FRID;
            }
            else
            {
                // file specifici

                //_bLogoCheck_T = false;
                //_bLogoCheck_B = false;

                if (sFileName.Contains("Listino"))
                {
                    _bIsDati = true;
                }
                else if (sFileName.Contains(NOME_FILE_SAMPLE_TEXT) || sFileName.Contains(Define.NOME_FILE_RECEIPT) || sFileName.Contains("_Msg"))
                {
                    _bTicketNumFound = true;

                    if (CheckService(CFG_COMMON_STRINGS._ESCPOS_PRINTER_58mm))
                    {
                        _iStyle = PrintStyle.None;
                        _iLMargin = TM_T88_LMARGIN_SCNT_FRID;
                    }
                    else if (CheckService(CFG_COMMON_STRINGS._ESCPOS_PRINTER_XL))
                    {
                        _iLMargin = 0;
                        _iStyle = PrintStyle.FontB | PrintStyle.DoubleWidth | PrintStyle.DoubleHeight;
                    }
                    else
                    {
                        _iStyle = PrintStyle.None;
                        _iLMargin = iTM_T88_LMARGIN_SCNT_FSTD;
                    }
                }
                else if (sFileName.Contains(Define.NOME_FILE_RECEIPT_NP))
                {
                    _bTicketNumFound = false;

                    _iStyle = PrintStyle.FontB | PrintStyle.DoubleWidth | PrintStyle.DoubleHeight;
                    _iLMargin = TM_T88_LMARGIN_SCNT_FRID;
                }
                else if (sFileName.Contains(NOME_FILE_STAMPA_LOC_RID_TMP))
                {
                    _bTicketNumFound = true;
                    _bIsDati = true;
                    _iLMargin = TM_T88_LMARGIN_DATA_RID;

                }
                else if (sFileName.Contains(NOME_FILE_STAMPA_LOC_TMP) || sFileName.Contains("_Dati"))
                {
                    _bTicketNumFound = true;
                    _bIsDati = true;

                    _iStyle = PrintStyle.FontB;
                    _iLMargin = TM_T88_LMARGIN_DATA;
                }
            }


            // String sTmpFormat = String.Format("{0,2:D2}", _iGruppoStampa);
            _cGruppoStampa[0] = String.Format("{0,2:D2}", _iGruppoStampa)[0];
            _cGruppoStampa[1] = String.Format("{0,2:D2}", _iGruppoStampa)[1];

            try
            {
                // corretto aprire qui il file in caso di stampa su più pagine
                if (File.Exists(_sFileToPrintParam))
                    _fileToPrint = File.OpenText(_sFileToPrintParam);
                else
                    return null;

                Logger.Info("Printer_ESCPOS : inizio stampa di " + _sFileToPrintParam);

                // fondamentale per evitare di stampare più volte lo stesso contenuto
                _bytes.Clear();

                _bytes.AddRange(_emitter.Initialize());

                // ciclo esterno per consentire i tagli intermedi
                while (!_fileToPrint.EndOfStream)
                {
                    Logger.Info("Printer_ESCPOS : dopo new PrintDocument()");

                    // non stampa la Receipt
                    if (_bIsTicket && CheckService(CFG_COMMON_STRINGS._SKIP_STAMPA_RCP))
                    {
                        break;
                    }
                    else
                    {
                        Logger.Info("Printer_ESCPOS : prima di PrintPage");

                        // prepara il byte[] per la stampa
                        escpos_PrintPage(bIs_USB_ETH_Printer);

                        // invio dati di stampa alla stampante solo attraverso COM, LPT
                        if (!bIs_USB_ETH_Printer)
                            continue;

                        try
                        {
                            if (ipAddress_IsValid)
                            {
                                //_ETH_printer = new ImmediateNetworkPrinter(new ImmediateNetworkPrinterSettings()
                                //{
                                //    ConnectionString = $"{_IP_Address.ToString()}:{9100}",
                                //    PrinterName = "ethPrinter",
                                //    SendTimeoutMs = 2000,
                                //    ReceiveTimeoutMs = 2000,
                                //    ConnectTimeoutMs = 2000
                                //});

                                //_ETH_printer.WriteAsync(_bytes.ToArray()).GetAwaiter();

                                // stampa Ethernet
                                bool bSuccess = SendToEthPrinterWithTimeoutAsync(_IP_Address.ToString(), 9100, _bytes.ToArray(), 2500).ConfigureAwait(false).GetAwaiter().GetResult();

                                if (!bSuccess && !CheckService(Define.CFG_SERVICE_STRINGS._AUTO_SEQ_TEST))
                                {
                                    _WrnMsg.sMsg = sMsgPrinter;
                                    _WrnMsg.iErrID = WRN_STF;
                                    WarningManager(_WrnMsg);
                                }
                            }
                            else
                            {
                                string jobName = $"job_{DateTime.Now:HHmmss}_{DateTime.Now:fff}";

                                using (var ms = new MemoryStream(_bytes.ToArray()))
                                {
                                    // stampa USB, Ethernet attraverso lo spooler di Windows (che utilizza il nome della stampante)
                                    // non utilizza il driver della stampante, ma invia direttamente i byte ESC/POS
                                    _rawPrinter.PrintRawStream(_printerName, ms, jobName, false);
                                }
                            }

                            Logger.Info("Printer_ESCPOS : dopo PrintPage");
                        }
                        catch (Exception ex)
                        {
                            sTmp_IP_addr = String.Format("Printer_ESCPOS : dopo PrintPage {0}", ex.ToString());
                            Logger.Info(sTmp_IP_addr);
                        }
                    }
                } // end while()

                _fileToPrint.Close();

#if STANDFACILE

                if (CheckService(CFG_COMMON_STRINGS._SKIP_RCP_NUM))
                    _bSkipNumeroScontrino = true;

                if (sConfig.iPrintInterval > 200)
                    iPrint_WaitInterval = sConfig.iPrintInterval;

                if (!CheckService(Define.CFG_SERVICE_STRINGS._AUTO_SEQ_TEST))
                    Thread.Sleep(iPrint_WaitInterval);
#endif

                Logger.Info("Printer_ESCPOS : file Close");
                //throw new System.InvalidOperationException("Prova null");
            }

            catch (Exception ex)
            {
                _fileToPrint.Close();

                sTmp = String.Format("Printer_ESCPOS : {0}", ex.ToString());
                Logger.Info(sTmp);

                _WrnMsg.sMsg = sMsgPrinter;
                _WrnMsg.iErrID = WRN_STF;
                WarningManager(_WrnMsg);
            }

            return _bytes.ToArray();
        }

        private static void escpos_PrintPage(bool bIs_USB_ETH_Printer)
        {
            bool bLogoRequested_T, bLogoRequested_B, bBarcodeRequested;
            int i, iPos1, iPos2;

            string sTmp, sInStr;
            String sBarcode;

            // fondamentale per evitare di stampare più volte lo stesso contenuto
            if (bIs_USB_ETH_Printer)
            {
                // solo con USB, ETH dato che la stampa è sincrona con la lettura del file,
                // mentre con COM, LPT la stampa è successiva alla lettura del file
                _bytes.Clear();
                _bytes.AddRange(_emitter.Initialize());
            }
            else
            {
                if ((_iStyle & PrintStyle.DoubleHeight) != 0)
                    _bytes.AddRange(_emitter.SetLineSpacingInDots(80));
                else
                    _bytes.AddRange(_emitter.ResetLineSpacing());
            }

            _bytes.AddRange(_emitter.LeftAlign());

            _bytes.AddRange(_emitter.SetStyles(_iStyle));

            for (i = 0; i < _iInitialRowsToAdd; i++) // N righe di inizio stampa
                _bytes.AddRange(_emitter.PrintLine(""));

            while ((sInStr = _fileToPrint.ReadLine()) != null)
            {
                if (!String.IsNullOrEmpty(sInStr) && (sInStr.IndexOf(_LOGO_T) != -1) || (sInStr.IndexOf(_LOGO) != -1))
                {
                    bLogoRequested_T = true;

                    sInStr = _fileToPrint.ReadLine();
                }
                else
                    bLogoRequested_T = false;

                if (!String.IsNullOrEmpty(sInStr) && (sInStr.IndexOf(_LOGO_B) != -1))
                {
                    bLogoRequested_B = true;

                    sInStr = _fileToPrint.ReadLine();
                }
                else
                    bLogoRequested_B = false;

                if (!String.IsNullOrEmpty(sInStr) && (sInStr.IndexOf(_BARCODE) != -1))
                {
                    bBarcodeRequested = true;

                    sInStr = _fileToPrint.ReadLine();
                }
                else
                    bBarcodeRequested = false;

                /*************************************
                 *        Stampa del Logo Top
                 *************************************/
                if (bIs_USB_ETH_Printer && _bLogoCheck_T && bLogoRequested_T)
                {
                    // per alcune stampanti es. HOIN non funziona con le immagini
                    // _bytes.AddRange(_emitter.CenterAlign());

                    _bytes.AddRange(_emitter.LeftAlign());

                    _bytes.AddRange(BitmapToEscPos(new Bitmap(_img_T), _printerWidth));

                }
                else if (!bIs_USB_ETH_Printer && bLogoRequested_T)
                {
                    if ((sGlbLegacyPrinterParams.iLogoBmp > 1) && (sGlbLegacyPrinterParams.iLogoBmp <= 5))
                    {
                        // remap 1..4
                        printLogo(sGlbLegacyPrinterParams.iLogoBmp - 1);
                    }
                }

                /*************************************
                 * 		   Stampa del testo
                 *************************************/

                if (!String.IsNullOrEmpty(sInStr))
                    iPos1 = sInStr.IndexOf(_RECEIPT_NUM); // strLenght = 5 attenzione alla corrispondenza stringa !
                else
                    iPos1 = -1;

                if (!String.IsNullOrEmpty(sInStr))
                    iPos2 = sInStr.IndexOf(_RECEIPT_CUSTOMER_COPY);
                else
                    iPos2 = -1;

                // costruzione Num. scontrino per Barcode
                if (iPos1 != -1)
                {
                    sTmp = sInStr.Substring(iPos1 + _RECEIPT_NUM.Length);
                    sTmp = sTmp.Trim();

                    _sOrdineNum = String.Format("{0:d4}", Convert.ToInt32(sTmp));
                    _bTicketNumFound = true;

                    if (!_bSkipNumeroScontrino)
                    {
                        _bytes.AddRange(_emitter.CenterAlign());

                        // passa a FontStyle.Bold
                        sInStr = sInStr.Trim();

                        _bytes.AddRange(_emitter.SetStyles(PrintStyle.FontB | PrintStyle.DoubleWidth | PrintStyle.DoubleHeight));

                        _bytes.AddRange(_emitter.PrintLine(sInStr));
                        _bytes.AddRange(_emitter.SetStyles(_iStyle));

                        _bytes.AddRange(_emitter.LeftAlign());
                    }
                }
                // COPIA CLIENTE
                else if (iPos2 != -1)
                {
                    _bytes.AddRange(_emitter.CenterAlign());

                    // passa a FontStyle.Bold
                    sInStr = sInStr.Trim();

                    _bytes.AddRange(_emitter.SetStyles(PrintStyle.FontB | PrintStyle.DoubleWidth | PrintStyle.DoubleHeight));

                    _bytes.AddRange(_emitter.PrintLine(sInStr));
                    _bytes.AddRange(_emitter.SetStyles(_iStyle));

                    _bytes.AddRange(_emitter.LeftAlign());
                }
                else
                {
                    // elimina Keywords Prezzi
                    if (_bIsDati && (sInStr.Length > 2))
                    {
                        if ((sInStr[0] == '#') && (sInStr[1] == 'L') && (sInStr[2] == 'F'))// Line Feed multipli
                        {
                            _fileToPrint.ReadLine();

                            sInStr = _fileToPrint.ReadLine();
                        }
                        else if ((sInStr[0] == '#') && (sInStr[1] == 'C') && (sInStr[2] == 'K'))// Checksum
                            sInStr = _fileToPrint.ReadLine();
                    }

                    if (!String.IsNullOrEmpty(sInStr) && sInStr.Contains(_CUT))
                    {
                        sInStr = _fileToPrint.ReadLine();
                        sInStr = _fileToPrint.ReadLine();

                        break;
                    }
                    // testo normale
                    else if (!(bLogoRequested_T || bLogoRequested_B || bBarcodeRequested))
                    {
                        for (i = 0; i < _iLMargin; i++) // centratura
                            sInStr = sInStr.Insert(0, " ");

                        _bytes.AddRange(_emitter.PrintLine(sInStr));
                    }
                }

                /*************************************
                 * 		Stampa del Logo Bottom
                 *************************************/
                if (_bLogoCheck_B && bLogoRequested_B)
                {
                    // per alcune stampanti es. HOIN non funziona con le immagini
                    // _bytes.AddRange(_emitter.CenterAlign());

                    _bytes.AddRange(_emitter.LeftAlign());

                    _bytes.AddRange(BitmapToEscPos(new Bitmap(_img_B), _printerWidth));

                }

                /******************************************************
                                   BAR CODE EAN13
                  effettua la stampa solo se il flag bStampaBarcode
                  è abilitato dal dialogo FrmImpostaTipoCassa
                 ******************************************************/
                if (bBarcodeRequested)
                {
                    sBarcode = String.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}",
                        _cGruppoStampa[0], _cGruppoStampa[1],                                                   // 2 gruppo di stampa
                        _sDataStr[0], _sDataStr[1], _sDataStr[2], _sDataStr[3], _sDataStr[4], _sDataStr[5],     // date
                        _sOrdineNum[0], _sOrdineNum[1], _sOrdineNum[2], _sOrdineNum[3]);                        // Scontrino num

                    if (_sFileToPrintParam.Contains(NOME_FILE_SAMPLE_TEXT))
                    {
                        Barcode_EAN13.BuildBarcodeID("01" + _sDataStr + "0123");
                    }
                    else
                        Barcode_EAN13.BuildBarcodeID(sBarcode);

                    // _sBarcodeID comprende il checksum
                    sTmp = String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12}",
                            Barcode_EAN13._sBarcodeID[0], Barcode_EAN13._sBarcodeID[1], Barcode_EAN13._sBarcodeID[2], Barcode_EAN13._sBarcodeID[3],
                            Barcode_EAN13._sBarcodeID[4], Barcode_EAN13._sBarcodeID[5], Barcode_EAN13._sBarcodeID[6], Barcode_EAN13._sBarcodeID[7],
                            Barcode_EAN13._sBarcodeID[8], Barcode_EAN13._sBarcodeID[9], Barcode_EAN13._sBarcodeID[10], Barcode_EAN13._sBarcodeID[11],
                            Barcode_EAN13._sBarcodeID[12]);

                    _bytes.AddRange(_emitter.CenterAlign());

                    _bytes.AddRange(_emitter.SetBarcodeHeightInDots(120));
                    _bytes.AddRange(_emitter.SetBarWidth(BarWidth.Default));
                    //_bytes.AddRange(_emitter.SetBarLabelFontB(true));
                    //_bytes.AddRange(_emitter.SetBarLabelPosition(BarLabelPrintPosition.Below));
                    _bytes.AddRange(_emitter.PrintBarcode(BarcodeType.JAN13_EAN13, sBarcode));
                    _bytes.AddRange(_emitter.SetStyles(PrintStyle.None));
                    _bytes.AddRange(_emitter.PrintLine(sTmp));

                    Logger.Info(String.Format("Printer ESCPOS: _sBarcodeID = {0}", sTmp));
                }

            } // end while()

            _bytes.AddRange(_emitter.PrintLine(""));
            _bytes.AddRange(_emitter.PrintLine(""));
            _bytes.AddRange(_emitter.PrintLine(""));
            _bytes.AddRange(_emitter.PrintLine(""));
            _bytes.AddRange(_emitter.PrintLine(""));

            for (i = 0; i < _finalRowsToAdd - 1; i++) // N righe di fine stampa
                _bytes.AddRange(_emitter.PrintLine(" "));

            //_bytes.AddRange(_emitter.PartialCutAfterFeed(5));
            _bytes.AddRange(_emitter.FullCutAfterFeed(5));

            // apertura cassetto
            if (IsBitSet(iEscPosPrinterType, NUM_SEP_PRINT_GROUPS + 3))
                _bytes.AddRange(_emitter.CashDrawerOpenPin2());

            if (!_bTicketNumFound)
            {
                _WrnMsg.iErrID = WRN_TNFF;
                _WrnMsg.sNomeFile = _sFileToPrintParam;
                WarningManager(_WrnMsg);
            }

        }

        /// <summary>metodo di invio dati di stampa su ethernet con timeout</summary>
        public static async Task<bool> SendToEthPrinterWithTimeoutAsync(string ip, int port, byte[] data, int timeoutMs)
        {
            using (var cts = new CancellationTokenSource(timeoutMs)) // timeout globale
            using (var client = new TcpClient())
            {
                try
                {
                    // Tentativo di connessione con timeout
                    var connectTask = client.ConnectAsync(ip, port);
                    if (await Task.WhenAny(connectTask, Task.Delay(timeoutMs, cts.Token)).ConfigureAwait(false) != connectTask)
                    {
                        // timeout connessione
                        return false;
                    }

                    using (var stream = client.GetStream())
                    {
                        // Invio dei dati con timeout
                        var writeTask = stream.WriteAsync(data, 0, data.Length, cts.Token);
                        if (await Task.WhenAny(writeTask, Task.Delay(timeoutMs, cts.Token)).ConfigureAwait(false) != writeTask)
                        {
                            // timeout invio
                            client.Close(); // forza chiusura
                            return false;
                        }

                        await stream.FlushAsync(cts.Token).ConfigureAwait(false);
                    }

                    return true;
                }
                catch (OperationCanceledException)
                {
                    // timeout raggiunto
                    return false;
                }
                catch (Exception)
                {
                    // log/gestione errore
                    return false;
                }
            }
        }

        /***************************************
                 test di esempio di stampa
         ***************************************/
        public static void PrintSampleText(TWinPrinterParams sPrinterParams)
        {
            String sTmp, sFileToPrint;

            sFileToPrint = BuildSampleText(PRINTER_TYPE.STAMPANTE_USB_ETH, sPrinterParams);

            _sOrdineNum = "0123"; // per sampleText

            sTmp = String.Format("Printer_ESCPOS : printESCPOSSampleText() {0}", sFileToPrint);
            Logger.Info(sTmp);

            PrintFile(sFileToPrint, sPrinterParams, NUM_SEP_PRINT_GROUPS); // OK
        }

        public static byte[] BitmapToEscPos(Bitmap bmp, int paperWidthPx = 576)
        {
            // 1. CENTRATURA AUTOMATICA
            int offset = (paperWidthPx - bmp.Width) / 2;
            if (offset < 0) offset = 0;

            Bitmap centered = new Bitmap(paperWidthPx, bmp.Height);
            using (Graphics g = Graphics.FromImage(centered))
            {
                g.Clear(System.Drawing.Color.White);
                g.DrawImage(bmp, offset, 0);
            }

            // 2. CONVERSIONE ESC/POS GS v 0
            int width = centered.Width;
            int height = centered.Height;

            int widthBytes = (width + 7) / 8;

            List<byte> data = new List<byte>();

            // GS v 0
            data.Add(0x1D);
            data.Add(0x76);
            data.Add(0x30);
            data.Add(0x00);

            // xL xH
            data.Add((byte)(widthBytes & 0xFF));
            data.Add((byte)((widthBytes >> 8) & 0xFF));

            // yL yH
            data.Add((byte)(height & 0xFF));
            data.Add((byte)((height >> 8) & 0xFF));

            for (int y = 0; y < height; y++)
            {
                for (int xByte = 0; xByte < widthBytes; xByte++)
                {
                    byte b = 0;

                    for (int bit = 0; bit < 8; bit++)
                    {
                        int x = xByte * 8 + bit;

                        if (x >= width)
                            continue;

                        System.Drawing.Color pixel = centered.GetPixel(x, y);
                        int gray = (pixel.R + pixel.G + pixel.B) / 3;

                        if (gray < 128)
                            b |= (byte)(0x80 >> bit);
                    }

                    data.Add(b);
                }
            }

            return data.ToArray();
        }

        /// <summary>funzione per eliminare i caratteri superflui che precedono gli indirizzi ipv4</summary>
        static string ExtractIPv4(string input)
        {
            var match = Regex.Match(
                input,
                @"\b(?:(?:25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)\.){3}(?:25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)\b"
            );

            return match.Success ? match.Value : null;
        }


        /// <summary>accoda il comando di stampa Logo in _bytes[]</summary>
        static void printLogo(int iLogoParam)
        {
            // verifica range
            if ((iLogoParam < 1) || (iLogoParam > 4))
                return;

            byte[] logoBuffer =
            {
                0x1C, 0x70,
                0x00, // logo xx
                0x00 // modalità normale
            };

            logoBuffer[2] = (byte)(iLogoParam);

            _bytes.AddRange(logoBuffer);
        }

    }
}
