namespace Chapter4
{

    delegate void Callback(string name);

    class DelegateExampleClass
    {
        public static void LogMessage(Callback callback)
        {
            Console.WriteLine("Hello from log method");

            callback("from callback delegate");
        }
    }

    internal class DeligateCallback
    {
        public static void CallBackMethodOne(string value)
        {
            Console.WriteLine("CallBackMethodOne called: " + value);
        }
        public static void CallBackMethodTwo(string value)
        {
            Console.WriteLine("CallBackMethodTwo called: " + value);
        }
        //public static void Main()
        //{
        //    DelegateExampleClass.LogMessage(CallBackMethodOne);
        //}
    }
}
