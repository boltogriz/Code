using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageBox.Show("App1", AppDomain.CurrentDomain.FriendlyName);
            throw new Exception("Исключение в App1");

            MessageBox.Show("App1", "Продолжение");
        }
    }
}
