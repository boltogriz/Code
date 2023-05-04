using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
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
            return "Hellow world1111";
        }
    }
    class Point : MyBaseClass
    {
        protected int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point()
        { }
        public int X
        {
            get => x;  
            set => x = value; 
        }
        public int Y { get => y; set => y = value; }
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
        public Point Clone()
        {
            return this.MemberwiseClone() as Point;
        }
    }
    class MyBaseClass
    {
        public static string CompanyName = "Microsoft";
        public int age;
        public string name;
        public void Meth()
        {
            MyBaseClass obj = new MyBaseClass();
            obj.MemberwiseClone();
        }
    }
    class ClonePoint : Point, ICloneable
    {
        public ClonePoint(int x, int y)
            : base(x, y)
        { }
        public ClonePoint()
            : base()
        { }
        object ICloneable.Clone()
        {
            return Clone1();
        }
        public ClonePoint Clone1 ()
        {
            return this.MemberwiseClone() as ClonePoint;
        }
    }
    internal class Program : MyBaseClass
    {

        static void MethPoint(ClonePoint point)
        {
            
            point.X = 10;
            point.Y = 10;
        }
        static void MethArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] + 1;
                Console.WriteLine("MethArray = " + arr[i]);
            }
        }
        static void Main(string[] args)
        {
            Program original = new Program();
            original.age = 42;
            original.name = "Alex";
            Console.WriteLine(original.age + " " + original.name + " " + Program.CompanyName);

            Program clone = original.MemberwiseClone() as Program;
            Console.WriteLine(clone.age + " " + clone.name + " " + Program.CompanyName + "\n");

            clone.age = 50;
            clone.name = "Konstantin";
            MyBaseClass.CompanyName = "CyberBionic Systematics";
            Console.WriteLine(original.age + " " + original.name + " " + Program.CompanyName);
            Console.WriteLine(clone.age + " " + clone.name + " " + Program.CompanyName);

            Console.WriteLine(new string('-',20));
            int[] arr = new int[] { 1, 1, 1 };
            MethArray(arr.Clone() as int[]);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Original array = " + arr[i]);
            }
            Console.WriteLine(new string('-',20));

            Point a = new Point(1, 2);
            Point b = new Point(1, 2);
            Point c = new Point(0, 1);
            Console.WriteLine("a == b : {0}", a.Equals(b));
            Console.WriteLine("a == c : {0}", a.Equals(c));
            Object instanceA = new MyClassA();
            object instanceB = new MyClassB();
            MyClass myClass = new MyClass();
            Console.WriteLine( myClass );
            Console.WriteLine(new String('-',20));
            Object obj = new object();
            Type type = obj.GetType();
            Console.WriteLine(type.ToString());
            Console.WriteLine(a.X + " " + a.Y);
            Point CloneA = a.Clone();
            CloneA.X = 3;
            CloneA.Y = 4;
            Console.WriteLine(CloneA.X + " " + CloneA.Y);
            Console.WriteLine(a.X + " " + a.Y);
            Console.WriteLine(new string('-',20));

            ClonePoint point = new ClonePoint(5, 5);
            ClonePoint clonePoint = (ClonePoint)point.Clone();
            Console.WriteLine(point.X + " " + point.Y);
            Console.WriteLine(clonePoint.X + " " + clonePoint.Y);
            MethPoint(clonePoint);
            Console.WriteLine(point.X + " " + point.Y);
            Console.WriteLine(clonePoint.X + " " + clonePoint.Y);
            //
            Console.ReadKey();
        }
    }
}
