using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Struct
{
    struct Struct
    {
        public int field;
        public static int second;
    }
    class MyClass
    {
        public MyStruct_1mb st = new MyStruct_1mb();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GC.GetTotalMemory(false));
            Struct s = new Struct() { field = 2};
            //s.field = 1;
            Console.WriteLine(s.field);
            Struct.second = 2;
            MyClass my = new MyClass();
            my.st.a0.a1 = 1;
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.ReadKey();
        }
    }
}
