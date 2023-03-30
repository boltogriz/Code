using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassClone
{
    class A { public int a = 1; }
    class B : A { public int b = 2; }
    class C : B { public int c = 3; }
    class X : C { }
    internal class Program : X
    {

        static void Main(string[] args)
        {
            Program original = new Program();
            Console.WriteLine("Оригинал : " + original.a + " " + original.b + " " + original.c);

            Program clone = original.MemberwiseClone() as Program;
            Console.WriteLine("Клон : " + clone.a + " " + clone.b + " " + clone.c + "\n");
            clone.a = clone.b = clone.c = 7;
            Console.WriteLine("Оригинал : " + original.a + " " + original.b + " " + original.c);
            Console.WriteLine("Клон : " + clone.a + " " + clone.b + " " + clone.c);
            Console.ReadKey();
        }
    }
}
