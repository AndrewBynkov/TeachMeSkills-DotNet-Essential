using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task13
{
    public class DOCHandler: AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open DOC file.");
        }

        public override void Create()
        {
            Console.WriteLine("Create DOC file.");
        }

        public override void Chenge()
        {
            Console.WriteLine("Change DOC file.");
        }

        public override void Save()
        {
            Console.WriteLine("Save DOC format.");
        }

    }
}
