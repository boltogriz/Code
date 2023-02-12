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
            Console.ReadKey();
        }
    }
}
