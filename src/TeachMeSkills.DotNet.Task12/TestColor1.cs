using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task12
{
    public class TestColor1 : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
