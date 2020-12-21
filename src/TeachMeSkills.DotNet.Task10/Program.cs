using System;

namespace TeachMeSkills.DotNet.Task10
{
    internal class Program
    {
        private static Object syncObject = new Object();

        static void Main(string[] args)
        {
            var plane = new Plane();
            var car = new Car();
            var ship = new Ship();
            plane.GetPlaneInfo();
            car.GetCarInfo();
            ship.GetInfoShip();
        }
    }
}
