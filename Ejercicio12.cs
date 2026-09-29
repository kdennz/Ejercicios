using System;

namespace Exercism
{
    public enum LogLevel
    {
        Unknown = 0,
        Trace = 1,
        Debug = 2,
        Info = 4,
        Warning = 5,
        Error = 6,
        Fatal = 42
    }

    public static class LogLine
    {
        public static LogLevel ParseLogLevel(string logLine)
        {
            string code = logLine.Substring(1, 3);

            return code switch
            {
                "TRC" => LogLevel.Trace,
                "DBG" => LogLevel.Debug,
                "INF" => LogLevel.Info,
                "WRN" => LogLevel.Warning,
                "ERR" => LogLevel.Error,
                "FTL" => LogLevel.Fatal,
                _ => LogLevel.Unknown
            };
        }

        public static string OutputForShortLog(LogLevel logLevel, string message)
        {
            return $"{(int)logLevel}:{message}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string log = "[ERR]: Disk full";
            LogLevel level = LogLine.ParseLogLevel(log);

            Console.WriteLine("--- Logs, Logs, Logs! ---");
            Console.WriteLine($"Nivel detectado: {level} (Valor numérico: {(int)level})");
            Console.WriteLine($"Formato corto: {LogLine.OutputForShortLog(level, "Disk full")}");
        }
    }
}