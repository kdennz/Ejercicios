using System;

namespace Exercism
{
    static class GameMaster
    {
        public static string Describe(Character character)
        {
            return $"You're a level {character.Level} {character.Class} with {character.HitPoints} hit points.";
        }

        public static string Describe(Destination destination)
        {
            return $"You're traveling to {destination.Name}, which is inhabited by {destination.Inhabitants} {destination.InhabitantsName}.";
        }

        public static string Describe(TravelMethod travelMethod)
        {
            return travelMethod switch
            {
                TravelMethod.Walking => "You're traveling on foot.",
                TravelMethod.Horseback => "You're traveling on horseback.",
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        public static string Describe(Character character, Destination destination, TravelMethod travelMethod)
        {
            return $"{Describe(character)} {Describe(travelMethod)} {Describe(destination)}";
        }

        public static string Describe(Character character, Destination destination)
        {
            return $"{Describe(character)} {Describe(TravelMethod.Walking)} {Describe(destination)}";
        }
    }

    public class Character
    {
        public string Class { get; set; } = "Warrior";
        public int Level { get; set; } = 16;
        public int HitPoints { get; set; } = 89;
    }

    public class Destination
    {
        public string Name { get; set; } = "Tol Eressëa";
        public int Inhabitants { get; set; } = 500;
        public string InhabitantsName { get; set; } = "Elves";
    }

    public enum TravelMethod
    {
        Walking,
        Horseback
    }

    class Program
    {
        static void Main(string[] args)
        {
            var character = new Character();
            var destination = new Destination();

            Console.WriteLine("--- Wizards and Warriors 2.0 ---");
            Console.WriteLine(GameMaster.Describe(character, destination, TravelMethod.Horseback));
        }
    }
}