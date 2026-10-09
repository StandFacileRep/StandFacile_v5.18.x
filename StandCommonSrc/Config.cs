/*****************************************************
  	NomeFile : StandFacile/Config.cs
	Data	 : 09.10.2026
  	Autore	 : Mauro Artuso
 *****************************************************/

using System;
using System.IO;
using static StandCommonFiles.ComDef;
using static StandCommonFiles.CommonCl;

namespace StandFacile
{
    /// <summary>classe per caricamento del file di configurazione</summary>
    public class Config
    {
#pragma warning disable IDE1006

        const String sRCP_CS_HEADER = "receipt_CS_AltHeader_AH";

        /// <summary>riferimento a Config</summary>
        public static Config rConfig { get; private set; }

        TErrMsg _ErrMsg;

        /// <summary>verifica se la stringa passata è contenuta nella chiave "serviceStrings"</summary>
        public static bool CheckService(String sString)
        {
            if (!String.IsNullOrEmpty(sConfig.sService) && sConfig.sService.Contains(sString))
                return true; // mediante config.ini
            else
                return false;
        }

        /// <summary>costruttore</summary>
        public Config()
        {
            rConfig = this;

            sConfig.iReceiptStartNumber = 1; // giusto 1 e non 0
            sConfig.sService = "";

            sConfig.bRcpCopyRequired = false;
            sConfig.sRcpCopyHeader = "";

            LoadConfig();
        }

        /// <summary>
        /// lettura del file dei configurazione
        /// </summary>
        public void LoadConfig()
        {
            int iCount, iTmp, hIndex;
            String sTmp, sExeDir, sNomeConfigFile, sInStr;
            StreamReader fConfig;

            iCount = 0;

            // impostazione della directory per il file Prezzi (la stessa dell'eseguibile)
            sExeDir = Directory.GetCurrentDirectory();

            // Directory.SetCurrentDirectory(sExeDir);

#if STANDFACILE
            sNomeConfigFile = DataManager.GetExeDir() + "\\" + CONFIG_FILE;
#else
            sNomeConfigFile = sExeDir + "\\" + CONFIG_FILE;
#endif

            if (File.Exists(sNomeConfigFile))
            {

                fConfig = File.OpenText(sNomeConfigFile);
                Logger.Info("LoadConfig : caricamento");

                // ***** caricamento stringhe dal file di configurazione *****
                while (((sInStr = fConfig.ReadLine()) != null) && (iCount < 100))
                {
                    sInStr = sInStr.Trim();

                    iCount++;

                    // deve stare nel primo if
                    if (sInStr.StartsWith(";"))
                        continue;

                    else if (String.IsNullOrEmpty(sInStr))
                        continue;

                    else if (sInStr.Contains("receiptStartNumber"))
                    {

                        iTmp = GetIntVal(sInStr);

                        if (iTmp > 0)
                            sConfig.iReceiptStartNumber = iTmp;

                        continue;
                    }
                    else if (sInStr.Contains("refreshTimer"))
                    {
                        iTmp = GetIntVal(sInStr);

                        if (iTmp > 0)
                            sConfig.iRefreshTimer = iTmp;

                        continue;
                    }

                    else if (sInStr.Contains("iPrintInterval"))
                    {
                        iTmp = GetIntVal(sInStr);

                        if (iTmp > 0)
                            sConfig.iPrintInterval = iTmp;

                        continue;
                    }

                    else if (sInStr.Contains("localCopyPrinterNumRedirect"))
                    {
                        iTmp = GetIntVal(sInStr);

                        // i gruppi vanno da 1 a 11 per l'utente, 0 - 10 per il programma
                        if ((iTmp > 0) && (iTmp <= NUM_SEP_PRINT_GROUPS + 1))
                            sConfig.iLocalCopyPrinterNumRedirect = iTmp - 1;

                        continue;
                    }

                    else if (sInStr.Contains("baud_rate"))
                    {

                        iTmp = GetIntVal(sInStr);

                        if (iTmp > 0)
                            sConfig.iBaudRate = iTmp;

                        continue;
                    }

                    // stringhe per stampa copia Receipt() completa dei prezzi
                    else if (sInStr.Contains("receiptCopyRequired_HeaderIs"))
                    {
                        sConfig.bRcpCopyRequired = true;
                        sConfig.sRcpCopyHeader = GetStringVal(sInStr);

                        continue;
                    }

                    // stringhe per cambio nome database
                    else if (sInStr.Contains("databaseNameIs"))
                    {
                        sConfig.sDatabaseName = GetStringVal(sInStr);

                        continue;
                    }

                    // stringhe per cambio nome utente database
                    else if (sInStr.Contains("databaseUserIs"))
                    {
                        sConfig.sDatabaseUser = GetStringVal(sInStr);

                        continue;
                    }

                    // stringhe per cambio versione StandOrdiniWeb
                    else if (sInStr.Contains("webUrlVersionIs"))
                    {
                        sConfig.sWebUrlVersion = GetStringVal(sInStr);

                        continue;
                    }

                    // stringhe per cambio WebAppHttpServerName
                    else if (sInStr.Contains("webServerNameIs"))
                    {
                        sConfig.sWebAppHttpServerName = GetStringVal(sInStr);

                        continue;
                    }

                    // stringhe per cambio WebApp_DB_HostName
                    else if (sInStr.Contains("sWebApp_DB_HostName"))
                    {
                        sConfig.sWebApp_DB_HostName = GetStringVal(sInStr);

                        continue;
                    }

                    // stringhe per cambio WebApp_DB_UserName
                    else if (sInStr.Contains("sWebApp_DB_UserName"))
                    {
                        sConfig.sWebApp_DB_UserName = GetStringVal(sInStr);

                        continue;
                    }

                    // stringhe per cambio cypherKey Httptunnel
                    else if (sInStr.Contains("cypherKeyIs"))
                    {
                        sConfig.sCypherKey = GetStringVal(sInStr);

                        continue;
                    }

                    // stringhe per footer alternativo
                    else if (sInStr.Contains("extraFooterIs"))
                    {
                        sConfig.sExtraFooter = GetStringVal(sInStr);

                        continue;
                    }

                    // stringhe per stampa Header/Footer Alternativo
                    else if (sInStr.Contains(sRCP_CS_HEADER))
                    {
                        // ha senso solo per la CASSA_SECONDARIA
                        if ((glb.SF_Data.iNumCassa == CASSA_PRINCIPALE)
#if STANDFACILE
                        && !CheckService(Define.CFG_SERVICE_STRINGS._AUTO_SEQ_TEST + "_C2")
#endif
                        )
                            continue;

                        try
                        {
                            sInStr = sInStr.Remove(0, sRCP_CS_HEADER.Length).Trim();

                            // ****	Header/Footer ****

                            sTmp = sInStr.Substring(0, 1); // acquisisce indice

                            hIndex = Convert.ToInt32(sTmp) - 1;

                            if ((hIndex >= 0) && (hIndex < MAX_NUM_HEADERS) && (sInStr.Length > 3))
                            {
                                sTmp = sInStr.Substring(3).Trim();

                                // MAX_RECEIPT_CHARS viene caricato successivamente !
                                if (sTmp.Length > MAX_RECEIPT_CHARS)
                                {
                                    _ErrMsg.iErrID = WRN_CFSTL;
                                    WarningManager(_ErrMsg);  // stringa troppo lunga
                                }
                                else
                                    sConfig.sRcp_CS_Header[hIndex] = sTmp;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        continue;
                    }

                    // questo if va per ultimo
                    else if (sInStr.Contains("serviceStrings"))
                    {
                        sConfig.sService += (" " + GetStringVal(sInStr));
                        continue;
                    }
                }

                sConfig.bFileLoaded = true;
                fConfig.Close();
            }
            else
                Logger.Info("LoadConfig : " + CONFIG_FILE + " non trovato");
        }

        static int GetIntVal(String sInStrParam)
        {
            int iVal, iPos;

            try
            {
                iPos = sInStrParam.IndexOf('=');    // ricerca prima semicolon
                sInStrParam = sInStrParam.Remove(0, iPos + 1);
                sInStrParam = sInStrParam.Replace(";", "");

                iVal = Convert.ToInt32(sInStrParam.Trim());

                sConfig.iReceiptStartNumber = iVal;
                return iVal;

            }
            catch (Exception)
            {
                return -1;
            }
        }

        static String GetStringVal(String sInStrParam)
        {
            int iPos;

            try
            {
                iPos = sInStrParam.IndexOf('=');    // ricerca prima semicolon
                sInStrParam = sInStrParam.Remove(0, iPos + 1).Trim();
                sInStrParam = sInStrParam.Replace("\"", "");

                return sInStrParam;
            }
            catch (Exception)
            {
                return "";
            }
        }

    }
}
