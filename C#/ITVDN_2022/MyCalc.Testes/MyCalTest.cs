using NUnit.Framework;
using System;

namespace MyCalc.Testes


{
    public class MyCalTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sum_10and20_30return()
        {
            Assert.Pass();
            //arrage
            int x = 10;
            int y = 20;
            int expected = 30;
            //act
            MyCal c = new MyCal();
            Assert.AreEqual
            //assert
        }
    }
}