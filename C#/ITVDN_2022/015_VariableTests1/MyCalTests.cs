using Microsoft.VisualStudio.TestTools.UnitTesting;
using _015_Variable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Variable.Tests
{
    [TestClass()]
    public class MyCalTests
    {
        [TestMethod()]
        public void SumTest()
        {
            int x, y, e;
            x = 10;
            y = 15;
            e = 25;
            MyCal Cal = new MyCal();
            int actualy = Cal.Sum(x, y);
            Assert.AreEqual(e, actualy);
        }
    }
}