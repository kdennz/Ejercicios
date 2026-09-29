using System;

namespace Exercism
{
    public static class SimpleCalculator
    {
        public static string Calculate(int operand1, int operand2, string operation)
        {
            if (operation == null)
            {
                throw new ArgumentNullException(nameof(operation), "La operación no puede ser nula.");
            }

            if (operation == "")
            {
                throw new ArgumentException("La operación no puede estar vacía.", nameof(operation));
            }

            try
            {
                int result = operation switch
                {
                    "+" => operand1 + operand2,
                    "*" => operand1 * operand2,
                    "/" => operand1 / operand2,
                    _ => throw new ArgumentOutOfRangeException(nameof(operation), "Operación no soportada.")
                };

                return $"{operand1} {operation} {operand2} = {result}";
            }
            catch (DivideByZeroException)
            {
                return "Division by zero is not allowed.";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Calculator Conundrum ---");
            Console.WriteLine(SimpleCalculator.Calculate(10, 2, "+"));
            Console.WriteLine(SimpleCalculator.Calculate(10, 0, "/"));
        }
    }
}