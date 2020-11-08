using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task2
{
    public class Title
    {
        public string BookTitle { get; set; }

        public void GetBookTitle()
        {
            Console.Write("Enter BookTitle: ");
            BookTitle = Console.ReadLine();
        }
    }
}
