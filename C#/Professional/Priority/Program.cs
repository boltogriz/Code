using Priority;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Priority
{
    class PriorityTest
    {
        bool loopSwitch;
        public PriorityTest()
        {
            loopSwitch = true;
        }
        public bool LoopSwitch
        { set { loopSwitch = value; } }
        public void ThreadMethod()
        {
            long threadCound = 0;
            while (loopSwitch)
            {
                threadCound++;
            }
            Console.WriteLine("{0} with {1,12} priority has a count = {2,13}",
                Thread.CurrentThread.Name,
                Thread.CurrentThread.Priority.ToString(),
                threadCound.ToString("N0"));
        }
    }

}
internal class Program
{
    static void Main(string[] args)
    {
        PriorityTest priorityTest = new PriorityTest();
        ThreadStart startDelegate = priorityTest.ThreadMethod;

        Thread[] threadOne = { new Thread(startDelegate), new Thread(startDelegate), new Thread(startDelegate), new Thread(startDelegate), new Thread(startDelegate), new Thread(startDelegate) };
        for (int i = 0; i < threadOne.Length; i++)
        {
            threadOne[i].Name = "ThreadOne " + i.ToString();
            threadOne[i].Priority = ThreadPriority.Lowest;
        }

        Thread[] threadTwo = { new Thread(startDelegate), new Thread(startDelegate), new Thread(startDelegate), new Thread(startDelegate), new Thread(startDelegate), new Thread(startDelegate) };
        for (int i = 0; i < threadTwo.Length; i++)
        {
            threadTwo[i].Name = "ThreadTwo " + i.ToString();

            threadTwo[i].Priority = ThreadPriority.Highest;
        }



        for (int i = 0; i < threadOne.Length; i++)
            threadOne[i].Start();

        for (int i = 0; i < threadTwo.Length; i++)
        {
            threadTwo[i].Start();
            Thread.Sleep(10);
        }
        Thread.Sleep(2000);

        priorityTest.LoopSwitch = false;

        Console.ReadKey();
    }
}

