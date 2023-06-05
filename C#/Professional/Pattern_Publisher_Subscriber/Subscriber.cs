using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Publisher_Subscriber
{
    internal class Subscriber
    {
        internal void CallOperationsOn(Publisher publisher)
        {
            publisher.Operation();
        }
    }
}
