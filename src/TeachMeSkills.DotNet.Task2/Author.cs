using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task2
{
    public class Author
    {
        public string NameAuthor { get; set; }

        public void GetNameAuthor()
        {
            Console.Write("Enter author name: ");
            NameAuthor = Console.ReadLine();
        }
    }
}
