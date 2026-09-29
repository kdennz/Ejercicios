using System;
using System.Text;

namespace Exercism
{
    public static class Identifier
    {
        public static string Clean(string identifier)
        {
            var sb = new StringBuilder();
            bool isAfterHyphen = false;

            foreach (char c in identifier)
            {
                if (c == ' ')
                {
                    sb.Append('_');
                }
                else if (char.IsControl(c))
                {
                    sb.Append("CTRL");
                }
                else if (c == '-')
                {
                    isAfterHyphen = true;
                }
                else if (isAfterHyphen)
                {
                    sb.Append(char.ToUpper(c));
                    isAfterHyphen = false;
                }
                else if (char.IsLetter(c) && !(c >= 'α' && c <= 'ω'))
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Squeaky Clean ---");
            Console.WriteLine(Identifier.Clean("my   name")); // my___name
            Console.WriteLine(Identifier.Clean("a-bc"));    // aBc
            Console.WriteLine(Identifier.Clean("a$b#c"));   // abc
        }
    }
}