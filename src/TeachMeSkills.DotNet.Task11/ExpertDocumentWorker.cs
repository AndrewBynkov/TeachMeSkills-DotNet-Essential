using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task11
{
    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document saved in new format");
        }
    }
}
