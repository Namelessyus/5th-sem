using System;

namespace Chapter_Three
{
    public static class StaticClassExample
    {
        //You can only have static members and methods in a static class.
        //You cannot create an object with static class.
        //You can directly call the method using the class name.
        public static int Square(int number)
        {
            return number * number;
        }
    }
    internal class StaticClass
    {
        public static void Main(string[] args)
        {
            int result = StaticClassExample.Square(20);
            Console.WriteLine(result);
        }
    }
}