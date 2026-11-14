using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_Three
{
    public class AnimalClass
    {
        public void Speak()
        {
            Console.WriteLine("Animal Speak...");
        }
    }

    public class DogClass : AnimalClass
    {
        public void Bark()
        {
            Console.WriteLine("Dog barks");
        }
    }

    internal class DownCasting
    {
        static void Main()
        {
            AnimalClass a = new DogClass();
            DogClass correctCast = a as DogClass;

            if (correctCast != null)
            {
                correctCast.Bark();
            }
            else
            {
                Console.WriteLine("Casting was not Successfull.");
            }
        }
    }
}