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
        string date = null;
        public void SetDate(string date)
        {
            this.date = date;
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

        public (string Date, string From) GetDate()
        {
            return (this.date, this.from);
        }


        //body

        //footer
        decimal total = 0;
        string storekeeperSurname = null;
        string forwarderSurname = null;

    }
}
