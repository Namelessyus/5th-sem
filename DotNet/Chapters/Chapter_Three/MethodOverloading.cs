using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_Three
{

    class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
    class MethodOverloading
    {
        static void Main()
        {
            MathOperations obj = new MathOperations();
            obj.Add(5, 8);
            obj.Add(5, 9, 6);
            obj.Add(5.43, 4.342);
        }

    }
}