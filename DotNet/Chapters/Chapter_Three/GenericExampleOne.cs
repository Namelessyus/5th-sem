using System;


namespace Chapter_Three
{
    public class Utility
    {
        public static void Print<T>(T value)
        {
            Console.WriteLine(value);
        }
    }
    class GenericExampleOne
    {
        static void Main()
        {
            Utility.Print(42);
            Utility.Print(9.99);
            Utility.Print("Hello, World!");
        }
    }
}