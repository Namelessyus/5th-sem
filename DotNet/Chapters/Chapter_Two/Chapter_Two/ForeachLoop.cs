//using System;

//namespace Chapter_Two
//{
//    class ForeachLoop
//    {
//        static void Main()
//        {
//            string[] cars = { "Volvo", "BMW", "Ford", "Tata", "Toyota" };
//            foreach (string car in cars)
//            {
//                Console.WriteLine(car);
//            }
//        }
//    }
//}



using System;

namespace Chapter_Two
{
    class ForeachLoop
    {
        static void Main()
        {
            int[] IntArray = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Input Array emelemts using foreach loop: ");
            foreach (int i in IntArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}

