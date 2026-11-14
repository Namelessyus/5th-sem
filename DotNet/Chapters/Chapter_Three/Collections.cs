using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_Three
{
    internal class Collections
    {
        static void Main()
        {
            // Fruit
            var fruits = new List<string> { "Apple", "Banana", "Cherry" };

            fruits.Add("Mango");
            fruits.Remove("Banana");

            foreach(var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Dictionary
            var ages = new Dictionary<string, int>();   

            ages.Add( "Nihal", 27);
            ages.Add( "Charlie", 35);
            ages.Add( "Bob", 25);

            Console.WriteLine(ages["Nihal"]);

           // Queue
            var queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            // Stack
            var stack = new Stack<string>();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");

            Console.WriteLine(stack.Pop());
        }
    }
}
