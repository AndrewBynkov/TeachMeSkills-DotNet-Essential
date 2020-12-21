using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task10
{
    public abstract class Vehicle
    {
        //(цена, скорость, год выпуска).

        protected double _price = 6.5;

        protected double _speed;

        protected DateTime _year;
    }
}
