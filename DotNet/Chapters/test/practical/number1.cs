using System;
using System.Collections.Generic;
using System.Linq;

class number1
{
    static void Main()
    {
        List<decimal> numbers = new List<decimal>
        {
            20, 45, 52, 60, 75, 80, 90, 33, 100, 55
        };

        var result = from num in numbers
                     where num > 50 && num % 2 == 0
                     select num;

        if (result.Any())
        {
            decimal average = result.Average();
            Console.WriteLine("Numbers greater than 50 and even:");
            foreach (decimal num in result)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Average = " + average);
        }
        else
        {
            Console.WriteLine("No matching numbers found.");
        }
    }
}