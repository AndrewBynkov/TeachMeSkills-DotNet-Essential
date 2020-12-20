using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task8
{
    public class User
    {
        public User(DateTime dateNow)
        {
            _date = dateNow;
        }

        public string Login { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public readonly DateTime _date;


        public void GetInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("User Info");
            Console.ResetColor();
            Console.WriteLine($"login - {Login}");
            Console.WriteLine($"FirstName - {FirstName}");
            Console.WriteLine($"SecondName - {SecondName}");
            Console.WriteLine($"Date - {_date}");
        }
    }
}
