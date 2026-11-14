using System;

namespace Chapter_Two
{
    class UserInputSwitchStatement
    {
        static void Main()
        {
            string input;

            Console.Write("Enter a programming language from options C#, Java, C: ");
            input = Console.ReadLine();

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