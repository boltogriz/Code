using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _16_Reload
{
    class MyClassA : Object
    { }
    class MyClassB: object
    { }
    class MyClass : Object
    {
        public override string ToString()
        {
            return "Hellow world1";
        }
    }
    class Point : Object
    {
        protected int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override bool Equals(object obj)
        {
            if(obj == null || this.GetType() != obj.GetType()) 
                return false;
            Point p = (Point)obj;
            return (x == p.x) && (y == p.y);
        }
        public override int GetHashCode()
        {
            return x ^ y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 2);
            Point b = new Point(1, 2);
            Point c = new Point(0, 1);
            Console.WriteLine("a == b : {0}", a.Equals(b));
            Console.WriteLine("a == c : {0}", a.Equals(c));
            Object instanceA = new MyClassA();
            object instanceB = new MyClassB();
            MyClass myClass = new MyClass();
            Console.WriteLine( myClass );
            //
            Console.ReadKey();
        }
    }
}
