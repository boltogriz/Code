using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a1 = "hello", a2 = "world", s1 = a1 + " " + a2;
            s1 += "!";
            string i1, i2;
            Console.Write("Введите первое слагаемое: ");
            i1 = Console.ReadLine();
            Console.Write("Введите второе слагаемое: ");
            i2 = Console.ReadLine();
            int it1, it2, sit1;
            it1 = Convert.ToInt32(i1);
            it2 = Convert.ToInt32(i2);
            sit1 = it1 + it2;
            string sit2 = string.Format("Результат {0} + {1} = {2}", it1, it2, sit1);
            Console.WriteLine($"{it1,30:N} + {it2:N} = {sit1:N}");
            Console.WriteLine("Результат {0} + {1} = {2}", it1, it2, sit1);
            Console.WriteLine(s1);
            Console.WriteLine(sit2);
            Console.WriteLine("Шестнадцатеричный: {0:X}; {1:X}", it1, it2);
            Console.WriteLine("%: {0:P1} ; {1:P}", it1,it2);
            Console.WriteLine("Валюта: {0:c}; {1:C}", it1, it2);
            Console.WriteLine("Номер: {0:N}; {1:N}", it1, it2);
            Console.WriteLine("C2: {0:C3}; {1:C2}", it1, it2);
            Console.ReadLine();
        
        }
    }
}
