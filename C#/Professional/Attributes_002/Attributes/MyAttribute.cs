using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes_002
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    internal class MyAttribute : System.Attribute
    {
        private readonly string text;
        private readonly string data;
        public MyAttribute(string text, string data)
        {
            this.text = text;
            this.data = data;
        }
        public void Method()
        {
            Console.WriteLine("Метод класса Атрибута");
        }
        public string Text
        {
            get { return text; }
        }
        public string Data
        { 
            get { return data; } 
        }
    }
}
