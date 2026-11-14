using System;

namespace Chapter_Two
{
    class DataType
    {
        static void Main(string[] args)
        {
            int myNum = 5;
            double myDoubleNum = 5.99D;
            char myChar= 'A';
            string name = "Anu";
            bool myBool = true;
            long myLongNum = 15000000000L;
            float myFloatNum = 5.75F;

            //scientific notation
            double mySciNum = 35E3; // 35 x 10^3
            double mySciNum2 = 12E-4; // 12 x 10^-4

            //constant
            const int ConstNum = 10;

            Console.WriteLine("Integer: " + myNum); 
            Console.WriteLine("Double: " + myDoubleNum);
            Console.WriteLine("Character: " + myChar);
            Console.WriteLine("String: " + name);
            Console.WriteLine("Boolean: " + myBool);
            Console.WriteLine("Long: " + myLongNum);   
            Console.WriteLine("Float: " + myFloatNum);  
            Console.WriteLine("Scientific Notation 1: " + mySciNum);
            Console.WriteLine("Scientific Notation 2: " + mySciNum2);
            Console.WriteLine("Constant: " + ConstNum);

        }
    }
}