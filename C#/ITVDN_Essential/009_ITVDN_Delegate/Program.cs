namespace _009_ITVDN_Delegate
{
    internal class Program
    {
        public delegate string MyDelegate(string txt);
        public delegate string MyDelegate2(string txt);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MyClass instance = new MyClass();
            MyDelegate myDelegate = null;
            MyDelegate myDelegate1 = new MyDelegate(instance.Method);
            MyDelegate myDelegate2 = new MyDelegate(instance.Method2);
            myDelegate = myDelegate1 + myDelegate2;
            Console.WriteLine();
            myDelegate.Invoke("text");
            Console.WriteLine();
            string arg = myDelegate("text2");
            Console.WriteLine(arg + " Prog");
            MyDelegate2 myDelegate22 = arg => arg + "D2";
            Console.WriteLine();
            Console.WriteLine(myDelegate22("моя переменная "));
        }
    }
}