using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoding_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string leunicodeStr = "apple";
            Encoding leUnicode = Encoding.Unicode;
            Encoding beUnicode = Encoding.BigEndianUnicode;
            Encoding utf8 = Encoding.UTF8;
            byte[] leUnicodeBytes = leUnicode.GetBytes(leunicodeStr);
            byte[] beUnicodeBytes = Encoding.Convert(leUnicode, beUnicode, leUnicodeBytes);
            byte[] utf8Bytes = Encoding.Convert(leUnicode, utf8, leUnicodeBytes);
            Console.WriteLine(leunicodeStr);
            var builder = new StringBuilder();
            foreach (byte b in leUnicodeBytes) 
            {
                builder.Append(b).Append(":");
            }
            Console.WriteLine(builder);
            builder.Clear();
            foreach (byte b in beUnicodeBytes)
            {
                builder.Append(b).Append(":");
            }
            Console.WriteLine(builder);
            builder.Clear();
            foreach (byte b in utf8Bytes)
            {
                builder.Append(b).Append(":");
            }
            Console.WriteLine(builder);
            builder.Clear();
            Console.ReadLine();
        }
    }
}
