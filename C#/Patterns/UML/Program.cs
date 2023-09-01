using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    internal class Program
    {
        public static MyClassLittle MyClassLittle { get; set; }
        public static Document Document
        {
            get; 
            set;
        }



        static void Main(string[] args)
        {
            Document = new Document();
            Document.Display();

            MyClassLittle = new MyClassLittle();
            Console.WriteLine(MyClassLittle.ToString());

            Console.ReadLine();
        }
    }
}
