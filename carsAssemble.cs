using System;

namespace Exercism
{
    static class AssemblyLine
    {
        private const int BaseCarsPerHour = 221;

        // 1. Determina la tasa de éxito (eficiencia) según la velocidad seleccionada
        public static double SuccessRate(int speed)
        {
            if (speed == 0) return 0.0;
            if (speed >= 1 && speed <= 4) return 1.0;
            if (speed >= 5 && speed <= 8) return 0.9;
            if (speed == 9) return 0.8;
            return 0.77; // Velocidad 10
        }

        // 2. Calcula la producción total de autos por hora considerando la tasa de éxito
        public static double ProductionRatePerHour(int speed)
        {
            return speed * BaseCarsPerHour * SuccessRate(speed);
        }

        // 3. Calcula la cantidad entera de autos producidos por minuto
        public static int WorkingItemsPerMinute(int speed)
        {
            return (int)(ProductionRatePerHour(speed) / 60);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int testSpeed = 6;

            Console.WriteLine("--- Pruebas de AssemblyLine ---");
            Console.WriteLine($"Velocidad probada: {testSpeed}");
            Console.WriteLine($"Tasa de éxito: {AssemblyLine.SuccessRate(testSpeed) * 100}%");
            Console.WriteLine($"Producción por hora: {AssemblyLine.ProductionRatePerHour(testSpeed)} autos");
            Console.WriteLine($"Producción por minuto: {AssemblyLine.WorkingItemsPerMinute(testSpeed)} autos");
        }
    }
}