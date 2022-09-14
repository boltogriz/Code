using System;
using System.Collections.Generic;
using System.Text;

namespace ITVDN_Lessons_1
{
    class Class1
    {
        public void MyConsole()
        {
            Console.Beep();
            Console.WriteLine("> " + _name + " " + "Cool");
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
