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
            // arrage
            int x = 10, y = 20, expected = 31;
            // act
            MyCal C = new MyCal();
            int actual = C.Sum(x, y);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}