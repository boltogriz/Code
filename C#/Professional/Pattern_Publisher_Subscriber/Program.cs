using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Publisher_Subscriber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();
            Subscriber subscriber1 = new Subscriber();

            publisher.SendMessageTo(subscriber);
            publisher.SendMessageTo(subscriber1);

            Console.ReadKey();
         }
    }
}
