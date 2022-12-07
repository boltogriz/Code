using Microsoft.VisualStudio.TestTools.UnitTesting;
using _009_ITVDN_Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_ITVDN_Delegate.Tests
{
    [TestClass()]
    public class MyClassTests
    {
        [TestMethod()]
        public void MethodTest()
        {
            MyClass myClass = new MyClass();
            string test = myClass.Method("test");
            Assert.AreEqual("MyClass.Method() test", test);
        }
    }
}