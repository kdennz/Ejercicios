using System;

namespace Exercism
{
    class RemoteControlCar
    {
        public int Speed { get; }
        public int BatteryDrain { get; }
        private int _distanceDriven;
        private int _battery = 100;

        public RemoteControlCar(int speed, int batteryDrain)
        {
            Speed = speed;
            BatteryDrain = batteryDrain;
        }

        public bool BatteryDrained() => _battery < BatteryDrain;

        public int DistanceDriven() => _distanceDriven;

        public void Drive()
        {
            if (!BatteryDrained())
            {
                _distanceDriven += Speed;
                _battery -= BatteryDrain;
            }
        }

        public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
    }

    class RaceTrack
    {
        public int Distance { get; }

        public RaceTrack(int distance)
        {
            Distance = distance;
        }

        public bool TryFinishTrack(RemoteControlCar car)
        {
            while (!car.BatteryDrained() && car.DistanceDriven() < Distance)
            {
                car.Drive();
            }
            return car.DistanceDriven() >= Distance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var car = new RemoteControlCar(5, 2);
            var track = new RaceTrack(100);

            Console.WriteLine("--- Need for Speed ---");
            Console.WriteLine($"¿Termina la carrera?: {track.TryFinishTrack(car)}");
        }
    }
}