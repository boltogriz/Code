using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _13_Stream
{
    internal class Program
    {
        static void WriteSecond()
        {
            while(true)
            {
                Console.WriteLine(new String(' ', 10) + "Secondary");
            }
        }
        static void Main(string[] args)
        {
            ThreadStart writesecond = new ThreadStart(WriteSecond);
            Thread thread = new Thread(writesecond);
            thread.Start();
            while(true)
            {
                Console.WriteLine("Primary");
            }
            //
            Console.ReadKey();
        }
    }
}
