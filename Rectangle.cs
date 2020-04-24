using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractHomeWork1504
{
    class Rectangle : Figure
    {
        public Rectangle(double height, double width)
        {                                  
                this.Height = height;
                this.Width = width;            
        }
        public double Height { get; set; }

        public double Width { get; set; }

        public double Area()
        {
            return Height * Width;
        }

        public double Perimeter()
        {
            return 2 * (Height + Width);
        }
    }   
   
}
