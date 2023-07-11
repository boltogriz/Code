using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_6
{
    internal class Program
    {
        static void MyTask()
        {
            Console.WriteLine("Задача");

            throw new Exception();

            Console.WriteLine("Завершена");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Основной");

            Task task = new Task(MyTask);

            try 
            {
                task.Start();
                task.Wait();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message + " " + ex.GetType());

                if (ex.InnerException != null) 
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
            }
            Console.WriteLine("Конец основной");
            Console.ReadKey();
        }
    }
}
