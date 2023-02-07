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
    }
    class MyClass : IMyInterface
    {
        public void Method()
        {
            Console.WriteLine("Метод - реализации Интерфейса");
        }
    }
}
