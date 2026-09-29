using System;

// Definición de Namespaces para evitar conflictos de nombres
namespace RedRemoteControlCarTeam
{
    public class RemoteControlCar
    {
        public string Color => "Red";
    }
}

namespace BlueRemoteControlCarTeam
{
    public class RemoteControlCar
    {
        public string Color => "Blue";
    }
}

namespace Exercism
{
    class Program
    {
        static void Main(string[] args)
        {
            var redCar = new RedRemoteControlCarTeam.RemoteControlCar();
            var blueCar = new BlueRemoteControlCarTeam.RemoteControlCar();

            Console.WriteLine("--- Red vs. Blue: Darwin Style ---");
            Console.WriteLine($"Auto 1: {redCar.Color}");
            Console.WriteLine($"Auto 2: {blueCar.Color}");
        }
    }
}