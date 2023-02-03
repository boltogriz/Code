using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrivedClass instance = new DrivedClass();
            Console.WriteLine(instance.publicField);
            instance.Show();

            Console.WriteLine(new string('-', 20));

            DrivedClass instance2 = new DrivedClass(1, 2);
            Console.WriteLine(instance2.baseNumber);
            Console.WriteLine(instance2.drivedField);
            DrivedClass instance3 = new DrivedClass(3);
            Console.WriteLine(instance3.baseNumber);

            Console.WriteLine(new string('-', 20));
            
            DrivedClass instance4 = new DrivedClass();
            instance4.field1 = 1;
            instance4.field2 = 2;
            instance4.field3 = 3;
            instance4.field4 = 4;
            instance4.field5 = 5;
            BaseClass newInstance = (BaseClass)instance4;
            Console.WriteLine(newInstance.field1);
            Console.WriteLine(newInstance.field2);
            Console.WriteLine(newInstance.field3);
            Console.WriteLine("instance4   Id {0}", instance4.GetHashCode());
            Console.WriteLine("newInstance Id {0}", newInstance.GetHashCode());
            
            Console.WriteLine(new string('-', 20));
            
            DrivedClass newInstance2 = (DrivedClass)instance4.Clone();
            newInstance2.field1 = 8;
            Console.WriteLine("instance4.field1 = {0}, newInstance2.field1 = {1}", instance4.field1, newInstance2.field1);
            Console.WriteLine("instance4    Id {0}", instance4.GetHashCode());
            Console.WriteLine("newInstance2 Id {0}", newInstance2.GetHashCode());

            Console.WriteLine(new string('-', 20));

            DrivedClass dIntsance = new DrivedClass();
            dIntsance.Method();
            BaseClass instanceUp = dIntsance;
            instanceUp.Method();
            DrivedClass instanceDown = (DrivedClass)instanceUp;
            instanceDown.Method();

            BaseClass instance5 = new DrivedClass();
            Console.WriteLine(instance5.field3);

            BaseClass instance6 = new DrivedClass();
            DrivedClass instance7 = (DrivedClass)instance6;
            Console.WriteLine(instance7.field5);

            Console.WriteLine(new string('-', 20));

            DrivedClass instVitual = new DrivedClass();
            instVitual.MethodVirtual();
            instVitual.NVMethod();
            BaseClass instVirtualUp = instVitual;
            instVirtualUp.MethodVirtual();
            instVirtualUp.NVMethod();
            DrivedClass instVirtualDown = (DrivedClass)instVirtualUp;
            instVirtualDown.MethodVirtual();
            instVirtualDown.NVMethod();

            Console.WriteLine(new string('-', 20));

            DrivedClass b = new DrivedClass();
            BaseClass a = null;
            if (b is BaseClass)
            {
                a = (BaseClass)b;
            }
            else
            {
                a = null;
            }
            a = b as BaseClass;
            
            Console.WriteLine(new string('-', 20));

            { 
                DrivedClass drived = new DrivedClass();
                drived.MethodVirtual();

                BaseClass baseUp = drived as BaseClass;
                if (instanceUp != null)
                    baseUp.MethodVirtual();

                DrivedClass drivedDown = baseUp as DrivedClass;
                drivedDown.MethodVirtual();
            }
            Console.WriteLine(new string('-', 20));

            Console.ReadKey();
        }
    }
}
