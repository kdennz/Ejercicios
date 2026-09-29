using System;

namespace Exercism
{
    static class QuestLogic
    {
        // 1. Un ataque rápido solo es posible si el caballero está dormido
        public static bool CanFastAttack(bool knightIsAwake)
        {
            return !knightIsAwake;
        }

        // 2. Se puede espiar si al menos uno de los tres personajes está despierto
        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        {
            return knightIsAwake || archerIsAwake || prisonerIsAwake;
        }

        // 3. Se puede enviar señal al prisionero si está despierto y el arquero dormido
        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
        {
            return prisonerIsAwake && !archerIsAwake;
        }

        // 4. Lógica para liberar al prisionero según la presencia del perro y el estado de los guardias
        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        {
            return (petDogIsPresent && !archerIsAwake) || (!petDogIsPresent && prisonerIsAwake && !knightIsAwake && !archerIsAwake);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Escenario de prueba:
            bool knightIsAwake = false;
            bool archerIsAwake = true;
            bool prisonerIsAwake = false;
            bool petDogIsPresent = false;

            Console.WriteLine("--- Pruebas de QuestLogic ---");
            Console.WriteLine($"¿Puede hacer ataque rápido?: {QuestLogic.CanFastAttack(knightIsAwake)}");
            Console.WriteLine($"¿Puede espiar?: {QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake)}");
            Console.WriteLine($"¿Puede hacer señal al prisionero?: {QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake)}");
            Console.WriteLine($"¿Puede liberar al prisionero?: {QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent)}");
        }
    }
}