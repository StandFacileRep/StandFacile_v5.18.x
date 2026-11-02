/*****************************************
 	NomeFile : StandFacile/glb_CL.cs
	Data	 : 30.09.2026
 	Autore   : Mauro Artuso
 *****************************************/

using static StandCommonFiles.ComDef;

namespace StandFacile
{
#pragma warning disable IDE1006

    /// <summary>classe che contiene le variabili globali</summary>
    public static class glb
    {
        /// <summary>Struct fondamentale</summary>
        public static TData SF_Data = new TData(DataID.SF_DATA);

        /// <summary>descrive se la stampante è di tipo ESC POS</summary>
        public static int iGlbEscPosPrinterType;

        /// <summary>Struct per la gestione della stampa Windows</summary>
        public static TWinPrinterParams sGlbWinPrinterParams = new TWinPrinterParams(0);

        /// <summary>Struct per la gestione della stampa Legacy</summary>
        public static TLegacyPrinterParams sGlbLegacyPrinterParams = new TLegacyPrinterParams();
    }
}
