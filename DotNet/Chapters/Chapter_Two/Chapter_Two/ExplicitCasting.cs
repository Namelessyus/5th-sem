using System;

namespace Chapter_Two
{
    class ExplicitCasting
    {
        static void Main()
        {
            double num = 9.70;
            int wholeNum = (int)num;

            Console.WriteLine("Decimal " + num);
            Console.WriteLine("Integer " + wholeNum);

            string strNum = "123";
            int newNum = Convert.ToInt32(strNum); //num = 123;

            int anothernum = 50;
            string strAnotherNum = anothernum.ToString();

            Console.WriteLine("string to integer" + strNum);
            Console.WriteLine("integer to string " + strAnotherNum);

            char letter = 'A';
            int value = (int)letter;
            Console.WriteLine("Character: " + letter);
            Console.WriteLine("Value: " + value);

            int asciiValue = 66;
            char newletter = (char)asciiValue;
            Console.WriteLine("ASCII Value: " + asciiValue);
            Console.WriteLine("Character: " + newletter);
        }
    }
}
