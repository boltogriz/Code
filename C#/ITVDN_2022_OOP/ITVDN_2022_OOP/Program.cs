using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_2022_OOP
{
    class MyClass
    {
        public int field;
        public void Method()
        {
            Console.WriteLine(field);
            Show();
        }
        private void Show()
        {
            Console.WriteLine(field + " in");
            Number3++;
        }
        private int _number;
        private int _number2;
        public int Number2
        {
            get => _number2;
            set => _number2 = value;
        }
        public int Number3 { get; set; }
        public int Number 
        {
            get
            {
                if (_number != 0)
                {
                    return _number;
                }
                else
                {
                    return ++_number;
                }

            }
            set
            {
                if (value >= 0)
                {
                    _number = value;
                }
                else
                {
                    _number = 0;
                }
            }
        }
        public int NumberNotChange => _number;
        public MyClass(int i = 10) 
        { 
            _number = i; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.field = 1;
            a.Method();
            Console.WriteLine(a.field);
            MyClass b = new MyClass();
            b.field = 2;
            b.Method();
            b.Number = 0;
            a.Number = -10;
            MyClass c = new MyClass();
            MyClass d = new MyClass(30);
            c.Number = 20;
            Console.WriteLine(b.field);
            Console.WriteLine();
            Console.WriteLine(b.NumberNotChange);
            Console.WriteLine(b.Number);
            Console.WriteLine(a.NumberNotChange);
            Console.WriteLine(a.Number);
            Console.WriteLine(c.Number);
            Console.WriteLine(c.NumberNotChange);
            Console.WriteLine(d.Number);
            Console.WriteLine(d.Number2 = 2);
            Console.WriteLine(d.Number3 = 3);
            d.Method();
            Console.WriteLine(d.Number3);
            Console.ReadKey();
        }
    }
}
