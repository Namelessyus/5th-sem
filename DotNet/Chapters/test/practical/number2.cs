using System;

class Student
{
    public int StudentID;
    public string? Name;
    public int Marks1;
    public int Marks2;
    public int Marks3;

    public int CalculateTotal()
    {
        return Marks1 + Marks2 + Marks3;
    }

    public double CalculateAverage()
    {
        return CalculateTotal() / 3.0;
    }

    public string CalculateGrade()
    {
        double avg = CalculateAverage();

        if (Marks1 >= 40 && Marks2 >= 40 && Marks3 >= 40)
        {
            if (avg >= 80)
                return "A";
            else if (avg >= 60)
                return "B";
            else if (avg >= 50)
                return "C";
            else if (avg >= 40)
                return "D";
        }

        return "Fail";
    }
}

class number2
{
    static void Main(string[] args)
    {
        Student s = new Student();

        Console.Write("Enter Student ID: ");
        s.StudentID = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        s.Name = Console.ReadLine();

        Console.Write("Enter Marks in Subject 1: ");
        s.Marks1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Marks in Subject 2: ");
        s.Marks2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Marks in Subject 3: ");
        s.Marks3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Student ID: " + s.StudentID);
        Console.WriteLine("Student Name: " + s.Name);
        Console.WriteLine("Total Marks: " + s.CalculateTotal());
        Console.WriteLine("Average: " + s.CalculateAverage());
        Console.WriteLine("Grade: " + s.CalculateGrade());
    }
}