using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Abstraction_Interface
{
    internal interface IMyInterface
    {
        void Method();
        void MethodPrivet();
    }
    class MyClass : IMyInterface
    {
        public void Method()
        {
            Console.WriteLine("Метод - реализации Интерфейса");
        }
        void IMyInterface.MethodPrivet()
        {
            Console.WriteLine("MethodPrivet()");
        }
    }
}
