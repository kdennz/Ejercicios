using System;

namespace Exercism
{
    public class Lasagna
    {
        // 1. Devuelve los minutos esperados en el horno (40)
        public int ExpectedMinutesInOven()
        {
            return 40;
        }

        // 2. Calcula el tiempo restante restando los minutos en el horno
        public int RemainingMinutesInOven(int actualMinutes)
        {
            return ExpectedMinutesInOven() - actualMinutes;
        }

        // 3. Calcula el tiempo de preparación (2 minutos por cada capa)
        public int PreparationTimeInMinutes(int layers)
        {
            return layers * 2;
        }

        // 4. Suma el tiempo de preparación y los minutos que lleva en el horno
        public int ElapsedTimeInMinutes(int layers, int actualMinutes)
        {
            return PreparationTimeInMinutes(layers) + actualMinutes;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lasagna lasagna = new Lasagna();

            // Pruebas de funcionamiento
            Console.WriteLine($"Minutos esperados en el horno: {lasagna.ExpectedMinutesInOven()}");
            Console.WriteLine($"Minutos restantes (si lleva 30 min): {lasagna.RemainingMinutesInOven(30)}");
            Console.WriteLine($"Tiempo de preparación para 3 capas: {lasagna.PreparationTimeInMinutes(3)} min");
            Console.WriteLine($"Tiempo total transcurrido (3 capas, 20 min en horno): {lasagna.ElapsedTimeInMinutes(3, 20)} min");
        }
    }
}