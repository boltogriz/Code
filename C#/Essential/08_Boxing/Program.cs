using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Boxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short a = 25;
            object o = a;
            short b = (short)o;

        }
    }
}
