using System;

//Lab 5

namespace Lab_Report5
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
