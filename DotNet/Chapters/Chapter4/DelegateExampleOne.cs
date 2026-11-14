namespace Chapter4
{
    public delegate int Arithmetics(int a, int b);
    public delegate float Arithmeticsf(float a, float b);
    internal class DelegateExampleOne
    {
        public static int add(int a, int b)
        {
            return a + b;
        }

        public static int subtract(int a, int b)
        {
            return a - b;
        }
        public static float subtract(float a, float b)
        {
            return a - b;
        }

        //public static void Main()
        //{
        //    Arithmetics arithmetics = new Arithmetics(add);
        //    Console.WriteLine("Addition: " + arithmetics(10, 5));
        //    arithmetics = new Arithmetics(subtract);
        //    Console.WriteLine("Subtraction: " + arithmetics(10, 5));

        //    Arithmeticsf floatAreith = new Arithmeticsf(subtract);
        //    Console.WriteLine("Subtractionf: " + floatAreith(10.12f, 5.5234f));
        //}
    }
}