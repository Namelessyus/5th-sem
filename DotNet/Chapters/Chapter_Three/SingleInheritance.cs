using System;

namespace Chapter_Three
{
    class Vehicle
    {
        public int speed { get; set; }

        public void Start()
        {
            Console.WriteLine("Vehicle Started");
        }
    }

    class Car : Vehicle
    {
        public string Model { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Driving the {Model} at {speed} km/h");
        }
    }

    internal class SingleInheritance
    {
        static void Main(string[] args)
        {
            Car c = new Car();

            c.speed = 80;
            c.Model = "Toyota";

            c.Start();   
            c.Drive();   
        }
    }
}