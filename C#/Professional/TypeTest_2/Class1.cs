using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeTest_2
{
    public class Class1 : IInterface1, IInterface2
    {
        public int myint;
        private string mystring = "Hello";
        public Class1() { }
        public Class1(int i) 
        { 
            this.myint = i;
        }
        public int myProp
        {
            get { return myint; }
            set { myint = value; }
        }
        public string MyString
        {
            get { return MyString; }
        }
        public void MethodA()
        {
            
        }

        public void MethodB()
        {
            
        }
        private void MethodC(string str, string str2) 
        {
            Console.WriteLine(str + str2);
        }
        public void myMethod(int p1, int p2) { }
    }
}
