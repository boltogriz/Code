namespace OOP_002_InvoiceModeling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoce invoice = new Invoce()
            {
                Date = DateTime.Parse("23/4/2035"),
                Number = "54-TK-07162",
                To = "Дом книг",
                From = "Microsoft press",
                StorekeeperSurname = "Иванов",
                ForwarderSurname = "Петров"
            };
            Row row = new()
            {
                Description = "Code complete. Steve McConnell.",
                Quantity = 5,
                Price = 500
            };
            //invoice.Table.AddRow(row);
            invoice[0] = row;
            row = new()
            {
                Description = "CLR via C#. Jeffrey Richter.",
                Quantity = 5,
                Price = 500
            };
            //invoice.Table.AddRow(row);
            invoice[1] = row;
            /*Console.WriteLine(invoice.Date);
            Console.WriteLine(invoice.Number);
            Console.WriteLine(invoice.To);
            Console.WriteLine(invoice.From);
            Console.WriteLine(invoice.StorekeeperSurname);
            Console.WriteLine(invoice.ForwarderSurname);*/
            //вывод
            string stringTitle = $"Дата {invoice.Date} \nНакладная № {invoice.Number}" +
                $"\nКому: {invoice.To} \nОт кого: {invoice.From}";
            Console.WriteLine(stringTitle);
            for (int i = 0; i < invoice.Table.Size; i++)
            {
                row = invoice[i];
                string stringRow = $"{row.SequentialNumber} | {row.Description} | " +
                    $"{row.Quantity} шт. | {row.Price} руб. | {row.Amount} руб.";
                Console.WriteLine(stringRow);
            }
            Console.WriteLine($"Итого: {invoice.Table.Total} руб.");
            string stringFooter = $"Кладовщик: {invoice.StorekeeperSurname}, " +
                $"Экспедитор: {invoice.ForwarderSurname}";
            Console.WriteLine(stringFooter);
            Console.ReadKey();
        }
    }
}