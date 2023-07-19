using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domains_2
{
    class MyClass : MarshalByRefObject
    {
        public void Operation()
        {
            Console.WriteLine("Operation DomainID: {0}", AppDomain.CurrentDomain.Id);
            Console.WriteLine("Operation ThreadID: {0}", Thread.CurrentThread.ManagedThreadId);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDomain domain = AppDomain.CreateDomain("Second Domain");

            ObjectHandle handle = domain.CreateInstance(Assembly.GetExecutingAssembly().GetName().Name, typeof(MyClass).FullName);

            MyClass instance = handle.Unwrap() as MyClass;

            instance.Operation();

            Console.WriteLine("Main DomainID: {0}", AppDomain.CurrentDomain.Id);
            Console.WriteLine("Main ThreadID: {0}", Thread.CurrentThread.ManagedThreadId);

            Console.ReadKey();
        }
    }
}
