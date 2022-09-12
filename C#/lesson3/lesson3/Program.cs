using System;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //15 mins
            Invoice invoice = new Invoice(date: DateTime.Parse("11/07/2021"), number: "91-ВН-09124",
               to: "ГКУ КК \"Ейская РЦБ УСО\"", from: "ООО \"АутСорсинг\"", storekeeperSurname: "Сазыкин Н.П.", forwarderSurname: "Каданцев А.Л.");
            //Invoice invoice = new()
            //{
            //    Date = DateTime.Parse("11/07/2021"),
            //    Number = "91-ВН-09124",
            //    To = "ГКУ КК \"Ейская РЦБ УСО\"",
            //    From = "ООО \"АутСорсинг\"",
            //    StorekeeperSurname = "Сазыкин Н.П.",
            //    ForwarderSurname = "Каданцев А.Л."
            //
            //};
            Row row = new Row(description: "Code complete. Steve McConnell.",
                quantity: 3, price: 400);
            invoice[0] = row;
           // Row row = new()
           // {
           //     Description = "Code complete. Steve McConnell.",
           //     Quntity = 3,
           //     Price = 400
           // };
           // invoice[0] = row;//invoice.Table.AddRow(row);
            row = new()  
            {
                Description = "C# in a Nutshell",
                Quntity = 5,
                Price = 500
            };
            invoice[1] = row;//invoice.Table.AddRow(row);            
            row = new()  
            {
                Description = "New book Assembler",
                Quntity = 8,
                Price = 1500
            };
            invoice[2] = row;//invoice.Table.AddRow(row);
            // ================== Вывод ====================
            string stringTitle = $"Дата {invoice.Date} \nНакладаная № {invoice.Number}" +
                $"\nКому: {invoice.To} \nОт кого: {invoice.From}";
            Console.WriteLine(stringTitle);

            for (int i = 0; i < invoice.Table.size; i++)
            {
                row = invoice[i];
                string stringRow = $"{row.SequentialNumber} | {row.Description} | " +
                    $"{row.Quntity} шт. | {row.Price} руб. | {row.Amount} руб.";
                Console.WriteLine(stringRow);
            }
            Console.WriteLine($"Итого: {invoice.Table.Total} руб.");
            string stringFooter = $"Кладовщик: {invoice.StorekeeperSurname}," +
                $"Экспедитор: {invoice.ForwarderSurname}";
            Console.WriteLine(stringFooter);
        }
    }
}
