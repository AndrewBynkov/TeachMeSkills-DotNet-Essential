using System;

namespace TeachMeSkills.DotNet.Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"plus: {Calculator.Plus(14,15)}");
            Console.WriteLine($"minus: {Calculator.Minus(14,15)}");
            Console.WriteLine($"devided: {Calculator.Devided(14,15)}");
            Console.WriteLine($"Multiplicate: {Calculator.Multiplicate(14,15)}");
        }
    }
}
