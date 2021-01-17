using System;

namespace TeachMeSkills.DotNet.Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file format: ");
            var input = Console.ReadLine();

            var myFile = new AbstractHandler();

            if (input.Contains("TXT"))
            {
                 myFile = new TXTHandler();
            }
            else if (input.Contains("XML"))
            {
                 myFile = new XMLHandler();
            }
            else if (input.Contains("DOC"))
            {
                 myFile = new DOCHandler();
            }

            myFile.Open();
            myFile.Create();
            myFile.Chenge();
            myFile.Save();
        }
    }
}
