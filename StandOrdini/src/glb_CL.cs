/*****************************************
 	NomeFile : StandOrdini/glb_CL.cs
	Data	 : 06.12.2024
 	Autore   : Mauro Artuso
 *****************************************/

using System;
using System.Collections;
using static StandCommonFiles.ComDef;

namespace StandFacile
{
#pragma warning disable IDE1006

    /// <summary>
    /// classe che contitne le variabili globali
    /// </summary>
    public struct glb
    {
        /// <summary>flag di avviso singolo</summary>
        public static bool bWarnOnce;

        /// <summary>Struct fondamentale</summary>
        public static TData SF_Data = new TData(DataID.SF_DATA);

        /// <summary>coda per il Log</summary>
        public static Queue logQueue = new Queue();

        /// <summary>coda ordini da scaricare</summary>
        public static Queue ordiniQueue = new Queue();

        /// <summary>stringa di root path</summary>
        public static String sRootDir;
    }
}
