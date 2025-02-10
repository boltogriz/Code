using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatcherMessageBox
{
    internal class MyData
    {
        public static string GetData(string dir)
        {
            string month = "";
            string month0 = "";
            string day;
            string direkt;

            DateTime thisday = DateTime.Today;

            if (thisday.Day.ToString().Length == 1)
            {
                day = "0" + thisday.Day.ToString();
            }
            else
            {
                day = thisday.Day.ToString();
            }
            if (thisday.Month == 1)
            {
                month = "Январь";
                month0 = "01";
            }
            if (thisday.Month == 2)
            {
                month = "Февраль";
                month0 = "02";
            }
            if (thisday.Month == 3)
            {
                month = "Март";
                month0 = "03";
            }
            if (thisday.Month == 4)
            {
                month = "Апрель";
                month0 = "04";
            }
            if (thisday.Month == 5)
            {
                month = "Май";
                month0 = "05";
            }
            if (thisday.Month == 6)
            {
                month = "Июнь";
                month0 = "06";
            }
            if (thisday.Month == 7)
            {
                month = "Июль";
                month0 = "07";
            }
            if (thisday.Month == 8)
            {
                month = "Август";
                month0 = "08";
            }
            if (thisday.Month == 9)
            {
                month = "Сентябрь";
                month0 = "09";
            }
            if (thisday.Month == 10)
            {
                month = "Октябрь";
                month0 = "10";
            }
            if (thisday.Month == 11)
            {
                month = "Ноябрь";
                month0 = "11";
            }
            if (thisday.Month == 12)
            {
                month = "Декабрь";
                month0 = "12";
            }
            return direkt = $@"{dir}\" + thisday.Year.ToString() + "\\" + month + "\\" + day + "_" + month0 + "_" + thisday.Year.ToString();
        }
    }
}
