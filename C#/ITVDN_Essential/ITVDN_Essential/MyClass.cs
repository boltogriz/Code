using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Essential
{
    internal class MyClass
    {
        string name;
        int x;
        int y;
        public string Name 
        { 
            get
            {
                return name;
            } 
            set
            {
                name = value;
            }
        }
        public string Title { get; set; }
        public MyClass(string name) : this(x: 100, y: 200)
        {
            this.name = name;
        }
        public MyClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public MyClass()
        { }
        public void MyMethod()
        {
            Console.WriteLine("MyMethod " + Name);
            Console.WriteLine($"x = {x} ; y = {y}");
        }
    }
}
