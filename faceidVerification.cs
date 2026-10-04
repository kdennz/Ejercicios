using System;
using System.Collections.Generic;

namespace Exercism
{
    public readonly struct FacialFeatures : IEquatable<FacialFeatures>
    {
        public string EyeColor { get; }
        public string PhiltrumWidth { get; }

        public FacialFeatures(string eyeColor, string philtrumWidth)
        {
            EyeColor = eyeColor;
            PhiltrumWidth = philtrumWidth;
        }

        public bool Equals(FacialFeatures other) =>
            EyeColor == other.EyeColor && PhiltrumWidth == other.PhiltrumWidth;

        public override bool Equals(object obj) =>
            obj is FacialFeatures other && Equals(other);

        public override int GetHashCode() =>
            HashCode.Combine(EyeColor, PhiltrumWidth);
    }

    public class Authenticator
    {
        private readonly HashSet<FacialFeatures> _registeredFeatures = new HashSet<FacialFeatures>();

        public bool Register(FacialFeatures features) => _registeredFeatures.Add(features);

        public bool IsRegistered(FacialFeatures features) => _registeredFeatures.Contains(features);
    }

    class Program
    {
        static void Main(string[] args)
        {
            var auth = new Authenticator();
            var user1 = new FacialFeatures("blue", "medium");

            Console.WriteLine("--- Faceid Verification ---");
            Console.WriteLine($"¿Registro exitoso?: {auth.Register(user1)}");
            Console.WriteLine($"¿Usuario autenticado?: {auth.IsRegistered(user1)}");
        }
    }
}