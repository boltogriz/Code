using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Static
{
    class MyClass
    {
        public int a;
        public int b;
        public int c;
    }
    internal class Program
    {
        static void Method(MyClass myClass)
        {
            myClass.a = 1;
            myClass.b = 2;
            myClass.c = 3;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            MyClass myClass = new MyClass();
            Method(myClass);
            Console.WriteLine(myClass.a);
            NotStaticClass instance0 = new NotStaticClass();
            NotStaticClass instance1 = new NotStaticClass();
            instance0.Method();
            instance1.Method();
            NotStaticClass.field = 1;
            instance0.Method();
            instance1.Method();
            NotStaticClass.MethodStatic();
            AbstractClass instanceAbstract = AbstractClass.CreataObject();
            instanceAbstract.Method();
            Singleton instanceSingleton = Singleton.Instance();
            Singleton instanceSingleton2 = Singleton.Instance();
            Console.WriteLine(instanceSingleton.GetHashCode());
            Console.WriteLine(instanceSingleton2.GetHashCode());
            instanceSingleton.ExtensionMethod();
            string text = "Text";
            text.ExtensionMethod();
            ExtensionClass.ExtensionMethod(text);
            int number = 3;
            number.ExtensionMethod();
            Console.ReadKey();

        }
    }
}
