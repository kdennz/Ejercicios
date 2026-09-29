using System;

namespace Exercism
{
    class BirdCount
    {
        private int[] birdsPerDay;

        public BirdCount(int[] birdsPerDay)
        {
            this.birdsPerDay = birdsPerDay;
        }

        public static int[] LastWeek() => new int[] { 0, 2, 5, 3, 7, 8, 4 };

        public int Today() => birdsPerDay[birdsPerDay.Length - 1];

        public void IncrementTodaysCount() => birdsPerDay[birdsPerDay.Length - 1]++;

        public bool HasDayWithoutBirds()
        {
            foreach (int count in birdsPerDay)
            {
                if (count == 0) return true;
            }
            return false;
        }

        public int CountForFirstDays(int numberOfDays)
        {
            int total = 0;
            for (int i = 0; i < numberOfDays; i++)
            {
                total += birdsPerDay[i];
            }
            return total;
        }

        public int BusyDays()
        {
            int count = 0;
            foreach (int birds in birdsPerDay)
            {
                if (birds >= 5) count++;
            }
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] birdsPerDay = { 2, 5, 0, 7, 4, 1, 30 };
            BirdCount birdCount = new BirdCount(birdsPerDay);

            Console.WriteLine("--- Bird Watcher ---");
            Console.WriteLine($"Aves de hoy: {birdCount.Today()}");
            Console.WriteLine($"¿Hubo días sin aves?: {birdCount.HasDayWithoutBirds()}");
            Console.WriteLine($"Conteo primeros 4 días: {birdCount.CountForFirstDays(4)}");
            Console.WriteLine($"Días ocupados (>=5): {birdCount.BusyDays()}");
        }
    }
}