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
        private Butterfly butterfly;
        public void Method()
        {
            Console.WriteLine(field);
            Console.WriteLine(butterfly.Name + " Initilization");
        }
        public void SetField(string value)
        {
            field = value;
        }
        public string GetField()
        {
            return field;
        }
        public MyClass(Butterfly butterfly):
            this()
        {
            butterfly.Fly();
            this.butterfly.Name = butterfly.Name;
        }
        public MyClass()
        { 
            butterfly = new Butterfly();
        }
    }
}
