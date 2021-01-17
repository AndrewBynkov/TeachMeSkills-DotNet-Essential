using System;

namespace TeachMeSkills.DotNet.Task10
{
    public class Plane : Vehicle
    {
        public int HeightPassanger { get; set; }

        public int QualityPassanger { get; set; }

        public void GetPlaneInfo()
        {
            _price = new Random().NextDouble() * (1000000.00 - 0.00) + 0.00;
            _speed = new Random().NextDouble() * (120 - 0.00) + 0.00;
            _year = new DateTime().AddYears(2015);

            HeightPassanger = new Random().Next(120,250);
            QualityPassanger = new Random().Next(90);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Plane");
            Console.WriteLine($"Price - {Math.Round(_price, 2)}$\n" +
                $"Speed - {Math.Round(_speed, 2)}km/h\n" +
                $"Year - {_year}\n" +
                $"Height Passanger - {HeightPassanger}\n" +
                $"Quality Passanger - {QualityPassanger}\n");
            Console.ResetColor();
        }
    }
}
