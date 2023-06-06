using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulturInfoForm
{
    enum DayEnum
    {
        Monday = 1, Tuesday = 2, Wednesday = 3, Friday = 4, Saturday = 5, Sunday = 6
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = 122345.45;
            CultureInfo[] cultureInfo = CultureInfo.GetCultures(CultureTypes.AllCultures);
            foreach (CultureInfo culture in cultureInfo) 
            {
                Console.WriteLine(culture.EnglishName + " | " + culture.ToString());
            }
            
            Console.WriteLine((int)DayEnum.Monday);

            string localMoney = money.ToString("C", new CultureInfo("en-US"));
            Console.WriteLine(localMoney);

            string result = String.Format("Деньги {0}", localMoney);
            Console.WriteLine(result);

            Console.ReadLine();
        }
        
    }
}
