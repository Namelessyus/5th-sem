namespace Chapter_Three
{
    class ComplexUnary{
        private int x;
        private int y;

        ComplexUnary() { }
        public ComplexUnary(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void ShowXY()
        {
            Console.WriteLine($"X: {x}, Y: {y}");
        }
        public static ComplexUnary operator -(ComplexUnary c)
        { 
            return new ComplexUnary(-c.x, -c.y);
        }

        public static ComplexUnary operator ++(ComplexUnary c)
        {
            return new ComplexUnary(c.x + 1, c.y + 1);
        }

        public static ComplexUnary operator --(ComplexUnary c)
        {
            return new ComplexUnary(c.x - 1, c.y - 1);
        }
    }



    internal class UnaryOperatorOverloading
    {
        public static void Main()
        {
            ComplexUnary c1 = new ComplexUnary(2, 3);
            Console.WriteLine("Complex number c1: ");
            c1.ShowXY();

            ComplexUnary c2 = -c1;
            Console.WriteLine("Complex number c2: ");
            c2.ShowXY();

            ComplexUnary c3 = ++c1;
            Console.WriteLine("Complex number c3: ");
            c3.ShowXY();
        }
    }
}
