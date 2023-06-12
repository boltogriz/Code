using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReestersMy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegistryKey[] keys = new RegistryKey[] {Registry.ClassesRoot,
                                                    Registry.CurrentUser,
                                                    Registry.LocalMachine,
                                                    Registry.Users,
                                                    Registry.CurrentUser,
                                                    Registry.PerformanceData
                                                    };
            foreach (var key in keys) 
            {
               
                Console.WriteLine("{0} - всего элементов: {1}.", key.Name, key.SubKeyCount);
            }

            Console.WriteLine(new string('-',20));
            RegistryKey myKey = Registry.LocalMachine;
            RegistryKey software = myKey.OpenSubKey("Software");
            RegistryKey microsoft = software.OpenSubKey("Microsoft");
            Console.WriteLine("{0} - имеет {1} элементов.", microsoft.Name, microsoft.SubKeyCount);
            software.Close();
            microsoft.Close();

            Console.WriteLine(new string('-',20));

            software = myKey.OpenSubKey("NonExistName");

            Console.WriteLine(new string('-',20));

            myKey = Registry.CurrentUser;
            RegistryKey wKey = myKey.OpenSubKey("Software", true);
            try
            {
                Console.WriteLine("Всего записей в {0}: {1}", wKey.Name, wKey.SubKeyCount);
                RegistryKey newKey = wKey.CreateSubKey("MyKeyRegeester");
                
                Console.WriteLine("Внесен " + newKey.Name);
                Console.WriteLine("Всего теперь " + wKey.SubKeyCount);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            finally 
            { 
                myKey.Close(); 
            }

            Console.WriteLine(new string('-',20));

            RegistryKey myKey2 = Registry.CurrentUser;
            RegistryKey wKey2 = myKey2.OpenSubKey("Software", true);
            string[] keyNames2 = wKey2.GetSubKeyNames();
            foreach (string keyName in keyNames2) 
            { 
                if (keyName == "MyKeyRegeester")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(new string(' ', 5) + keyName);
                    Console.ForegroundColor= ConsoleColor.Gray;
                }
                else
                {
                    Console.WriteLine(new string(' ', 5) + keyName);

                }
            }
            try 
            {
                Console.WriteLine("Всего {0}: {1}", wKey2.Name, wKey2.SubKeyCount);
                wKey2.DeleteSubKey("MyKeyRegeester");
                Console.WriteLine("удалена ветка MyKeyRegeester");
                Console.WriteLine("Всего {0}: {1}", wKey2.Name, wKey2.SubKeyCount);
            }
            catch (Exception e) { Console.WriteLine(e.Message); }

            Console.ReadLine();
        }
    }
}
