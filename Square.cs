using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractHomeWork1504
{
    public class Square : Figure
    {
        public Square(double side)
        {
            this.Side = side;
        }

        public double Side { get; set; }

        public double Perimeter()
        {
            return Side * 4;
        }

        public double Area()

        {
            return Side * Side;
        }
    }
}
