using System;
using System.Collections.Generic;
using System.Text;

namespace ITVDN_Lessons_1
{
    class Class1
    {
        public void MyConsole(string name)
        {
            Console.WriteLine(name);
        }
        private string _name;
        public string Name
        {
            get { return _name + " " + "Cool"; }
            set { _name = value; }
        }
    }
}
