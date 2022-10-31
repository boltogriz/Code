using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_002_InvoiceModeling
{
    internal class Invoce
    {
        //title
        string title;
        string date;
        public string Date
        {
            set//public void SetDate(string date)
            {
                date = value.ToLower();
            }
            get//public (string Date, string From) GetDate()
            {
                return date;
            }
        }
        string number = null;
        internal void SetNumber(string number)
        {
            this.number = number;
        }

        string to = null;
        internal void SetTo(string to)
        {
            this.to = to;
        }

        string from = null;
        internal void SetFrom(string from)
        {
            this.from = from;
        }

        /// <summary>
        /// устанавливает значение поля
        /// заголовка названивия накладной
        /// title
        /// </summary>
        /// <param name="title">Название накладной</param>
        /// <returns></returns>
        public void SetTitle(string title)
        {
            this.title = title;
        }


        //body

        //footer
        decimal total = 0;
        string storekeeperSurname = null;
        string forwarderSurname = null;

    }
}
