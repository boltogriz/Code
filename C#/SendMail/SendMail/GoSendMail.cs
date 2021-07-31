using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Mail;
using System.Net;

namespace SendMail
{
    class GoSendMail
    {
        public void Send(string smtpServer, string from, string password,
        string mailto, string caption, string message, FileInfo[] attachFile)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from);
                mail.To.Add(new MailAddress(mailto));
                mail.Subject = caption;
                mail.Body = message;
              if (attachFile.Length != 0 )
              {
                  for (int i = 0; i < attachFile.Length; i++)
                  { 
                      mail.Attachments.Add(new Attachment(attachFile[i].ToString()));
                      //MessageBox.Show(mailto + ": " + attachFile[i].ToString());
                  }
              }
                MessageBox.Show("good");
                SmtpClient client = new SmtpClient();
                client.Host = smtpServer;
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from.Split('@')[0], password);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mail);
                mail.Dispose();
            }
            catch (Exception e)
            {
                throw new Exception("Mail.Send: " + e.Message);
            }
            //MessageBox.Show(smtpServer + "; " + from + "; " + password + "; " + mailto + "; " + caption + "; " + message + "; " + attachFile.ToString());
        }
    }
}