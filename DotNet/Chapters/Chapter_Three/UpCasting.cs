using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_Three
{
    public class BaseAnimalClass
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    public class DerivedDogClass: BaseAnimalClass
    {
        public void Run()
        {
            Console.WriteLine("Running...");
        }
    }
    internal class UpCasting
    {
        static void Main(string[] args)
        {
            DerivedDogClass dog = new DerivedDogClass();
            dog.Eat();
            dog.Run();
            BaseAnimalClass animal = dog;
            animal.Eat();
        }
    }
}
