using System;

namespace TeachMeSkills.DotNet.Task10

{
    public class Ship : Vehicle
    {
        public string Port { get; set; }

        public int QualityPassanger { get; set; }

        public void GetInfoShip()
        {
            _price = new Random().NextDouble() * (1000000.00 - 0.00) + 0.00;
            _speed = new Random().NextDouble() * (120 - 0.00) + 0.00;
            _year = new DateTime().AddYears(2015);

            Port = "Klaypeda";
            QualityPassanger = new Random().Next(90);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nShip");
            Console.WriteLine($"Price - {Math.Round(_price, 2)}$\n" +
                    $"Speed - {Math.Round(_speed, 2)}km/h\n" +
                    $"Year - {_year}\n" +
                    $"Port - {Port}\n" +
                    $"Quality Passanger - {QualityPassanger}\n");
            Console.ResetColor();
        }

    }
}
