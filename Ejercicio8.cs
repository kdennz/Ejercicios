using System;
using System.Collections.Generic;

namespace Exercism
{
    public static class Languages
    {
        public static List<string> NewList() => new List<string>();

        public static List<string> GetExistingLanguages() => new List<string> { "C#", "Clojure", "Elixir" };

        public static List<string> AddLanguage(List<string> languages, string language)
        {
            languages.Add(language);
            return languages;
        }

        public static int CountLanguages(List<string> languages) => languages.Count;

        public static bool HasLanguage(List<string> languages, string language) => languages.Contains(language);

        public static List<string> ReverseList(List<string> languages)
        {
            languages.Reverse();
            return languages;
        }

        public static bool IsExciting(List<string> languages)
        {
            if (languages.Count == 0) return false;
            if (languages[0] == "C#") return true;
            if ((languages.Count == 2 || languages.Count == 3) && languages[1] == "C#") return true;

            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var langs = Languages.GetExistingLanguages();
            Languages.AddLanguage(langs, "Python");

            Console.WriteLine("--- Tracks on Tracks on Tracks ---");
            Console.WriteLine($"Total lenguajes: {Languages.CountLanguages(langs)}");
            Console.WriteLine($"¿Tiene C#?: {Languages.HasLanguage(langs, "C#")}");
            Console.WriteLine($"¿Es emocionante?: {Languages.IsExciting(langs)}");
        }
    }
}