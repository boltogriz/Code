using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_Parallel_0
{
    internal class PullArray
    {
        public int[] myArray;
        int i;
        public void MyTask(int y)
        {
            myArray[y] = y;
            Console.Write(y + "@");
        }

        public void MyTask1()
        {
            myArray[i] = i;
            Console.Write(i + "#");
            i++;
        }

        public PullArray()
        {
            myArray = new int[112];
            i = 0;
        }
    }
}
