﻿using System;

namespace AbstractHomeWork1504
{
    
    public class Program
    {        
        public static void Main(string[] args)
        {
            Console.WriteLine("Please entered values for rectangles height and width");
            Rectangle rectangle = new Rectangle(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Please entered values for circles radius");
            Circle circle = new Circle(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Please entered values for squares side");
            Square square = new Square(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Rectangle area is: " + rectangle.Area());
            Console.WriteLine("Circle area is: " + circle.Area());
            Console.WriteLine("Square area is: " + square.Area());

            Console.WriteLine("Rectangle perimeter is: " + rectangle.Perimeter());
            Console.WriteLine("Circle perimeter is: " + circle.Perimeter());
            Console.WriteLine("Square perimeter is: " + square.Perimeter());
        }
    }
}
