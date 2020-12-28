using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task13
{
    public class AbstractHandler
    {
        public virtual void Open()
        {
            Console.WriteLine("Open impossible. Unknown type");
        }

        public virtual void Create()
        {
            Console.WriteLine("Create impossible. Unknown type");
        }

        public virtual void Chenge()
        {
            Console.WriteLine("Chenge impossible. Unknown type");
        }

        public virtual void Save()
        {
            Console.WriteLine("Save impossible. Unknown type");
        }
    }
}
