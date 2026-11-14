using System;


namespace LabThree
{
    class Book
    {
        public String name;
        public Book()
        {
            name = "three body problem";
            Console.WriteLine($"Book name:{this.name}");
        }

    }
    internal class DefaultConstructor
    {
        static void Main()
        {
            Book bookObj = new Book();
            Console.WriteLine($"Book : {bookObj.name}");
        }


    }
}