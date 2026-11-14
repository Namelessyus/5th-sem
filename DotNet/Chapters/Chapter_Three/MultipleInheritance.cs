using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_Three
{
    interface IReader
    {
        void Read();
    }

    interface IWriter
    {
        void Write();
    }
    class FileHandler : IReader, IWriter
    {
        public void Read()
        {
            Console.WriteLine("Reading from file...");
        }
        public void Write()
        {
            Console.WriteLine("Writing to file...");
        }
    }
    internal class MultipleInheritance
    {
        static void Main()
        {
            FileHandler fileHandler = new FileHandler();
            fileHandler.Read();
            fileHandler.Write();
        }
    }
}
