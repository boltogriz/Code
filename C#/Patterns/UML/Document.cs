using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UML
{
    public class Document
    {
        private string userName;
        public Document() 
        {
            userName = "user";
            DiscrayDocument = new DiscrayDocument();
        }

        public DiscrayDocument DiscrayDocument
        {
            get; 
            set;
            
        }

        public void Display()
        {
            Console.WriteLine("My Document " + userName + DiscrayDocument.Id);
        }
    }
}