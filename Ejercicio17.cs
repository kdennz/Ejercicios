using System;

namespace Exercism
{
    public class WeighingMachine
    {
        public int Precision { get; }
        private double _weight;

        public WeighingMachine(int precision)
        {
            Precision = precision;
            TareAdjustment = 5.0;
        }

        public double Weight
        {
            get => _weight;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "El peso no puede ser negativo.");
                }
                _weight = value;
            }
        }

        public double TareAdjustment { get; set; }

        public string DisplayWeight
        {
            get
            {
                double adjustedWeight = Weight - TareAdjustment;
                return $"{adjustedWeight.ToString($"F{Precision}")} kg";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var machine = new WeighingMachine(2)
            {
                Weight = 60.55
            };

            Console.WriteLine("--- Weighing Machine ---");
            Console.WriteLine($"Precisión: {machine.Precision} decimales");
            Console.WriteLine($"Peso en pantalla (con tara de 5kg): {machine.DisplayWeight}");
        }
    }
}