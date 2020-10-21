using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task1
{
    class Rectangle
    {
        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }

        /// <summary>
        /// Area figure
        /// </summary>
        public double Area { get; set; }

        /// <summary>
        /// Perimetr figure
        /// </summary>
        public double Perimeter { get; set; }

        /// <summary>
        /// figure side1
        /// </summary>
        double _side1;

        /// <summary>
        /// figure side2
        /// </summary>
        double _side2;

        public double AreaCalculator() => _side1 * _side2;

        double PerimeterCalculator() => (_side1 * 2) + (_side2 * 2);

        public void GetValue()
        {
            Area = AreaCalculator();
            Perimeter = PerimeterCalculator();
        }
    }
}
