using System;

namespace Lab_Report
{
    //default constructor
    class Food
    {
        public string name;
        public Food()
        {
            this.name = "Mushroom Pizza";
            Console.WriteLine($"Menu of the day:{this.name}");
        }
    }
    class LabFive
    {
        static void Main()
        {
            Food foodObj = new Food();

            Console.WriteLine($"Food:{foodObj.name}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Report
{
    //Parameterized constructor
    class Book
    {
        public string name;
        public string genre;

        public Book(string name, string genre)
        {
            this.name = name;
            this.genre = genre;
        }
        public void PrintBook()
        {
            Console.WriteLine($"Book name:{this.name}\t Book genre:{this.genre}");
        }
    }
    class Book
    {
        static void Main()
        {
            {
                Book movie = new Book("Beauty snd The Beast", "fantasy");
                movie.PrintBook();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Report
{

    class Lab_Report
    {
        private Lab_Report()
        {
            Console.WriteLine("Private Constructor called");

        }
        static void Main(string[] args)
        {
            Lab_Report obj = new LabFive3();
        }

    }
}