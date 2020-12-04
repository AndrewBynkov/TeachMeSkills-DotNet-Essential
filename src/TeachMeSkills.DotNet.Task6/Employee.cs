using System;
using System.Collections.Generic;
using System.Linq;

namespace TeachMeSkills.DotNet.Task6
{
    public class Employee
    {
        public Employee(string inputFirstName, string inputLastName)
        {
            _firstName = inputFirstName;
            _lastName = inputLastName;
        }

        private string _firstName;

        private string _lastName;

        private string _position;

        private double _salary;

        private List<string> enumsPositions = new List<string>()
        {
            nameof(MyEnums.Positions.Accountant),
            nameof(MyEnums.Positions.Cleener),
            nameof(MyEnums.Positions.Director),
            nameof(MyEnums.Positions.Manager),
        };


        public void GetSalaryAndEmployerInfo()
        {
            _position = enumsPositions.ElementAt(new Random().Next(enumsPositions.Count()));

            if (_position == nameof(MyEnums.Positions.Accountant))
            {
                _salary = 968.4 * 1.2 + 200;
                _position = nameof(MyEnums.Positions.Accountant);
            }

            if (_position == nameof(MyEnums.Positions.Cleener))
            {
                _salary = 968.4 * 1.2 + 50;
                _position = nameof(MyEnums.Positions.Cleener);
            }

            if (_position == nameof(MyEnums.Positions.Director))
            {
                _salary = 968.4 * 1.2 + 1200;
                _position = nameof(MyEnums.Positions.Director);
            }

            if (_position == nameof(MyEnums.Positions.Manager))
            {
                _salary = 968.4 * 1.2 + 532;
                _position = nameof(MyEnums.Positions.Manager);
            }

            Console.WriteLine($"\nFirst name: {_firstName}" +
                $"\nLast name: {_lastName}" +
                $"\nPosition: {_position}" +
                $"\nSalary: {_salary}");
        }
    }
}
