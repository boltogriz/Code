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
            bool salaryMoreM = true, x, y, result, credit = false;
            string answer, answerCredit;
            int age, maxAge = 55;
            while (!credit) { 
                Console.Write("Введите ЗП: ");
                salary = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Возраст: ");
                age = Convert.ToInt32(Console.ReadLine());
                salaryMoreM = salary > minimumWae;
                credit =  age < maxAge && salaryMoreM;
                Console.WriteLine(
                    $"Минимальная ЗП {minimumWae}\n" +
                    $"Зарплата {salary} больше минимальной: {getAnswer.wrideAnswer(salaryMoreM)}\n" +
                    $"Возраста меньше {maxAge}: {getAnswer.wrideAnswer(age < maxAge)}\n" +
                    $"Разрешен кредит: {getAnswer.wrideAnswer(credit)}\n" +
                    $"=======================\n"
                    );
            }
            x = true;
            y = false;
            result = x && y & (salary++ > minimumWae);
            Console.WriteLine($"{x} & {y} = {result}\n{salary}");
            Console.WriteLine($"x = {x}, y = {y}");
            (x, y) = (y, x);
            Console.WriteLine($"x = {x, 5}, y = {y, 3} После картежа");
            // Delay
            Console.ReadKey();
        }
    }
}
