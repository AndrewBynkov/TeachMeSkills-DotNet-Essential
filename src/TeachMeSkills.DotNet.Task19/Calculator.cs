using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task19
{
    public static class Calculator
    {
        public static decimal Plus(this decimal num1, decimal num2) => num1 + num2;
        public static decimal Minus(this decimal num1, decimal num2) => num1 - num2;
        public static decimal Devided(this decimal num1, decimal num2) => num1 / num2;
        public static decimal Multiplicate(this decimal num1, decimal num2) => num1 * num2;
    }
}
