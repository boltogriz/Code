using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Domains_0
{
    class MyClass : MarshalByRefObject
    {
        public void Operation()
        {
            Console.WriteLine("Метод Operation выполняется в домене: {0}", AppDomain.CurrentDomain.Id);

            Console.WriteLine("instance {0}", this.GetHashCode());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Метод Main выполняется в домене: {0}", AppDomain.CurrentDomain.Id);

            AppDomain domain = AppDomain.CreateDomain("Second Domain");

            string assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            string typeName = typeof(MyClass).FullName;

            ObjectHandle handle = domain.CreateInstance(assemblyName, typeName);

            MyClass instance = handle.Unwrap() as MyClass;

            Console.WriteLine("instance {0}", instance.GetHashCode());

            Console.WriteLine("IsTransparentProxy(instance) : {0}", RemotingServices.IsTransparentProxy(instance));

            instance.Operation();

            Console.ReadLine();
        }
    }
}
