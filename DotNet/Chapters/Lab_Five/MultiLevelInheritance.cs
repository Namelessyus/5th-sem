using System;
using System.Collections.Generic;
using System.Text;

//Lab 6

namespace Lab
{
    //MultiLevel Inheritance
    class Author
    {
        public string Name { get; set; }
        public string Book { get; set; }

        public void Read()
        {
            Console.WriteLine($"{Name}");
        }
    }
    class Reader : Author
    {
        public void ReadsBook()
        {
            Console.WriteLine($"{Name}");
        }

    }
    class Writer : Reader
    {
        public void Publish()
        {
            Console.WriteLine($"{Name}");
        }
        public void Review()
        {
            Console.WriteLine();
        }
    }
    class LabSix
    {
        public static void Main()
        {
            Writer w = new Writer();
            w.Name = "ABC";
            w.Book = "";
            w.Read();
            w.Review();
            w.Publish();
        }
    }
}