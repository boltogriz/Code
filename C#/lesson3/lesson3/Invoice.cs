using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3
{
    class Invoice
    {
        //Title
        public DateTime Date { get; set; }
        public string Number { get; set; } = null;
        public string To { get; set; } = null;
        public string From { get; set; } = null;

        //Body

        //Footer
        public decimal Total { get; private set; }
        public string StorekeeperSurname { get; set; } = null;
        public string ForwarderSurname { get; set; } = null;
     }
}
