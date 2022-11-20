using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ITVDN_Essential.Parts;
using ITVDN_Essential.Doc.Parts2;

namespace ITVDN_Essential
{
    internal class Document
    {
        Title title;
        Body body;
        Footer footer;
        Call call;
        public Call Call
        {
            get 
            { 
                return call; 
            }
            set
            {
                call = value;
            }

        }
        public Title Title 
        { 
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public Body Body 
        {
            get
            {
                return body;
            }
            set
            {
                body = value;
            } 
        }
        public Footer Footer 
        { 
            get
            {
                return footer;
            }
            set
            {
                footer = value;
            }
        }
        public Document()
        { }
        public Document(Title title, Body body, Footer footer, Call call)
        {
            this.title = title;
            this.body = body;
            this.footer = footer;
            this.call = call;
        }

        public void Show()
        {
            this.title.Show();
            this.body.Show();
            this.footer.Show();
            this.call.Show();
        }
    }
}
