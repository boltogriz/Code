using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime Date { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    FirstName = "first",
                    LastName = "Ivanov",
                    Salary = 10000,
                    Date = DateTime.Parse("1/4/1999")
                },
                new Employee
                {
                    FirstName = "first",
                    LastName = "Petrov",
                    Salary = 10000,
                    Date = DateTime.Parse("1/4/1999")
                },
                new Employee
                {
                    FirstName = "first",
                    LastName = "Sidorov",
                    Salary = 10000,
                    Date = DateTime.Parse("1/4/1999")
                },
            };
            for(int i = 0; i < employees.Count; i++) 
            { 
                Console.Write(employees[i].FirstName + " ");
                Console.WriteLine(employees[i].LastName);
            }
            Console.WriteLine(employees.Last().LastName);
            Console.ReadKey();
        }
    }
}
