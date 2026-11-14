using System;
interface IShape
{
    void CalculateArea();
}

class Rectangle : IShape
{
    double length, breadth;
    public Rectangle(double l, double b)
    {
        length = l;
        breadth = b;
    }

    public void CalculateArea()
    {
        double area = length * breadth;
        Console.WriteLine("Area of Rectangle = " + area);
    }
}

class Circle : IShape
{
    double radius;
    public Circle(double r)
    {
        radius = r;
    }
    public void CalculateArea()
    {
        double area = 3.14 * radius * radius;
        Console.WriteLine("Area of Circle = " + area);
    }
}

class number3
{
    static void Main(string[] args)
    {
        Console.Write("Enter length of rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter breadth of rectangle: ");
        double breadth = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter radius of circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        IShape rectangle = new Rectangle(length, breadth);
        IShape circle = new Circle(radius);

        rectangle.CalculateArea();
        circle.CalculateArea();
    }
}