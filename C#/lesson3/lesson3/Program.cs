using System;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice("Construction has been done");

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
            Console.WriteLine(invoice.Const);
            DateTime myTime = DateTime.Now;
            Console.WriteLine($"Сейчаc: { myTime.ToString("dd_MM_yyyy")}");
            var now = new WeatherObservation
            {
                RecordedAt = DateTime.Now,
                TemperatureInCelsius = 20,
                PressureInMillibars = 998.0m
            };
            Console.WriteLine(now.RecordedAt);

        }
    }
}
