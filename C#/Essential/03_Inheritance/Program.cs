using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrivedClass instance = new DrivedClass();
            Console.WriteLine(instance.publicField);
            instance.Show();
            Console.ReadKey();
        }
    }
}
