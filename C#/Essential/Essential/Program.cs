using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential
{
    class Butterfly
    {
        public string name;
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
        } // setter
        public void Fly()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Name);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Butterfly mahaon = new Butterfly();
            mahaon.Name = "Admiral";
            mahaon.Fly();
            Console.WriteLine(new string('-', 20));
            MyClass myClass = new MyClass();
            myClass.SetField("MyClass");
            new MyClass().Method();
            string @string = myClass.GetField();
            myClass.Method();
            Console.WriteLine(@string);
            Console.WriteLine(new string('-', 20));
            MyClass myClass2 = new MyClass(mahaon);
            myClass2.Method();
            MyClass myClass3 = new MyClass();
            myClass3.Method();
            Console.WriteLine(new string('-', 20));
            
            Console.ReadKey();
        }
    }
}
