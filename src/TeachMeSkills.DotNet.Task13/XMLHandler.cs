using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task13
{
    public class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open XML file.");
        }

        public override void Create()
        {
            Console.WriteLine("Create XML file.");
        }

        public override void Chenge()
        {
            Console.WriteLine("Change XML file.");
        }

        public override void Save()
        {
            Console.WriteLine("Save XML format.");
        }
    }
}
