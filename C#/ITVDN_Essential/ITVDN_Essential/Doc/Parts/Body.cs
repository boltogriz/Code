using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Essential.Parts
{
    internal class Body
    {
        string content;
        public string Content 
        { 
            get
            {
                if (content == null)
                {
                    return "Тело документа не заполнено";
                }
                else
                {
                    return content;
                }
            }
            set
            {
                content = value;
            }
        }
        public void Show()
        {
            Console.WriteLine(Content);
        }
    }
}
