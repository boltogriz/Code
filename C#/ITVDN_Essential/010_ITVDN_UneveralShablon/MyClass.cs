using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_ITVDN_UneveralShablon
{
    internal class MyClass<T>
    {
        public T Field { get; set; }
        public void Method()
        {
            Console.WriteLine(Field.GetType());
        }
    }
}
