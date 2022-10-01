using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _015_Variable;

namespace MyCTest
{
    [TestClass]
    public class MyC
    {
        [TestMethod]
        public void Sum10_and20_30return()
        {
            // arrage
            int x = 10, y = 20, expected = 30;
            // act
            MyCal C = new MyCal();
            int actual = C.Sum(x, y);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
