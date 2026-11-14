using System;

namespace Chapter_Three
{
    class ChainExampleClass
    {
        public string name;
        public int age;
        public string address;
        public ChainExampleClass(string name, int age) : this(name, 20, "patan") //here
        {
            name = name;
            age = age;
            Console.WriteLine("Constructor with two parameter called \n Name:" + name + "\n And Age:" + age);
        }
        public ChainExampleClass(string name, int age, string address)
        {
            name = name;
            age = age;
            address = address;
            Console.WriteLine("Constructor with three parameter called \n Name:" + name + "\n And Age:" + age + "\n Address:" + address);


        }
        public ChainExampleClass(string name) : this(name, 20) //askes for name only and then sends it up
        {
            Console.WriteLine("Single parameter constructor called");
        }
    }

    internal class ChainExample
    {
        static void Main()
        {

            ChainExampleClass obj = new ChainExampleClass("anu");
        }
    }
}