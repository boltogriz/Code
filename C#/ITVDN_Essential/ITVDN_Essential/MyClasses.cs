using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Essential
{
    internal class MyClasses
    {
        public void Method()
        {
            Console.WriteLine("Вызван метод класса MyClass");
        }

    }
    class MyClass2
    {
        public void CallMethod(MyClasses my)
        {
            my.Method();
        }
    }
}
