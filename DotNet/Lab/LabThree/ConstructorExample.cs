using System;

namespace LabThree
{
    class Animal
    {
        public string Name;

        // Constructor
        public Animal()
        {
            Console.WriteLine("Constructor called automatically");
        }

        public void CallAnimal()
        {
            Console.WriteLine($"Calling animal: {Name}");
        }
    }

    class ConstructorExample
    {
        static void Main()
        {
            Animal animalObj = new Animal();
            animalObj.Name = "Hippo";
            animalObj.CallAnimal();
        }
    }
}