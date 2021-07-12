using System;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice();

            //Write
            //Title
            //invoice.SetDate("08 Июля 2021 года");
            invoice.Date = "12 июля 2021 года";
            //Body
            //Footer

            //Read
            //Title
            //string date = invoice.GetDate();
            string date = invoice.Date;
            //Body
            //Footer
        }
    }
}
