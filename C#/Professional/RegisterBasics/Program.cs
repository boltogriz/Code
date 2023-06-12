using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegistryKey key = Registry.CurrentUser;
            RegistryKey subKey = key.OpenSubKey("Software", true);
            RegistryKey subSubKey = subKey.CreateSubKey("CyberBionicSystematics");
            subSubKey.SetValue("TheStringName", "I containt string");
            subSubKey.SetValue("TheInt32Name", 123456);
            subSubKey.SetValue("AnotherName", 1234, RegistryValueKind.String);
            Console.WriteLine(subSubKey.GetValue("TheStringName"));
            subKey.Close();

            subKey = key.OpenSubKey(@"Software\CyberBionicSystematics");
            string value1 = subSubKey.GetValue("TheStringName") as string;
            subKey.Close();
            Console.WriteLine(value1);

            Console.ReadLine();
        }
    }
}
