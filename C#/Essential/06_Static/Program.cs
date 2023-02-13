using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotStaticClass instance = new NotStaticClass();
            NotStaticClass instance1 = new NotStaticClass();
            instance.Method();
            instance1.Method();
            NotStaticClass.field = 1;
            instance.Method();
            instance1.Method();
            NotStaticClass.MethodStatic();
            AbstractClass instanceAbstract = AbstractClass.CreataObject();
            instanceAbstract.Method();
            Singleton instanceSingleton = Singleton.Instance();
            Singleton instanceSingleton2 = Singleton.Instance();
            Console.WriteLine(instanceSingleton.GetHashCode());
            Console.WriteLine(instanceSingleton2.GetHashCode());
            string text = "Text";
            text.ExtensionMethod();
            ExtensionClass.ExtensionMethod(text);
            int number = 3;
            number.ExtensionMethod();
            Console.ReadKey();

        }
    }
}
