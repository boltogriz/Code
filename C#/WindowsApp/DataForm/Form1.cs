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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tohaBaseDataSet.specialties". При необходимости она может быть перемещена или удалена.
            this.specialtiesTableAdapter.Fill(this.tohaBaseDataSet.specialties);
            //SqlConnection connection = new SqlConnection("Data Source=BUH-ADM2\\SQLEXPRESS;Initial Catalog=TohaBase;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = connection;
            //cmd.CommandText = "SELECT *" +
            //                  "FROM doctors";
            //data = new DataTable();
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //adapter.Fill(data);
        }

        private void sqlDataAdapter1_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {

        }

        private void getData_Click(object sender, EventArgs e)
        {
            //while (dataGridView1.Rows.Count > 1)
            //{
            //    foreach (DataGridViewRow row in dataGridView1.Rows)
            //    {
            //        dataGridView1.Rows.Remove(row);
            //    }
            //}

            sqlDataAdapter1.Fill(tohaBaseDataSet2, "doctors");
            sqlDataAdapter2.Fill(tohaBaseDataSet2, tohaBaseDataSet2.specialties.TableName);
            //DataSet ds = new DataSet();
            //this.sqlDataAdapter1.Fill(this.tohaBaseDataSet2, "doctors");

            //this.sqlDataAdapter1.Fill(ds, "doctors");
            //foreach(DataGridViewRow row in dataGridView1.Rows)
            //{
            //    dataGridView1.Rows.Remove(row);
            //}
            //dataGridView1.DataSource = ds;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(this.tohaBaseDataSet2, "doctors");
            
        }

        private void sqlConnection1_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
  
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void sqlDataAdapter1_RowUpdated_1(object sender, SqlRowUpdatedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlDataAdapter1.SelectCommand.CommandText = @"SELECT        doctors.dr_id, doctors.dr_lname, doctors.dr_fname, doctors.phone, doctors.address, doctors.city, doctors.state, doctors.zip
                FROM            doctors INNER JOIN
                         drspecialties ON doctors.dr_id = drspecialties.dr_id
                WHERE        (drspecialties.specialty_id = @spectrual_id)";
            if (sqlDataAdapter1.SelectCommand.Parameters.Contains("@spectrual_id"))
            {
                SqlParameter param = new SqlParameter("@spectrual_id", int.Parse(this.comboBox1.SelectedValue.ToString()));
                sqlDataAdapter1.SelectCommand.Parameters.Add(param);
            }
            else
            {
                sqlDataAdapter1.SelectCommand.Parameters["@spectrual_id"].Value = int.Parse(this.comboBox1.SelectedValue.ToString());
            }


            ..
            sqlDataAdapter1.Fill(tohaBaseDataSet2, "doctors");

        }
    }
}
