using System;

namespace Chapter_Three
{
    public class Person
    {
        public string name;
        public int age;
        public string nationality;

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");
        }

        public void Nationality()
        {
            Console.WriteLine($"I am {nationality}.");
        }
    }
    internal class ClassExamples
    {
        static void Main() 
        { 
            Person person1 = new Person();
            person1.name = "Anu";
            person1.age = 20;
            person1.nationality = "Nepali";
            person1.Introduce();
            person1.Nationality();

            Person person2 = new Person();
            person2.name = "peanut";
            person2.age = 20;
            person2.nationality = "Indian";
            person2.Introduce();
            person2.Nationality();
        }
    }
}
