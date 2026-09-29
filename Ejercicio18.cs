using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism
{
    public static class SpiritualTopTens
    {
        public static IEnumerable<string> FilterTopTens(IEnumerable<string> items, string filterKeyword)
        {
            return items.Where(item => item.Contains(filterKeyword, StringComparison.OrdinalIgnoreCase));
        }

        public static IEnumerable<string> SortTopTens(IEnumerable<string> items)
        {
            return items.OrderBy(item => item);
        }

        public static IEnumerable<string> TakeTopThree(IEnumerable<string> items)
        {
            return items.Take(3);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "Zen Wisdom", "Daily Meditation", "Yoga Practice", "Mindful Zen" };

            Console.WriteLine("--- Spiritual Top Tens ---");
            var filtered = SpiritualTopTens.FilterTopTens(list, "Zen");
            Console.WriteLine("Filtrados por 'Zen': " + string.Join(", ", filtered));
        }
    }
}