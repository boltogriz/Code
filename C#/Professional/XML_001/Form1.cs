using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XML_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly XmlSerializer serializer = new XmlSerializer(typeof(MyClass));
        MyClass instance1 = new MyClass();
        MyClass instance2;

        private void SerializeButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                instance1.Items.Add("Element " + i);
            }
            FileStream stream = new FileStream("Serialization.xml", FileMode.Create, FileAccess.Write, FileShare.Read);

            serializer.Serialize(stream, instance1);
            this.Text = "Объект сериализован!";
            stream.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DeSerializeButton_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream stream = new FileStream("Serialization.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                instance2 = serializer.Deserialize(stream) as MyClass;
                this.Text = "Объект Десериализован!";

                textBox1.Text = "ID            : " + instance2.ID + Environment.NewLine +
                                "Size         : " + instance2.Size + Environment.NewLine +
                                "Position    : " + instance2.Position.ToString() + Environment.NewLine +
                                "List           : " +  Environment.NewLine;

                foreach (string item in instance2.Items)
                {
                    textBox1.Text += "\t" + item + Environment.NewLine;
                }
                textBox1.Text += "Password:   " + instance2.Password + Environment.NewLine;
                stream.Close();
            }
            catch (Exception ex) 
            { 
                textBox1.Text = ex.Message;
            }
        }
    }
}
