using System;

namespace TeachMeSkills.DotNet.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1;
            bool canParse;
            do
            {
                Console.Write("Enter side1: ");
                canParse = double.TryParse(Console.ReadLine(), out double val1);
                side1 = val1;
            }
            while (!canParse);

            double side2;
            do
            {
                Console.Write("Enter side2: ");
                canParse = double.TryParse(Console.ReadLine(), out double val1);
                side2 = val1;
            }
            while (!canParse);

            var rectangle = new Rectangle(side1, side2);
            rectangle.GetValue();
            Console.WriteLine($"Area figure - {rectangle.Area}");
            Console.WriteLine($"Perimetr figure - {rectangle.Perimeter}");
        }
    }
}
