namespace _011_ITVDN_Constrane
{
    class MyClass<T> where T : struct
    { }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MyClass<int> instance = new MyClass<int>();
        }
    }
}