using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string value = ConfigurationSettings.AppSettings["Foo"];
            //Console.WriteLine(value);
            //Console.WriteLine(new string('-', 20));

            NameValueCollection appSetting = ConfigurationManager.AppSettings;
            Console.WriteLine(appSetting["Foo"]);
            Console.WriteLine(appSetting[0]);
            Console.WriteLine(new string('-', 20));

            for(int i = 0; i < appSetting.Count; i++) 
            {
                Console.WriteLine(appSetting.Keys[i] + " - " +appSetting[i]);
            }

            Console.WriteLine(new string('-', 20));
            foreach(string item in appSetting) 
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 20));
            Int32 counter = 0;
            IEnumerator settingEnumerator = appSetting.Keys.GetEnumerator();
            while (settingEnumerator.MoveNext())
            {
                Console.WriteLine("Key: {0} Value: {1}", appSetting.Keys[counter], appSetting[counter]);
                counter++;
            }

            Console.ReadKey();
        }
    }
}
