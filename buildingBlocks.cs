using System;

namespace Exercism
{
    public class BuildingBlock<T>
    {
        public T Element { get; }

        public BuildingBlock(T element)
        {
            Element = element;
        }

        public T GetElement() => Element;

        public string GetElementType() => typeof(T).Name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var intBlock = new BuildingBlock<int>(42);
            var stringBlock = new BuildingBlock<string>("C# Generics");

            Console.WriteLine("--- Building Blocks ---");
            Console.WriteLine($"Bloque 1: {intBlock.GetElement()} (Tipo: {intBlock.GetElementType()})");
            Console.WriteLine($"Bloque 2: {stringBlock.GetElement()} (Tipo: {stringBlock.GetElementType()})");
        }
    }
}