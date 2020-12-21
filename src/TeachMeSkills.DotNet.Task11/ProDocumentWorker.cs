using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task11
{
    public class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document is edit");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("The document is saved in the old format, saving in other formats is available in the Expert version");
        }
    }
}
