using System;

namespace Exercism
{
    public interface IRemoteControlCar
    {
        void Drive();
        int GetDistanceTraveled();
    }

    public class ProductionRemoteControlCar : IRemoteControlCar, IComparable<ProductionRemoteControlCar>
    {
        public int DistanceTraveled { get; private set; }
        public int NumberOfVictories { get; set; }

        public void Drive() => DistanceTraveled += 10;

        public int GetDistanceTraveled() => DistanceTraveled;

        public int CompareTo(ProductionRemoteControlCar other)
        {
            return this.NumberOfVictories.CompareTo(other.NumberOfVictories);
        }
    }

    public class ExperimentalRemoteControlCar : IRemoteControlCar
    {
        public int DistanceTraveled { get; private set; }

        public void Drive() => DistanceTraveled += 20;

        public int GetDistanceTraveled() => DistanceTraveled;
    }

    public static class TestTrack
    {
        public static void Race(IRemoteControlCar car) => car.Drive();
    }

    class Program
    {
        static void Main(string[] args)
        {
            var prodCar = new ProductionRemoteControlCar();
            var expCar = new ExperimentalRemoteControlCar();

            TestTrack.Race(prodCar);
            TestTrack.Race(expCar);

            Console.WriteLine("--- Remote Control Car Conundrum ---");
            Console.WriteLine($"Distancia Auto Producción: {prodCar.GetDistanceTraveled()}m");
            Console.WriteLine($"Distancia Auto Experimental: {expCar.GetDistanceTraveled()}m");
        }
    }
}