using System;

namespace Exercism
{
    static class LogLine
    {
        // 1. Extrae el mensaje de la línea de log ignorando el nivel y los espacios extra
        public static string Message(string logLine)
        {
            return logLine.Split(":")[1].Trim();
        }

        // 2. Extrae el nivel del log que está entre corchetes [] y lo pasa a minúsculas
        public static string LogLevel(string logLine)
        {
            int startPos = logLine.IndexOf('[') + 1;
            int length = logLine.IndexOf(']') - startPos;
            return logLine.Substring(startPos, length).ToLower();
        }

        // 3. Reformatea la línea en el formato "Mensaje (nivel)"
        public static string Reformat(string logLine)
        {
            return $"{Message(logLine)} ({LogLevel(logLine)})";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de prueba de línea de log
            string log = "[ERROR]: Invalid operation\r\n";

            Console.WriteLine("--- Pruebas de LogLine ---");
            Console.WriteLine($"Mensaje: '{LogLine.Message(log)}'");
            Console.WriteLine($"Nivel: '{LogLine.LogLevel(log)}'");
            Console.WriteLine($"Reformateado: '{LogLine.Reformat(log)}'");
        }
    }
}