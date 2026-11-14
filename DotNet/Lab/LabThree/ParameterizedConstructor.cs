using System;

namespace LabThree
{
    class Movie
    {
        public string name;
        public string genre;

        // Parameterized constructor
        public Movie(string name, string genre)
        {
            this.name = name;
            this.genre = genre;
        }

        public void PrintMovie()
        {
            Console.WriteLine($"Now showing: {this.name}");
            Console.WriteLine($"Genre: {this.genre}");
        }
    }

    class ParameterizedConstructor
    {
        static void Main()
        {
            Movie movie1 = new Movie("Blue", "Horror");
            movie1.PrintMovie();
        }
    }
}