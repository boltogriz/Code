using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_LogicalOperations
{
    internal class Answer
    {
        public string wrideAnswer(bool Answer)
        {
            string wordAnser;
            if (Answer)
            {
                wordAnser = "Да";
            }
            else
            {
                wordAnser = "Нет";
            }
            return wordAnser;
        }
    }
}
