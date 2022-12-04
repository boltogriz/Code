namespace _007_ITVDN_Structur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Struct instance;
           // instance.field = 1;
           // Console.WriteLine(instance.field);
            Struct instance2 = new Struct(10);
            instance2.Show();
        }
    }
} 