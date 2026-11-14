//using System;

//namespace Chapter_Two
//{
//    internal class ForLoopRightTriangle
//    {
//        static void Main()
//        {
//            int number = 5;

//            for (int i = 1; i <= number; i++)
//            {
//                for (int j = 1; j <= i; j++)
//                {
//                    Console.Write("* ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}

//flip
using System;

namespace Chapter_Two
{
    internal class ForLoopRightTriangle
    {
        static void Main()
        {
            int number = 5;

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
