using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_Three
{
    interface IShape
    {
        public double CalculateArea();
    }

    class Circle : IShape
    {
        double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double CalculateArea()
        {
            return radius * radius * 3.14;
        }
    }
    internal class InterfaceQuestion 
    {
        static void Main()
        {
            IShape c1 = new Circle(10);
            double area = c1.CalculateArea();
            Console.WriteLine("The area of the circle is: " + area);
        }

    }
}