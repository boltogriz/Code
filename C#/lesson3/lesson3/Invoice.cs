using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3
{
    class Invoice
    {
        //Title 42 min
        string date = null;
        public string Date
        {
            //public void SetDate(string date)
            set { date = value.ToLower(); }
            //public string GetDate()
            get { return date; }
        }

        public string Number { set; get; } = null;

        public string To { set; get; } = null;

        public string From { set; get; } = null;


        //Body


        //Footer
        decimal total = 0;
        string storekeeperSurname = null;
        string forwarderSurname = null;
 

    }
}
