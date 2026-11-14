using System;

namespace Chapter_Three
{
    // Parent class
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }
    // Child class (inherits Animal)
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }
    class InheritanceExample
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();

            d.Eat();
            d.Bark(); 
        }
    }
}