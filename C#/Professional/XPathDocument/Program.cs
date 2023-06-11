using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace XPathDocumentMy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var document = new XPathDocument("books.xml");
            XPathNavigator navigator = document.CreateNavigator();
            XPathNodeIterator iterator1 = navigator.Select("ListOfBooks/book/Title");
            foreach(var item in iterator1)
                Console.WriteLine(item);

            XPathExpression exception = navigator.Compile("ListOfBooks/book[2]/Price");
            XPathNodeIterator iterator2 = navigator.Select(exception);
            foreach(var item in iterator2)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
