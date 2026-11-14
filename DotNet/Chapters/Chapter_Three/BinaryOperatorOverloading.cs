using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;

namespace Chapter_Three
{
    internal class BinaryOperatorOverloading
    {
        public static void Main()
        {
            Complex c1 = new Complex(2, 3);
            Console.WriteLine("Complex number c1: ");
            c1.ShowXY();

            Complex c2 = new Complex(4, 5);
            Console.WriteLine("Complex number c2: ");
            c2.ShowXY();

            Complex c3 = c1 + c2;
            Console.WriteLine("Complex number c3: ");
            c3.ShowXY();
        }
    }
    class Complex
    {
        private int x;
        private int y;

        public Complex () { }
        public Complex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void ShowXY()
        {
            Console.WriteLine($"X: {x}, Y: {y}");
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.x+c2.x, c1.y+c2.y);
        }
    }
}
