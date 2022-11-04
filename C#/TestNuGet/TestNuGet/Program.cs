using Limilabs.Client.SMTP;
using Limilabs.Mail.Headers;
using Limilabs.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Tracing;

namespace TestNuGet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MailBuilder builder = new MailBuilder();
            builder.From.Add(new MailBox("a.kadantsev@mtsr.krasnodar.ru"));
            builder.To.Add(new MailBox("kadantsev.anton@gmail.com"));
            builder.Subject = "Subject";
            builder.Html = @"Html with an image: <img src=""cid:lena"" />";

            //var visual = builder.AddVisual(@"c:\lena.jpeg");
            //visual.ContentId = "lena";
            var attachment = builder.AddAttachment(@"c:\tmp.doc");
            attachment.SetFileName("document.doc", guessContentType: true);

            IMail email = builder.Create();

            using (Smtp smtp = new Smtp())
            {
                smtp.ConnectSSL("m.krasnodar.ru");  // or ConnectSSL for SSL
                smtp.UseBestLogin("MTSR/a.kadantsev", "Vbhnhelvfq1");

                smtp.SendMessage(email);
                smtp.Close();
            }
        }
    }
}
