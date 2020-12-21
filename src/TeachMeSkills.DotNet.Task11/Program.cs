using System;
using System.Collections.Generic;
using System.Linq;

namespace TeachMeSkills.DotNet.Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new DocumentWorker();

            List<string> passwordPRO = new List<string>()
            {
                "1146732aA",
                "AndyAndy",
                "JohanPohan"
            };

            List<string> passwordEXP = new List<string>()
            {
                "325427sS186",
                "1111"
            };

            Console.Write("Enter you liesence: ");
            var result = Console.ReadLine();

            if (passwordPRO.Contains(result))
            {
                account = new ProDocumentWorker();
            }

            if (passwordEXP.Contains(result))
            {
                account = new ExpertDocumentWorker();
            }

            if(!passwordEXP.Contains(result) && !passwordPRO.Contains(result))
            {
                account = new DocumentWorker();
            }

            account.OpenDocument();
            account.EditDocument();
            account.SaveDocument();
        }
    }
}
