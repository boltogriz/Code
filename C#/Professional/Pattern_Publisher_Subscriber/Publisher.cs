using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Publisher_Subscriber
{
    internal class Publisher
    {
        internal void Operation()
        {
            Console.WriteLine("Вызов операции");
        }

        internal void SendMessageTo(Subscriber subscriber)
        {
            subscriber.CallOperationsOn(this);
        }
    }
}
