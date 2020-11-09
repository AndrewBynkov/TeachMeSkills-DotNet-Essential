using System;
using System.Drawing;

namespace TeachMeSkills.DotNet.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(1, 2, "Rectangle");
            var point2 = new Point(11, 222, "Rectangle");
            var point3 = new Point(3, 4423, "Rectangle");

            var figure = new Figure(point, point2, point3);
            figure.PerimeterCalculator(point);
        }
    }
}
