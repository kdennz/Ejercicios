using System;
using System.Collections.Generic;

namespace Exercism
{
    public static class DialingCodes
    {
        public static Dictionary<int, string> GetEmptyDictionary() => new Dictionary<int, string>();

        public static Dictionary<int, string> GetExistingDictionary() => new Dictionary<int, string>
        {
            { 1, "United States of America" },
            { 55, "Brazil" },
            { 91, "India" }
        };

        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
        {
            var dict = GetEmptyDictionary();
            dict.Add(countryCode, countryName);
            return dict;
        }

        public static Dictionary<int, string> AddCountryToExistingDictionary(Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            existingDictionary.Add(countryCode, countryName);
            return existingDictionary;
        }

        public static string GetCountryNameFromDictionary(Dictionary<int, string> existingDictionary, int countryCode)
        {
            return existingDictionary.TryGetValue(countryCode, out string countryName) ? countryName : string.Empty;
        }

        public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
        {
            return existingDictionary.ContainsKey(countryCode);
        }

        public static Dictionary<int, string> UpdateDictionaryHasExistingNumber(Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            if (existingDictionary.ContainsKey(countryCode))
            {
                existingDictionary[countryCode] = countryName;
            }
            return existingDictionary;
        }

        public static Dictionary<int, string> RemoveCountryFromDictionary(Dictionary<int, string> existingDictionary, int countryCode)
        {
            existingDictionary.Remove(countryCode);
            return existingDictionary;
        }

        public static string GetLongestCountryName(Dictionary<int, string> existingDictionary)
        {
            string longest = string.Empty;
            foreach (var country in existingDictionary.Values)
            {
                if (country.Length > longest.Length)
                {
                    longest = country;
                }
            }
            return longest;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dict = DialingCodes.GetExistingDictionary();
            DialingCodes.AddCountryToExistingDictionary(dict, 809, "Dominican Republic");

            Console.WriteLine("--- International Calling Connoisseur ---");
            Console.WriteLine($"¿Existe el código 809?: {DialingCodes.CheckCodeExists(dict, 809)}");
            Console.WriteLine($"País para 809: {DialingCodes.GetCountryNameFromDictionary(dict, 809)}");
            Console.WriteLine($"Nombre de país más largo: {DialingCodes.GetLongestCountryName(dict)}");
        }
    }
}