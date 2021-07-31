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
        private string smtpServer = "smtp.gmail.com";
        private string from = "kadantsev.anton@gmail.com";
        private string password = "mirtrudmai88";
        private string mailto = "";
        private string caption = "";
        private string message = "";
        private FileInfo[] attachFile;
        private DirectoryInfo[] directory;
        // Specify the directories you want to manipulate.
        private DirectoryInfo di = new DirectoryInfo(@"SendMail");
        private GoSendMail goSendMail = new GoSendMail();
        public void NoEmptyShow()
        {
            try
            {  
                // Determine whether the directory exists.
                if (di.Exists)
                {
                    directory = di.GetDirectories();
                    for (int i = 0; i < directory.Length; i++)
                    {
                        if (directory[i].GetFiles().Length != 0)
                        {
                            attachFile = directory[i].GetFiles();
                            mailto = directory[i].ToString();
                            goSendMail.Send(smtpServer, from, password, mailto, caption, message, attachFile);//вместо MessageBox вставить рабочую функцию
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }
    }
}
