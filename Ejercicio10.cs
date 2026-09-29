using System;

namespace Exercism
{
    abstract class Character
    {
        private string characterType;

        protected Character(string characterType)
        {
            this.characterType = characterType;
        }

        public abstract int DamagePoints(Character target);

        public virtual bool Vulnerable() => false;

        public override string ToString() => $"Character: {characterType}";
    }

    class Warrior : Character
    {
        public Warrior() : base("Warrior") { }

        public override int DamagePoints(Character target)
        {
            return target.Vulnerable() ? 10 : 6;
        }
    }

    class Wizard : Character
    {
        private bool spellPrepared = false;

        public Wizard() : base("Wizard") { }

        public override bool Vulnerable() => !spellPrepared;

        public override int DamagePoints(Character target)
        {
            return spellPrepared ? 12 : 3;
        }

        public void PrepareSpell()
        {
            spellPrepared = true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var warrior = new Warrior();
            var wizard = new Wizard();

            Console.WriteLine("--- Wizards and Warriors ---");
            Console.WriteLine(warrior.ToString());
            Console.WriteLine($"¿Mago vulnerable inicialmente?: {wizard.Vulnerable()}");
            Console.WriteLine($"Daño del Guerrero al Mago (vulnerable): {warrior.DamagePoints(wizard)} pts");

            wizard.PrepareSpell();
            Console.WriteLine($"¿Mago vulnerable tras preparar hechizo?: {wizard.Vulnerable()}");
            Console.WriteLine($"Daño del Mago (con hechizo) al Guerrero: {wizard.DamagePoints(warrior)} pts");
        }
    }
}