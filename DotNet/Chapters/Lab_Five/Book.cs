using System;
using System.Collections.Generic;
using System.Text;

//Lab 5 pt2

namespace Lab_Report1
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
    class Constructor
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
