/*****************************************
  	NomeFile : StandMonitor/glb_CL.cs
	Data	 : 30.09.2026
  	Autore   : Mauro Artuso
 *****************************************/

using System;
using System.Collections.Generic;
using static StandCommonFiles.ComDef;

namespace StandFacile
{
#pragma warning disable IDE1006

    /// <summary>
    /// classe che contitne le variabili globali
    /// </summary>
    public struct glb
    {
        /// <summary>Struct fondamentale</summary>
        public static TData SF_Data = new TData(DataID.SF_DATA);

        /// <summary>descrive se Windows o Legacy</summary>
        public static int iSysPrinterType;

        /// <summary>descrive se la stampante è di tipo ESC POS</summary>
        public static int iEscPosPrinterType;

        /// <summary>Struct per la gestione della stampa Windows</summary>
        public static TWinPrinterParams sGlbWinPrinterParams = new TWinPrinterParams(0);
        /// <summary>Struct per la gestione della stampa Legacy</summary>
        public static TLegacyPrinterParams sGlbLegacyPrinterParams = new TLegacyPrinterParams();

        /// <summary>lista stringhe di filtro per il monitor 1</summary>
        public static List<string> sFiltroMon_0;

        /// <summary>lista stringhe di filtro per il monitor 2</summary>
        public static List<string> sFiltroMon_1;

        /// <summary>stringa di root path</summary>
        public static String sRootDir;

    }
}
