using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SendMail
{
    class Paths
    {
        public DirectoryInfo[] NoEmptyShow()
        {
            string Text = "";

            DirectoryInfo[] directory;
            // Specify the directories you want to manipulate.
            DirectoryInfo di = new DirectoryInfo(@"SendMail");
            try
            {  
                // Determine whether the directory exists.
                if (di.Exists)
                {
                    Text = "SendMail exists";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
            directory = di.GetDirectories();
            for (int i = 0; i < directory.Length; i++)
            {
                MessageBox.Show(directory[i].ToString());
            }
            return directory;
        }
    }
}
