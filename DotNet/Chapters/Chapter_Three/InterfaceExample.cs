using System;

namespace InterfaceExample
{
    interface IAnimal
    {
        void Speak();
    }

    class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Dog says WOOF WOOF");
        }
    }

    class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Cat says MEOW MEOW");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal dog = new Dog();
            IAnimal cat = new Cat();

            dog.Speak();
            cat.Speak();
        }
    }
}