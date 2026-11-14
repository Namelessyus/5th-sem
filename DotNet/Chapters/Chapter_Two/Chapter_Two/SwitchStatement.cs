using System;

namespace Chapter_Two
{
    class SwitchStatement
    {
        static void Main()
        {
            string input = "C#";

            switch (input)
            {
                case "C#":
                    Console.WriteLine("It is a programming language");
                    break;

                case "Java":
                    Console.WriteLine("It is a programming language");
                    break;

                case "C":
                    Console.WriteLine("It is a programming language");
                    break;

                default:
                    Console.WriteLine("Invalid Programming language");
                    break;
            }
        }
    }
}
