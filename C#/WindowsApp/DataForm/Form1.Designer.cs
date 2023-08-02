namespace DataForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.getData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drlnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tohaBaseDataSet2 = new DataForm.TohaBaseDataSet();
            this.tohaBaseDataSet1 = new DataForm.TohaBaseDataSet();
            this.updateButton = new System.Windows.Forms.Button();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tohaBaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tohaBaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        dr_id AS Expr1, dr_lname AS Expr2, dr_fname AS Expr3, phone AS Expr" +
    "4, address AS Expr5, city AS Expr6, state AS Expr7, zip AS Expr8, doctors.*\r\nFRO" +
    "M            doctors";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=PC-TOHA-RYZEN\\SQLEXPRESS;Initial Catalog=TohaBase;Integrated Security" +
    "=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            this.sqlConnection1.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.sqlConnection1_InfoMessage);
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Expr1", System.Data.SqlDbType.Int, 0, "Expr1"),
            new System.Data.SqlClient.SqlParameter("@Expr2", System.Data.SqlDbType.VarChar, 0, "Expr2"),
            new System.Data.SqlClient.SqlParameter("@Expr3", System.Data.SqlDbType.VarChar, 0, "Expr3"),
            new System.Data.SqlClient.SqlParameter("@Expr4", System.Data.SqlDbType.VarChar, 0, "Expr4"),
            new System.Data.SqlClient.SqlParameter("@Expr5", System.Data.SqlDbType.VarChar, 0, "Expr5"),
            new System.Data.SqlClient.SqlParameter("@Expr6", System.Data.SqlDbType.VarChar, 0, "Expr6"),
            new System.Data.SqlClient.SqlParameter("@Expr7", System.Data.SqlDbType.VarChar, 0, "Expr7"),
            new System.Data.SqlClient.SqlParameter("@Expr8", System.Data.SqlDbType.VarChar, 0, "Expr8"),
            new System.Data.SqlClient.SqlParameter("@dr_id", System.Data.SqlDbType.Int, 0, "dr_id"),
            new System.Data.SqlClient.SqlParameter("@dr_lname", System.Data.SqlDbType.VarChar, 0, "dr_lname"),
            new System.Data.SqlClient.SqlParameter("@dr_fname", System.Data.SqlDbType.VarChar, 0, "dr_fname"),
            new System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.VarChar, 0, "phone"),
            new System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 0, "address"),
            new System.Data.SqlClient.SqlParameter("@city", System.Data.SqlDbType.VarChar, 0, "city"),
            new System.Data.SqlClient.SqlParameter("@state", System.Data.SqlDbType.VarChar, 0, "state"),
            new System.Data.SqlClient.SqlParameter("@zip", System.Data.SqlDbType.VarChar, 0, "zip")});
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.Connection = this.sqlConnection1;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@dr_id", System.Data.SqlDbType.Int, 4, "dr_id"),
            new System.Data.SqlClient.SqlParameter("@dr_lname", System.Data.SqlDbType.VarChar, 2147483647, "dr_lname"),
            new System.Data.SqlClient.SqlParameter("@dr_fname", System.Data.SqlDbType.VarChar, 2147483647, "dr_fname"),
            new System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.VarChar, 2147483647, "phone"),
            new System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 2147483647, "address"),
            new System.Data.SqlClient.SqlParameter("@city", System.Data.SqlDbType.VarChar, 2147483647, "city"),
            new System.Data.SqlClient.SqlParameter("@state", System.Data.SqlDbType.VarChar, 2147483647, "state"),
            new System.Data.SqlClient.SqlParameter("@zip", System.Data.SqlDbType.VarChar, 2147483647, "zip")});
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(12, 180);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(75, 23);
            this.getData.TabIndex = 1;
            this.getData.Text = "Get Data";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.getData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dridDataGridViewTextBoxColumn,
            this.drlnameDataGridViewTextBoxColumn,
            this.drfnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.zipDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "doctors";
            this.dataGridView1.DataSource = this.tohaBaseDataSet2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(914, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dridDataGridViewTextBoxColumn
            // 
            this.dridDataGridViewTextBoxColumn.DataPropertyName = "dr_id";
            this.dridDataGridViewTextBoxColumn.HeaderText = "dr_id";
            this.dridDataGridViewTextBoxColumn.Name = "dridDataGridViewTextBoxColumn";
            // 
            // drlnameDataGridViewTextBoxColumn
            // 
            this.drlnameDataGridViewTextBoxColumn.DataPropertyName = "dr_lname";
            this.drlnameDataGridViewTextBoxColumn.HeaderText = "dr_lname";
            this.drlnameDataGridViewTextBoxColumn.Name = "drlnameDataGridViewTextBoxColumn";
            // 
            // drfnameDataGridViewTextBoxColumn
            // 
            this.drfnameDataGridViewTextBoxColumn.DataPropertyName = "dr_fname";
            this.drfnameDataGridViewTextBoxColumn.HeaderText = "dr_fname";
            this.drfnameDataGridViewTextBoxColumn.Name = "drfnameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn.HeaderText = "state";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // zipDataGridViewTextBoxColumn
            // 
            this.zipDataGridViewTextBoxColumn.DataPropertyName = "zip";
            this.zipDataGridViewTextBoxColumn.HeaderText = "zip";
            this.zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            // 
            // tohaBaseDataSet2
            // 
            this.tohaBaseDataSet2.DataSetName = "TohaBaseDataSet";
            this.tohaBaseDataSet2.RemotingFormat = System.Data.SerializationFormat.Binary;
            this.tohaBaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tohaBaseDataSet1
            // 
            this.tohaBaseDataSet1.DataSetName = "TohaBaseDataSet";
            this.tohaBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(135, 180);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT        dr_id, dr_lname, dr_fname, phone, address, city, state, zip\r\nFROM  " +
    "          doctors";
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlConnection1;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@dr_id", System.Data.SqlDbType.Int, 0, "dr_id"),
            new System.Data.SqlClient.SqlParameter("@dr_lname", System.Data.SqlDbType.VarChar, 0, "dr_lname"),
            new System.Data.SqlClient.SqlParameter("@dr_fname", System.Data.SqlDbType.VarChar, 0, "dr_fname"),
            new System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.VarChar, 0, "phone"),
            new System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 0, "address"),
            new System.Data.SqlClient.SqlParameter("@city", System.Data.SqlDbType.VarChar, 0, "city"),
            new System.Data.SqlClient.SqlParameter("@state", System.Data.SqlDbType.VarChar, 0, "state"),
            new System.Data.SqlClient.SqlParameter("@zip", System.Data.SqlDbType.VarChar, 0, "zip")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@dr_id", System.Data.SqlDbType.Int, 0, "dr_id"),
            new System.Data.SqlClient.SqlParameter("@dr_lname", System.Data.SqlDbType.VarChar, 0, "dr_lname"),
            new System.Data.SqlClient.SqlParameter("@dr_fname", System.Data.SqlDbType.VarChar, 0, "dr_fname"),
            new System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.VarChar, 0, "phone"),
            new System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 0, "address"),
            new System.Data.SqlClient.SqlParameter("@city", System.Data.SqlDbType.VarChar, 0, "city"),
            new System.Data.SqlClient.SqlParameter("@state", System.Data.SqlDbType.VarChar, 0, "state"),
            new System.Data.SqlClient.SqlParameter("@zip", System.Data.SqlDbType.VarChar, 0, "zip"),
            new System.Data.SqlClient.SqlParameter("@Original_dr_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "dr_id", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM [doctors] WHERE (([dr_id] = @Original_dr_id))";
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_dr_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "dr_id", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.FillLoadOption = System.Data.LoadOption.OverwriteChanges;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand2;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand2;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "doctors", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("dr_id", "dr_id"),
                        new System.Data.Common.DataColumnMapping("dr_lname", "dr_lname"),
                        new System.Data.Common.DataColumnMapping("dr_fname", "dr_fname"),
                        new System.Data.Common.DataColumnMapping("phone", "phone"),
                        new System.Data.Common.DataColumnMapping("address", "address"),
                        new System.Data.Common.DataColumnMapping("city", "city"),
                        new System.Data.Common.DataColumnMapping("state", "state"),
                        new System.Data.Common.DataColumnMapping("zip", "zip")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.getData);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tohaBaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tohaBaseDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TohaBaseDataSet tohaBaseDataSet1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private TohaBaseDataSet tohaBaseDataSet2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drlnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drfnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button getData;
        private System.Windows.Forms.Button updateButton;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
    }
}

