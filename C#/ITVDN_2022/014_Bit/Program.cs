using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Bit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = ~a;
            int c = b + 1;
            byte port = 0b_0000_1111;
            Console.WriteLine($"port = {port:X2} = {port:D3} = {Convert.ToString(port,2),8}");
            byte mask = 0b_1111_1011;
            Console.WriteLine($"mask = {mask:X2} = {mask:D3} = {Convert.ToString(mask, 2),8}");
            port = (byte)(port & mask);
            Console.WriteLine($"port = {port:X2} = {port:D3} = {Convert.ToString(port, 2),8}");
            mask = 0b_0000_0100;
            Console.WriteLine($"mask = {mask:X2} = {mask:D3} = {Convert.ToString(mask, 2),8}");
            port = (byte)(port | mask);
            Console.WriteLine($"port = {port:X2} = {port:D3} = {Convert.ToString(port, 2),8}");

            Console.WriteLine($"\n==========\n");

            char originalValue = 'A';
            Console.WriteLine($"originalValue = {originalValue} = {Convert.ToString(originalValue, 2),8}");

            ushort key = 55;
            Console.WriteLine($"key = {key} = {Convert.ToString(key, 2)}");

            char encryptedValue = (char)(originalValue ^ key);
            Console.WriteLine($"encryptedValue = {encryptedValue} = {Convert.ToString(encryptedValue, 2),8}");

            char decryptedValue = (char)(encryptedValue ^ key);
            Console.WriteLine($"decryptedValue = {decryptedValue} = {Convert.ToString(decryptedValue, 2),8}");

            Console.WriteLine($"\n==========\n");
            Console.WriteLine($"\na={a}, b={b}, c={c}");

            Console.WriteLine($"\n==========\n");

            byte port2 = 0b_0000_1111;
            Console.WriteLine($"port2 = {port2:X2} = {port2:D3} = {Convert.ToString(port2, 2),8}");
            byte value = (byte)(port2 << 5);
            Console.WriteLine($"value = {value:X2} = {value:D3} = {Convert.ToString(value, 2),8}");
            Console.WriteLine($"port2 = {port2:X2} = {port2:D3}");
            value >>= 7;
            Console.WriteLine($"value = {value:X2} = {value:D3} = {Convert.ToString(value, 2),8}");

            Console.WriteLine($"\n==========\n");
            Console.WriteLine($"\n==========\n");
            short value3 = short.MinValue;
            Console.WriteLine($"1. value3 = {value3,6} Dec = {Convert.ToString(value3, 2),8} Bin");
            value3 <<= 14;
            Console.WriteLine($"2. value3 = {value3,6} Dec = {Convert.ToString(value3, 2),16} Bin");
            value3 = short.MinValue;
            value3 >>= 15;
            Console.WriteLine($"2. value3 = {value3,6} Dec = {Convert.ToString(value3, 2),16} Bin");
            Console.WriteLine($"\n==========\n");


            Console.ReadKey();
        }
    }
}
