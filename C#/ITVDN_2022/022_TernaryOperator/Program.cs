using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int a = 1, b = 2, max;
                if (a > b) max = a; else max = b;
                Console.WriteLine(max);
            }
            string textConsole;
            {
                textConsole = "View";
                int a = 1, b = 2, max;
                max = a > b ? a : b;
                Console.WriteLine(max);
                Console.WriteLine(textConsole);
            }
            {
                int x = 10, y = -40;
                {
                    string quadrant = x > 0 ? y > 0 ? "I квадрант" : y != 0 ? "IV квадрант" : "x > 0 and y = 0" : x != 0 ? y > 0 ? "II квадрант" : y != 0 ? "III квадрант" : "x < 0 and y = 0" : y > 0 ? "x = 0 and y > 0" : y != 0 ? "x = 0 and y < 0" : "x = 0 and y = 0";
                    Console.WriteLine(quadrant);
                }
                {
                    string quadrant;
                    if (x > 0)
                    {
                        if (y > 0)
                        {
                            quadrant = "I квадрант";
                        }
                        else if (y != 0)
                        {
                            quadrant = "IV квадрант";
                        }
                        else
                        {
                            quadrant = "x > 0 and y = 0";
                        }
                    }
                    else if (x != 0)
                    {
                        if (y > 0)
                        {
                            quadrant = "II квадрант";
                        }
                        else if (y != 0)
                        {
                            quadrant = "III квадрант";
                        }
                        else
                        {
                            quadrant = "x < 0 and y = 0";
                        }
                    }
                    else
                    {
                        if (y > 0)
                        {
                            quadrant = "x = 0 and y > 0";
                        }
                        else if (y != 0)
                        {
                            quadrant = "x = 0 and y < 0";
                        }
                        else
                        {
                            quadrant = "x = 0 and y = 0";
                        }
                    }
                    Console.WriteLine(quadrant);
                }
            }
            {
                string text = true ? "New text" : "Some text";
                Console.WriteLine(text);
                Console.WriteLine(textConsole);
            }
            {
                int a = 1, b = 2, max = 0, min = 0;
                (a > b ? ref max : ref min) = 33;
                Console.WriteLine($"max = {max}, min = {min}");
            }
            {
                int a = 1, b = 2, max = 0, min = 0;
                if (a > b) max = 33; else min = 33;
                Console.WriteLine($"max = {max}, min = {min}");
            }
            {
                int variable = 1;
                ref int address = ref variable;
                Console.WriteLine($"variable = {variable}, address = {address}");
                address = 2;
                variable = 3;
                Console.WriteLine($"variable = {variable}, address = {address}");
                Console.WriteLine($"variable == variable = {address == variable}");
            }
            Console.ReadKey();
        }
    }
}
