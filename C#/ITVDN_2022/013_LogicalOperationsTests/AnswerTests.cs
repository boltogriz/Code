using Microsoft.VisualStudio.TestTools.UnitTesting;
using _013_LogicalOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_LogicalOperations.Tests
{
    [TestClass()]
    public class AnswerTests
    {
        [TestMethod()]
        public void wrideAnswerTrueTest()
        {
            bool value = true;
            string expecter = "Да";
            Answer Answer1 = new Answer();
            string answer = Answer1.wrideAnswer(value);
            Assert.AreEqual(expecter, answer);
        }
        [TestMethod()]
        public void wrideAnswerFalseTest()
        {
            bool value = false;
            string expecter = "Нет";
            Answer Answer1 = new Answer();
            string answer = Answer1.wrideAnswer(value);
            Assert.AreEqual(expecter, answer);
        }
    }
}