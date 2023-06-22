using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DisposableGCollector
{
    internal class MyClass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("MyClass_Dispose " + this.GetHashCode());
            Thread.Sleep(2000);
        }
        public void ShowInf()
        {
            Console.WriteLine("Info");
        }
        ~MyClass() 
        { 
            for(int i = 0; i < 10; i++) 
            {
                Console.WriteLine(".");
            }
            Console.ReadKey();
        }
    }
}
