using System;

namespace Chapter_Three
{
    internal class IndexerClass
    {
        private string[] data = new string[10];
        private int count = 0;

        public string this[int index]
        {
            get { return data[index]; }
            set
            {
                data[index] = value;

                count = count + 1;
            }
        }

        public static void Main()
        {
            IndexerClass collection = new IndexerClass();

            collection[0] = "Hello";
            collection[1] = "World";
            collection[2] = "Anushma";
            collection[3] = "Shakya";


            for (int i = 0; i < collection.count; i++)
            {
                Console.WriteLine("Index " + i + ": " + collection[i]);
            }
        }
    }
}