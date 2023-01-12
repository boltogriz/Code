using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyCalcLibs.Tests
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            // arrange
            int x = 10;
            int y = 20;
            int expected = 30;

            // act
            MyCalcLibs c = new MyCalcLibs();
            int actual = c.Sum(x, y);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
