using System;

namespace Chapter_Two
{
    internal class IfStatement
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to compare:");
            string value = Console.ReadLine() ?? "";
            int x = Convert.ToInt32(value);

            if (x > 6)
            {
                Console.WriteLine("X is greater than 6");
            }
            else if (x>6 && x<12)
            {
                Console.WriteLine("x is between 6 and 12");
            }
            else
            {
                Console.WriteLine("X is less than 6");
            }
        }
    }
}
