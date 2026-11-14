//using System;
//using System.Runtime.ExceptionServices;

//namespace Chapter_Two
//{
//    class ForLoopExample
//    {
//        static void Main()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine($"Iteration: {i}");
//            }
//        }
//    }
//}



//user input version of the for loop example
//using System;
//using System.Runtime.ExceptionServices;

//namespace Chapter_Two
//{
//    class ForLoopExample
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter any number: ");
//            int number = Convert.ToInt32(Console.ReadLine());

//            for (int i = 0; i < number; i++)
//            {
//                Console.WriteLine($"Iteration: {i}");
//            }
//        }
//    }
//}


//using System;
//using System.Runtime.ExceptionServices;

//namespace Chapter_Two
//{
//    class ForLoopExample
//    {
//        static void Main()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine($"Iteration: {i}");
//            }
//            int number = 10;
//            int j = 1;
//            for (;j < number;)
//            {
//                Console.WriteLine("Hello, World");
//                j++;
//            }
//        }
//    }



//using System;

//namespace Chapter_Two
//{
//    class ForLoopExample
//    {
//        static void Main()
//        {
//            for (int i = 1; i < 5; i++)
//            {
//                Console.WriteLine($"Outer Loop: {i}");
//                Console.WriteLine("-------------------------------------");

//                for (int j = i; j <= 5; j++)
//                {
//                    Console.WriteLine($"Inner Loop: {j}");
//                }
//                Console.WriteLine("-------------------------------------");
//            }
//        }
//    }
//}



using System;

namespace Chapter_Two
{
    class ForLoopExample
    {
        static void Main()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Tata", "Toyota" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }
    }
}

