/****************************************************************
    NomeFile : StandCommonSrc/Logger    .cs
    Data	 : 12.12.2025
 	Autore	 : Mauro Artuso

    NLog levels: TRACE, DEBUG, INFO, WARN, ERROR, FATAL
 ****************************************************************/

using System;
using System.IO;

using NLog;
using NLog.Config;
using NLog.Targets;
using NLog.Targets.Wrappers;
using StandFacile;
using static StandCommonFiles.CommonCl;

namespace StandCommonFiles
{

    /// <summary>Logger NLog class</summary>
    public static class LoggerNLog
    {
        /// <summary>istanza per la configurazione</summary>
        public static LoggingConfiguration config;

        /// <summary>imposta il file per il Logger ed il layout</summary>
        public static void ConfigureAppender()
        {
            String sLogDir, logFileName;
            String sNomeLogFile;

#if STANDFACILE
            sLogDir = DataManager.GetLogDir() + "\\";
            sNomeLogFile = "Log_" + GetActualDate().ToString("yyMMdd") + ".txt";
#else
            sLogDir = Directory.GetCurrentDirectory() + "\\";
            sNomeLogFile = "Log_" + DateTime.Now.ToString("yyMMdd") + ".txt";
#endif

            logFileName = sLogDir + sNomeLogFile;

            // Creazione della configurazione
            config = new LoggingConfiguration();

            // Definizione di un target (Console)
            var consoleTarget = new ConsoleTarget("console")
            {
                Layout = "${date:format=HH\\:mm\\:ss.fff} | ${level:uppercase=true} | ${logger} | ${message}"
            };

            // Definizione di un target (File)
            var fileTarget = new FileTarget("file")
            {
                FileName = logFileName,
                Layout = "${date:format=HH\\:mm\\:ss.fff} | ${level} | ${message} ${exception:format=ToString}"
            };

            // Wrap the file target in an AsyncTargetWrapper
            var asyncFileWrapper = new AsyncTargetWrapper(fileTarget)
            {
                QueueLimit = 5000,    // Max number of messages in queue
                OverflowAction = AsyncTargetWrapperOverflowAction.Discard // or Grow
            };

#if DEBUG
            // Aggiunta dei target alla configurazione
            config.AddTarget(consoleTarget);
#endif

            config.AddTarget(asyncFileWrapper);

            // Regole di logging
            config.AddRule(LogLevel.Warn, LogLevel.Fatal, consoleTarget);
            config.AddRule(LogLevel.Info, LogLevel.Fatal, asyncFileWrapper);
        }

    }
}

