using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLLanguage
{
    class TestReturn
    {
        private int[] i;
        private int current;
        public int I
        {
            get { return i[current]; }
            set { i[current] = value; }
        }
        public TestReturn()
        {
            i = new int[5];
            i[0] = 0; i[1] = 1; i[2] = 2; i[3] = 3; i[4] = 4;
            current = -1;
        }
        public bool Reader() 
        {
            this.current++;
            if (this.current < i.Length) 
            {
                return true;
            } 
            else 
            { 
                return false; 
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var document = new XmlDocument();
            document.Load("books.xml");

            Console.WriteLine(document.InnerText);

            Console.WriteLine(new string('-',20));
            
            Console.WriteLine(document.InnerXml);

            Console.WriteLine(new string('-',20));

            Console.SetWindowSize(80, 45);

            FileStream stream = new FileStream("books.xml", FileMode.Open);

            XmlTextReader xmlTextReader = new XmlTextReader(stream);

            while(xmlTextReader.Read()) 
            {
                Console.WriteLine("{0, -15} {1,-15} {2, -15}",
                    xmlTextReader.NodeType,
                    xmlTextReader.Name,
                    xmlTextReader.Value);
            }
            xmlTextReader.Close();
            stream.Close();

            Console.WriteLine(new string('-',20));
            
            TestReturn testReturn = new TestReturn();
            while(testReturn.Reader())
            {
                Console.WriteLine(testReturn.I);
            }


            Console.ReadKey();
        }
    }
}
