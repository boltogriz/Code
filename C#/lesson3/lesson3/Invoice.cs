using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3
{
    class Invoice
    {
        
        //Title
        string date = null;
        public void SetDate(string date)
        {
            this.date = date.ToLower();
        }
        string number = null;
        string to = null;
        string from = null;

        public string GetDate()
        {
            return date;
        }

        //Body


        //Footer
        decimal total = 0;
        string storekeeperSurname = null;
        string forwarderSurname = null;
 

    }
}
