using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task11
{
    public class DocumentWorker
    {
        //OpenDocument(), EditDocument(), SaveDocument()

        public void OpenDocument()
        {
            Console.WriteLine("Document is open");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Edit document available in pro version");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Save document available in pro version");
        }
    }
}
