using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stream stream = new FileStream("file.txt", FileMode.Open, FileAccess.Read);
            //
            byte[] buffer = new byte[stream.Length];

            IAsyncResult asyncResult = stream.BeginRead(buffer, 0, buffer.Length, null, null);
            Console.WriteLine("Reading");

            stream.EndRead(asyncResult);

            foreach(byte b in buffer) 
            {
                Console.Write(b + " ");
            }
            stream.Close();

            Console.ReadLine();
        }
    }
}
