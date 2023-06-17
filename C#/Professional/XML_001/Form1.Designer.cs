namespace XML_001
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
            this.SerializeButton = new System.Windows.Forms.Button();
            this.DeSerializeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SerializeButton
            // 
            this.SerializeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SerializeButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SerializeButton.Location = new System.Drawing.Point(37, 294);
            this.SerializeButton.Name = "SerializeButton";
            this.SerializeButton.Size = new System.Drawing.Size(136, 27);
            this.SerializeButton.TabIndex = 0;
            this.SerializeButton.Text = "Serialization\r\n";
            this.SerializeButton.UseVisualStyleBackColor = true;
            this.SerializeButton.Click += new System.EventHandler(this.SerializeButton_Click);
            // 
            // DeSerializeButton
            // 
            this.DeSerializeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeSerializeButton.ForeColor = System.Drawing.Color.OliveDrab;
            this.DeSerializeButton.Location = new System.Drawing.Point(37, 340);
            this.DeSerializeButton.Name = "DeSerializeButton";
            this.DeSerializeButton.Size = new System.Drawing.Size(140, 27);
            this.DeSerializeButton.TabIndex = 1;
            this.DeSerializeButton.Text = "DeSerialization";
            this.DeSerializeButton.UseVisualStyleBackColor = true;
            this.DeSerializeButton.Click += new System.EventHandler(this.DeSerializeButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 355);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 393);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DeSerializeButton);
            this.Controls.Add(this.SerializeButton);
            this.Name = "Form1";
            this.Text = "XML SERIALIZER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeSerializeButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SerializeButton;
    }
}

