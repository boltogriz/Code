using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s = "Hellow";
            Console.WriteLine(s);
            Console.WriteLine(s.GetHashCode());
            s = s.Insert(2, "mm");
            Console.WriteLine(s);
            Console.WriteLine(s[2]);
            String s2 = new string('-', 20);
            s += s2;
            string s4 = 5.ToString();
            s += @"
                    Jack and Jill
                    Went up the hill...";
            Console.WriteLine(s4 + s);
            Console.ReadKey();
        }
    }
}
