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
    abstract class AbstractClass3 : IMyInterface
    {
        public abstract void Method();
        public abstract void MethodPrivet();
    }
    class MyClassForAbst : AbstractClass3
    {
        public override void Method()
        {
            Console.WriteLine("AbstractClass3 Method");
        }
        public override void MethodPrivet()
        {
            Console.WriteLine("AbstractClass3 MethodPrivet");
        }
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
