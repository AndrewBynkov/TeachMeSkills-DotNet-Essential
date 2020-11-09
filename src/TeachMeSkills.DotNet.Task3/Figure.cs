using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TeachMeSkills.DotNet.Task3
{
    class Figure
    {
        public Figure(Point point1, Point point2, Point point3)
        {
            _lenght1 = point1.MyProperty1 + point1.MyProperty2;
            _lenght2 = point2.MyProperty1 + point2.MyProperty2;
            _lenght3 = point3.MyProperty1 + point3.MyProperty2;
        }

        private int _lenght1;
        private int _lenght2;
        private int _lenght3;

        public void PerimeterCalculator(Point point)
        {
            var lenghtSide = new List<double>()
            {
                _lenght1,
                _lenght2,
                _lenght3
            };

            var perimetrFigure = lenghtSide.Aggregate((count, next) => count + next);

            Console.WriteLine($"Perimetr {point.MyProperty3} - {perimetrFigure}");
        }
    }
}
