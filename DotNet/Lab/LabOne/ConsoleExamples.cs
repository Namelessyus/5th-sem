using System;

namespace LabOne
{
    class ConsoleExamples
    {
        static void Main(string[] args)
        {
            //Write a program to demonstrate the difference between Console.ReadLine(), Console.Read(),
            //Console.Write() and Console.WriteLine() in C#.
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Your name is: " + name);

            Console.Write("Enter your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your age is: " + age);

            Console.Write("Enter any character: ");
            int character = Console.Read();

            Console.WriteLine("Your 1st Character is: " + (char)character);

            Console.ReadLine();
        }
    }
}