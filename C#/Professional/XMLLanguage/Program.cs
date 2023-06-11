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
            var xmlWriter = new XmlTextWriter("books.xml", Encoding.GetEncoding(1251));
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.IndentChar = '\t';
            xmlWriter.Indentation = 1;
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("ListOfBooks");
            xmlWriter.WriteStartElement("Book");
            xmlWriter.WriteStartAttribute("FontSize");
            xmlWriter.WriteString("8");
            xmlWriter.WriteEndAttribute();
            xmlWriter.WriteString("Title-1");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

            xmlWriter.Close();

            string xmlData = $"<?xml version='1.0' encoding='iso-8859-1' ?>\r\n<ListOfBooks>\r\n  <book>\r\n    <Title FontSize =\"8\">Title-1</Title>\r\n    <Price>50</Price>\r\n  </book>\r\n  <book>\r\n    <Title FontSize =\"10\">Title-2</Title>\r\n    <Price>150</Price>\r\n  </book>\r\n</ListOfBooks>";

            var stringReader = new StringReader(xmlData);
            var reader = new XmlTextReader(stringReader);

            while (reader.Read())
            {
                Console.WriteLine("sdf");
                Console.WriteLine("{0, -15} {1,-15} {2, -15}",
                    reader.NodeType.ToString(),
                    reader.Name,
                    reader.Value);
            }
            reader.Close();
            stringReader.Close();

            Console.WriteLine(new string('-',20));

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

            Console.WriteLine(new string('-',20));

            var document2 = new XmlDocument();
            document2.Load("books.xml");

            XmlNode root = document.DocumentElement;

            Console.WriteLine(root.LocalName);

            foreach(XmlNode books in root.ChildNodes)
            {
                Console.WriteLine("Found Book:");
                foreach (XmlNode book in books.ChildNodes)
                {
                    Console.WriteLine(book.Name + ": " + book.InnerText);
                }
            }

            Console.WriteLine(new string('-',20));
            var reader2 = new XmlTextReader("books.xml");

            while (reader2.Read())
            {
                if (reader2.NodeType == XmlNodeType.Element)
                {
                    if (reader2.Name.Equals("Title"))
                    {
                        Console.WriteLine("<{0}>", reader2.GetAttribute("FontSize"));
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
