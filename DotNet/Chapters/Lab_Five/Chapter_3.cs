using System;
using System.Collections.Generic;
using System.Text;

//Lab 7

namespace chapter_3
{
    interface interfaceone
    {
        void Walk();
    }

    class Overloading_method_one : interfaceone
    {
        public Overloading_method_one()
        {
            Console.WriteLine("This is an Empty Constructor");
        }

        public Overloading_method_one(string name)
        {
            Console.WriteLine("This is a constructor with one name " + name);
        }

        public Overloading_method_one(string name, int age)
        {
            Console.WriteLine("With age " + age + " Name: " + name);
        }

        public void Walk()
        {
            Console.WriteLine("A man is walking");
        }
    }

    internal class lab8
    {
        Overloading_method_one one = new Overloading_method_one("Anu", 20);
        Overloading_method_one two = new Overloading_method_one("Anushma");
    }
}