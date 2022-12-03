namespace _005_ITVDN_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyClass myClass = new MyClass();
            //MyClass myClass1 = new MyClass();
            //MyClass.Field = 2;
            string str = "Переменная стринг";
            MyClass.Method(str);
            str.Method();
            Console.WriteLine(MyClass.Field);
            MyClass2 instance = new MyClass2();
            MyClass2 instance2 = new MyClass2();
            MyClass2.field = 2;
            instance.Method();
            instance2.Method();
            MyClass2 myClass2 = MyClass.CreadClass();
            Console.WriteLine();
            myClass2.Method();
            Singleton singleton = Singleton.Instance();
            singleton.Field = "первый";
            Console.WriteLine(singleton.Field);
            Singleton singleton2 = Singleton.Instance();
            Console.WriteLine(singleton2.Field);
            str.ExtensionMethod();
            10.ExtensionMethod(2);
            Console.ReadKey();
        }
    }
}