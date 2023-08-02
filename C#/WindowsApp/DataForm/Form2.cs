using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tohaBaseDataSet1.doctors". При необходимости она может быть перемещена или удалена.
            sqlDataAdapter1.Fill(tohaBaseDataSet1, "doctors");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(this.tohaBaseDataSet1, "doctors");
        }
    }
}
