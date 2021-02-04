using System;

namespace TeachMeSkills.DotNet.Task26
{
    class Program
    {
        delegate int Operation(int x, int y);

        static void Main(string[] args)
        {

            Operation Add = (x, y) => x + y;
            Operation Minus = (x, y) => x - y;
            Operation Multiplicate = (x, y) => x * y;
            
            Operation Devided = (x, y) => x / y;

            Console.WriteLine(Add(10, 20));
            Console.WriteLine(Minus(10, 20));
            Console.WriteLine(Multiplicate(10, 20));
            Console.WriteLine(Devided(10, 20));

            Console.Read();
        }

    }
}

