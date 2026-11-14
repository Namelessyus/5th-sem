using System;

namespace Chapter_Three
{
    class StaticExampleClass
    {
        static int count = 1;
        static StaticExampleClass()
        {

            Console.WriteLine("Static constructor called. Value of count:" + count);
            count++;
        }
    }

    class StaticConstructor
    {
        static void Main()
        {
            StaticExampleClass obj1 = new StaticExampleClass();
            StaticExampleClass obj2 = new StaticExampleClass();
            StaticExampleClass obj3 = new StaticExampleClass();
            StaticExampleClass obj4 = new StaticExampleClass();
        }
    }
}