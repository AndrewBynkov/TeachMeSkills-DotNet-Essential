using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task13
{
    public class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open TXT file.");
        }

        public override void Create()
        {
            Console.WriteLine("Create TXT file.");
        }

        public override void Chenge()
        {
            Console.WriteLine("Change TXT file.");
        }

        public override void Save()
        {
            Console.WriteLine("Save TXT format.");
        }
    }
}
