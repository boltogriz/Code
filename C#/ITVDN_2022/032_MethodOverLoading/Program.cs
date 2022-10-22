using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_MethodOverLoading
{
    internal class Program
    {
        static void Operation() { Console.WriteLine("Метод без аргумента"); }
        static void Operation(string argument) { Console.WriteLine(argument); }
        static void Operation(int argument) { Console.WriteLine(argument); }
        static void Operation(string argument0, int argument1) { Console.WriteLine(argument0 + argument1); }
        static void Operation(ref int a) { Console.WriteLine($"Ref параметр {a}"); }
        static string Translate(string englishWord)
        {
            string russianWord;
            if (englishWord == "mother")
            {
                russianWord = "мать";
            }
            else if (englishWord == "father")
            {
                russianWord = "отец";
            }
            else
            {
                russianWord = "Неизвестное слово";
            }
            return russianWord;
        }
        static bool IsAdult(byte age)
        {
            const byte ADULTHOOD = 18;
            bool result = age >= ADULTHOOD;
            return result;
        }
        static void Main(string[] args)
        {
            Operation();
            Operation("Один аргумент string");
            Operation(1);
            Operation("Два аргумента: стринт и int ", 2);
            int variable = 3;
            Operation(ref variable);

            void Method()
            {
                Console.WriteLine("Hellow world from nested method!");
            }
            Method();
            Console.WriteLine();

            string russianWord = Translate("mother");
            Console.WriteLine(russianWord);

            byte age = 23;
            bool isAdult = IsAdult(age);
            if (isAdult)
                Console.WriteLine($"В {age} год/лет - кредит доступен.");
            else
                Console.WriteLine($"В {age} год/лет - кредит недоступен.");

            Console.ReadKey();
        }
    }
}
