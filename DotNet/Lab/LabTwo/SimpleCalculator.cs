//Simple Calculator using do while loop

using System;

namespace LabTwo
{
    internal class SimpleCalculator
    {
        static void Main(string[] args)
        {
            string input = "y";
            do
            {
                Console.Write("Enter your first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter your second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Select an Operation:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Result:" + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Result:" + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Result:" + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("Result:" + (num1 / num2));
                        break;
                    case 5:
                        Console.WriteLine("Bye Bye");
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                Console.WriteLine("Do you want to continue? y/n: ");
                input = Console.ReadLine();
            } while (input == "y");
            Console.WriteLine("Bye Bye");
        }
    }
}