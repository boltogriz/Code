using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_LogicalOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Answer getAnswer = new Answer();
            int salary = 500, minimumWae = 1000;
            bool salaryMoreM = true, x, y, result, credit = false, cripy, isPensioner, isUnemployed, isEmployment, subsidyAllowed;
            int age, maxAge = 55;
            string name;
            while (!credit) {
                Console.Write("Введите имя: ");
                name = Console.ReadLine();
                Console.Write("Введите ЗП: ");
                salary = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Возраст: ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Клиент инвалит (да/нет): ");
                cripy = Console.ReadLine().Contains("да");
                Console.Write("Пенсионет да/нет: ");
                isPensioner = Console.ReadLine().Contains("да");
                Console.Write("Безработный да/нет: ");
                isUnemployed = Console.ReadLine().Contains("да");
                Console.Write("Работает да/нет: ");
                isEmployment = Console.ReadLine().Contains("да");
                subsidyAllowed = (isPensioner & isUnemployed) & !isEmployment;
                salaryMoreM = salary >= minimumWae;
                credit = ((age < maxAge) | !cripy) && salaryMoreM;
                Console.WriteLine(
                    $"\n=======================\n" +
                    $"{name}\n" +
                    $"Зарплата {salary} больше минимальной: {getAnswer.wrideAnswer(salaryMoreM)}\n" +
                    $"Возраста меньше {maxAge}: {getAnswer.wrideAnswer(age < maxAge)}\n" +
                    $"Есть инвалидность: {getAnswer.wrideAnswer(cripy)}\n" +
                    $"Разрешен кредит: {getAnswer.wrideAnswer(credit)}\n" +
                    $"Разрешна субсидия: {getAnswer.wrideAnswer(subsidyAllowed)}\n" +
                    $"=======================\n"
                    );
            }
            x = true;
            y = false;
            result = x && y & (salary++ > minimumWae);
            Console.WriteLine($"{x,-5} & {y,-5} = {result,-5}\n{salary,-5}");
            Console.WriteLine($"x = {x,-5}, y = {y,-5}");
            Console.WriteLine($"{x,-5} | {y,-5} = {x | y,-5}");
            Console.WriteLine($"{x,-5} & {y,-5} = {x | y,-5}");
            Console.WriteLine($"{x,-5} + {y,-5} = {x | y,-5}");
            Console.WriteLine($"{y,-5} - {x,-5} = {x | y,-5}");
            (x, y) = (y, x);
            Console.WriteLine($"x = {x, 5}, y = {y, 3} После картежа");
            // Delay
            Console.ReadKey();
        }
    }
}
