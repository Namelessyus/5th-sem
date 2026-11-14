using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_Three
{

    public enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }


    class EnumExample
    {
        static void Main()
        {
            Day today = Day.Wednesday;

            Console.WriteLine(today);
            Console.WriteLine((int)today);
            if (today == Day.Wednesday)
            {
                Console.WriteLine("It's hump day!");
            }

            switch (today)
            {
                case Day.Saturday:
                case Day.Sunday:
                    Console.WriteLine("Weekend!");
                    break;
                default:
                    Console.WriteLine("Weekday.");
                    break;
            }
        }
    }
}