namespace Chapter_Three
{
    public class Utility1
    {
        public static void swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
    public class GenericExampleTwo
    {
        public static void Main()
        {
            int x = 5;
            int y = 10;

            Utility1.swap(ref x, ref y);
            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);

        }
    }
}