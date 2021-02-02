using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task23
{
    public enum ColorConsolePrint
    {
        Blue = 1,
        Green = 2,
        Cyan = 3,
        Red = 4
    }

    public static class StaticColor
    {
        public static void Print(string stroka, int color)
        {

            if (Enum.IsDefined(typeof(ColorConsolePrint), color))
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ColorConsolePrint), stroka);
                Console.WriteLine(Enum.Parse(typeof(ColorConsolePrint), stroka));
                Console.WriteLine();
                Console.ResetColor();
            }
        }
    }
}
