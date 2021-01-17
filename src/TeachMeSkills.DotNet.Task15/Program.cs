using System;
using System.Linq;

namespace TeachMeSkills.DotNet.Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[50];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 9000);
            }


            var maxValue = array.Max();
            var minValue = array.Min();
            var sumOfElements = array.Aggregate((a, b) => a + b);
            var averageElements = array.Average();
            var even = array.Where((a, b) => a % 2 == 0);

            Console.WriteLine($"Max value: {maxValue}");
            Console.WriteLine($"Min value: {minValue}");
            Console.WriteLine($"Sum value: {sumOfElements}");
            Console.WriteLine($"Average value: {averageElements}\n");
            foreach (var item in even)
            {
                Console.WriteLine($"Even value: {item}");
            }
        }
    }
}
