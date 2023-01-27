using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential
{
    internal class MyClass
    {
        private string field;
        public void Method()
        {
            Console.WriteLine(field);
        }
        public void SetField(string value)
        {
            field = value;
        }
        public string GetField()
        {
            return field;
        }
        public MyClass(Butterfly butterfly)
        {
            butterfly.Fly();
        }
        public MyClass()
        { }
    }
}
