using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task2
{
    public class Content
    {
        public string BookContent { get; set; }

        public void GetBookContent()
        {
            Console.Write("Enter book content: ");
            BookContent = Console.ReadLine();
        }
    }
}
