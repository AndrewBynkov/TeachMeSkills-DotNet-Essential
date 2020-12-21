using System;

namespace TeachMeSkills.DotNet.Task10
{
    public class Car : Vehicle
    {
        public int HoursesPower { get; set; }

        public void GetCarInfo()
        {
            _price = new Random().NextDouble() * (1000000.00 - 0.00) + 0.00;
            _speed = new Random().NextDouble() * (120 - 0.00) + 0.00;
            _year = new DateTime().AddYears(new Random().Next(1984, 2018));
            HoursesPower = new Random().Next(0, 700);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Car");
            Console.WriteLine($"Price - {Math.Round(_price, 2)}$\n" +
                $"Speed - {Math.Round(_speed, 2)}km/h\n" +
                $"Year - {_year}\n" +
                $"Hourses Power - {HoursesPower}");
            Console.ResetColor();
        }
    }
}
