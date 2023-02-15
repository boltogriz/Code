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
    internal class Program
    {
        static void Main(string[] args)
        {
            Struct s;
            s.field = 1;
            Struct.second = 2;
        }
    }
}
