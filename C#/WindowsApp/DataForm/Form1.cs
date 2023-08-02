using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataForm
{
    public partial class Form1 : Form
    {
        private DataTable data;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=BUH-ADM2\\SQLEXPRESS;Initial Catalog=TohaBase;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT *" +
                              "FROM doctors";
            data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
        }

        private void sqlDataAdapter1_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {

        }

        private void getData_Click(object sender, EventArgs e)
        {

            //DataSet ds = new DataSet();
            this.sqlDataAdapter1.Fill(this.tohaBaseDataSet2, "doctors");
            //this.sqlDataAdapter1.Fill(ds, "doctors");
            //dataGridView1.DataSource = ds;
        }
    }
}
