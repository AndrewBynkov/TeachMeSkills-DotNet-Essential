using System;

namespace TeachMeSkills.DotNet.Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            Printer test1 = new TestColor1();
            Printer test2 = new TestColor2();

            printer.Print("Andrew");
            test1.Print("Andrew");
            test2.Print("Andrew");
        }
    }
}
