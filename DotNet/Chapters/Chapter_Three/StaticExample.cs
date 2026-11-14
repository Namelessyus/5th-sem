//using System;

//namespace Chapter_Three
//{
//    internal class StaticExample
//    {
//        public string name = "Anushma Shakya";
//    }

//    class Static
//    {
//        public static void Main()
//        {
//            StaticExample obj = new StaticExample(); // creating object
//            Console.WriteLine(obj.name); // printing it

//        }
//    }
//}


//using System;

//namespace Chapter_Three
//{
//    internal class StaticExample
//    {
//        public static string name = "Anushma Shakya";
//    }

//    class Static
//    {
//        public static void Main()
//        {
//            Console.WriteLine($"Name: {StaticExample.name}");
//        }
//    }
//}


using System;

namespace Chapter_Three
{
    internal class StaticExample
    {
        public int Count = 0;

        public StaticExample()
        {
            Count++; 
        }
    }

    class Static
    {
        public static void Main()
        {
            StaticExample obj1 = new StaticExample();
            StaticExample obj2 = new StaticExample();
            StaticExample obj3 = new StaticExample();
            StaticExample obj4 = new StaticExample();
            StaticExample obj5 = new StaticExample();

            Console.WriteLine($"Count: {obj5.Count}");
        }
    }
}

