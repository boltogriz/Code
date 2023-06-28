using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterLockedSpinLcok
{
    public class SpinLock
    {
        int block;
        int wait;
        public SpinLock(int wait)
        {
            this.wait = wait;
        }
        public void Enter()
        {
            int result = Interlocked.CompareExchange(ref block, 1, 0);
            while (result == 1)
            {
                Thread.Sleep(wait);
                result = Interlocked.CompareExchange(ref block, 1, 0);
            }
        }
        public void Exit() 
        { 
            Interlocked.Exchange(ref block, 0);
        }
    }
    public class SpinLockManager : IDisposable
    {
        SpinLock block;
        public SpinLockManager(SpinLock block) 
        {
            this.block = block;
            block.Enter();
        }
        public void Dispose()
        {
            block.Exit();
        }
    }

    internal class Program
    {
        static Random random = new Random();
        static SpinLock block = new SpinLock(10);

        static FileStream stream = File.Open("log.txt", FileMode.Create, FileAccess.Write, FileShare.None);
        static StreamWriter writer = new StreamWriter(stream);
        static void Function()
        {
            using (new SpinLockManager(block))
            {
                writer.WriteLine("Поток {0} запускается", Thread.CurrentThread.GetHashCode());
                writer.Flush();
            }
            int time = random.Next(10, 200);
            Thread.Sleep(time);

            using (new SpinLockManager(block))
            {
                writer.WriteLine("Поток [{0}] Завершается.", Thread.CurrentThread.GetHashCode());
                writer.Flush();
            }
        }
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[50];
            for (int i = 0; i < threads.Length; ++i)
            {
                threads[i] = new Thread(Function);
                threads[i].Start();
            }

            Console.ReadKey();
        }
    }
}
