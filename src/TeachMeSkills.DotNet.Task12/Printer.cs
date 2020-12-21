using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task12
{
    public class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
}
