using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableGCollector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(MyClass instance = new MyClass()) 
            {
                instance.ShowInf();
                throw new Exception("using");
            }

            Console.WriteLine(new string('-',20));

            MyClass instance2 = new MyClass();



            try
            {
                instance2.ShowInf();
                //throw new Exception("using");
            }
            finally
            {
                if(instance2 is IDisposable && instance2 != null)
                    instance2.Dispose();
            }
            Console.ReadLine();
        }
    }
}
