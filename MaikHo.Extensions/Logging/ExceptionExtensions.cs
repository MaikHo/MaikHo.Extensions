using System;
using System.IO;

namespace MaikHo.Extensions.Logging
{
    public static class ExceptionExtensions
    {
        private static readonly string LogFilePath = "ExceptionLog.txt";

        // Extension Method: Schreiben einer Ausnahme in eine Log-Datei mit Stacktrace-Informationen
        public static void LogExceptionToFileWithStackTrace(this Exception exception)
        {
            File.AppendAllText(LogFilePath, $"{DateTime.Now} - EXCEPTION: {exception.ToString()}{Environment.NewLine}");
            File.AppendAllText(LogFilePath, $"Stacktrace: {exception.StackTrace}{Environment.NewLine}");
        }

        // Extension Method: Schreiben von Ausnahmeinformationen in eine Log-Datei
        public static void LogExceptionDataToFile(this Exception exception)
        {
            File.AppendAllText(LogFilePath, $"{DateTime.Now} - EXCEPTION DATA:{Environment.NewLine}");
            foreach (var key in exception.Data.Keys)
            {
                File.AppendAllText(LogFilePath, $"{key}: {exception.Data[key]}{Environment.NewLine}");
            }
        }
    }
}
