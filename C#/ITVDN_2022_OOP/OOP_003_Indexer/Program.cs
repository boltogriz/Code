using OOP_003_Indexer;
using System;

namespace OOP_003_Indexr
{

    class SampleCollection<T>
    {
        // Declare an array to store the data elements.
        private T[] arr = new T[100];

        // Define the indexer to allow client code to use [] notation.
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }

    class Program
    {
        static void Main()
        {
            var stringCollection = new SampleCollection<string>();
            stringCollection[0] = "Hello, World";
            Console.WriteLine(stringCollection[0]);

            var nomberCollection = new Indexer<int>() 
            { 
                TaseName1 = "Инициализатор",
            };
            nomberCollection[0] = 1;
            nomberCollection[1] = 2;
            nomberCollection[2] = 3;
            for (int i = 0; i < nomberCollection.maxIndex; i++)
            {
                Console.WriteLine(nomberCollection[i]);
            }
            Console.WriteLine(nomberCollection.TaseName0);
            Console.WriteLine(nomberCollection.TaseName1);
            {
                var tempRecord = new TempRecord();

                // Use the indexer's set accessor
                tempRecord[3] = 58.3F;
                tempRecord[5] = 60.1F;

                // Use the indexer's get accessor
                for (int i = 0; i < tempRecord.Length; i++)
                {
                    Console.WriteLine($"Element #{i} = {tempRecord[i]}");
                }

                // Keep the console window open in debug mode.
                Console.WriteLine("Press any key to exit.");

            }
            /* Output:
                Element #0 = 56.2
                Element #1 = 56.7
                Element #2 = 56.5
                Element #3 = 58.3
                Element #4 = 58.8
                Element #5 = 60.1
                Element #6 = 65.9
                Element #7 = 62.1
                Element #8 = 59.2
                Element #9 = 57.5
            */
            var example1 = new Example1();
            example1[0] = "Нулевой";
            example1[1] = "Первый";
            example1[2] = "Второй";
            example1[1] = "Первый_";
            example1[9] = "Девятый";
            example1[10] = "Десятый";
            example1[6] = "Шестой";
            example1[12] = "Двенадцатый";
            for (int i = 0; i < example1.Length; i++)
            {
                Console.WriteLine($"example1[{i}] = {example1[i]}");
            }
            Console.ReadKey();
        }
    }
    // The example displays the following output:
    //       Hello, World.
}