using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractHomeWork1504
{
    class Circle : Figure
    {
        public const double PI = 3.14;

        public Circle(double radius)            
        {
            this.Radius = radius;            
        }

        public double Radius { get; set; }        

        public double Perimeter()
        {
            return Radius * 2 * PI;
        }

        public double Area()
        {
            return Radius * Radius;
        }
    }
}
