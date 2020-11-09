using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task3
{
    public class Point
    {
        public Point(int point1, int point2, string result)
        {
            _point1 = point1;
            _point2 = point2;
            _result = result;

            MyProperty1 = _point1;
            MyProperty2 = _point2;
            MyProperty3 = _result;
        }

        private int _point1;

        private int _point2;

        private string _result;

        public int MyProperty1 { get; }

        public int MyProperty2 { get; }

        public string MyProperty3 { get; }
    }
}
