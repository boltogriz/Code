namespace _004_ITVDN_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            A b = new B();
            //b.field1 = 5;
            B b1 = (B) b;
            b1.field2 = 8;
            b.Method();
            b1.Show();
            Console.WriteLine(new string('-', 30));
            B b2 = new B( 1, 1 );
            b2.Show();
            Console.WriteLine(new string('-', 30));
            B b3 = new B();
            b3.field2 = 2;
            A a3 = b3;
            a3.field1 = 1;
            B b4 = (B)a3;
            Console.WriteLine($"field1 = {b4.field1}, field2 = {b4.field2}");
            b4.Method();
            Console.WriteLine(new string('-', 30));
            B b5 = new B();
            A a = null;
            if (b5 is A)
            {
                a = (A)b5;
            }
            else
            {
                a = null;
            }
            a = b as A;
            a.Method();
            a.MethodASeald();
            C c = new C();
            A a6 = new A();
            a6.MethodASeald();
        }
    }
}