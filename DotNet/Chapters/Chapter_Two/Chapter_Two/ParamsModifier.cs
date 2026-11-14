using System;

namespace Chapter_Two
{
    internal class ParamsModifier
    {
        static int sum (params int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            return total;
        }
        static void Main()
        {
            Console.WriteLine(sum(1,2,3));
            Console.WriteLine(sum(1,2,3,4,5));
        }
    }
}
