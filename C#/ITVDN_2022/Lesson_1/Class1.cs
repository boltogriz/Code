using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Class1
    {
        public void MyConsole()
        {
            Console.Beep(323, 300);
            Console.Beep(373, 300);
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
