using System;

namespace Chapter_Three
{
    class Student
    {
        public int marks { get; set; }

        public Student() { }
        public Student(int marks) {
            this.marks = marks;
        }
        public static bool operator >(Student s1, Student s2)
        {
            return s1.marks > s2.marks;
        }

        public static bool operator <(Student s1, Student s2)
        {
            return s1.marks < s2.marks;
        }
    }

    internal class RelationalOperatorOverloading
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(60);
            Student s2 = new Student(70);

            if (s1 > s2)
            {
                Console.WriteLine("Student 1 has more marks");
            }
            else
            {
                Console.WriteLine("Student 2 has more marks");
            }
        }
    }
}