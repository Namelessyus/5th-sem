//using System;

//namespace Chapter_Two
//{
//    class WhileLoopExample
//    {
//        static void Main()
//        {
//            string input = "";
//            Console.WriteLine("Enter text 'exit' to stop:");
//            while (input != "exit")
//            {
//                input = Console.ReadLine();
//                Console.WriteLine($"You have entered {input}");
//            }
//            Console.WriteLine("Program ended");
//        }
//    }

//}

using System;

namespace Chapter_Two
{
    class WhileLoopExample
    {
        static void Main()
        {
            int number;
            do
            {
                Console.WriteLine("Enter a positive number:");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number <= 0);
            Console.WriteLine($"You entered: {number}");
        }
    }
}
