using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Exception
{
    class MyClass
    {
        public void MyMethod()
        {
            Exception ex = new Exception("Мое исключение");
            ex.HelpLink = "https://helplink.com/erroservice";
            ex.Data.Add("Причина исключения", "Тестовое исключение");
            ex.Data.Add("Время исключения", DateTime.Now);
            //ex.Data.Add("Причина исключения: ", DateTime.Now);
            throw ex;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 1, n = 2;
            try
            {
                //throw new Exception("My exeption");
                MyClass instance = new MyClass();
                instance.MyMethod();
                //a = a / (2 - n);
                //Console.WriteLine(a);
            }
            catch (Exception e)
            {
                //Console.WriteLine("Оброботка исключения.");
                //Console.WriteLine(e.Message);
                //Console.WriteLine(e.GetType());
                Console.WriteLine("Имя члена:               {0}", e.TargetSite);
                Console.WriteLine("Класс определяющий член: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Тип члена:               {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message:                 {0}", e.Message);
                Console.WriteLine("Source:                  {0}", e.Source);
                Console.WriteLine("Help Link:               {0}", e.HelpLink);
                Console.WriteLine("Stack:                   {0}", e.StackTrace);
                foreach (DictionaryEntry de in e.Data)
                    Console.WriteLine("{0} : {1}", de.Key, de.Value);
            }
            Console.ReadKey();
        }
    }
}
