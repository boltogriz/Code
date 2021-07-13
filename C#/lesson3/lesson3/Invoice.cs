using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3
{
    class Invoice
    {
        //Title 1:18 min
        public Invoice(string constV)
        {
            Const = constV;
        }
        public string Const { set; get; } = null;

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
        public decimal Total { get => total; set => total = value; }


        //Body


        //Footer
        decimal total = 0;
        string storekeeperSurname = null;
        string forwarderSurname = null;
 

    }
}
