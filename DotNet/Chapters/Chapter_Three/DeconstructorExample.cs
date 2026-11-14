using System;

namespace Chapter_Three
{
    internal class DestructorExample
    {
        // Constructor
        public DestructorExample()
        {
            Console.WriteLine("Constructor called");
        }

        // Destructor
        ~DestructorExample()
        {
            Console.WriteLine("Destructor called");
        }
    }

    class Destructor
    {
        static void Main()
        {
            DestructorExample obj = new DestructorExample();
            Console.WriteLine("Doing something...");
        }
    }
}