using System;

namespace Chapter_Two
{
    internal class ReturnExample
    {
        static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        static float Sub(float a, float b)
        {
            float sub = a - b;
            return sub;
        }

        static void Main()
        {
            int x, y;
            x = 10;
            y = 20;
            int result = Add(x, y);
            Console.WriteLine($"Sum is {result}");
            Console.WriteLine();

             float x1, y1;
             x1 = 9.8f;
             y1 = 11.2f;
             float result1 = Sub(x, y);
             Console.WriteLine($"Sub is {result1}");
             Console.WriteLine();
            }
    }
}


        