using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML_001
{
    [XmlRoot("MyButton")]
    public class MyClass
    {
        private string id = "button";
        private int size = 10;
        private Point position = new Point(20, 30);
        private string password = "12345_pa";
        private List<string> items = new List<string>();

        [XmlAttribute("SerialID")]
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        [XmlAttribute("Length")]
        public int Size
        { get { return size; } set {  size = value; } }
        
        [XmlElement("Pos")]
        public Point Position
        { get { return position; } set {  position = value; } }
        
        [XmlIgnore]
        public string Password
        { get { return password; } set {  password = value; } }

        [XmlArray("List")]
        [XmlArrayItem("Element")]
        public List<string> Items
        { get { return items; } set {  items = value; } }
    }
}
