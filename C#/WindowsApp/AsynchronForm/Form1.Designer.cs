namespace AsynchronForm
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
            this.numeralTextBoxA = new MyCom.NumeralTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numeralTextBoxB = new MyCom.NumeralTextBox();
            this.buttonIntegral = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // numeralTextBoxA
            // 
            this.numeralTextBoxA.Location = new System.Drawing.Point(31, 6);
            this.numeralTextBoxA.Name = "numeralTextBoxA";
            this.numeralTextBoxA.Size = new System.Drawing.Size(100, 20);
            this.numeralTextBoxA.TabIndex = 0;
            this.numeralTextBoxA.Text = "0";
            this.numeralTextBoxA.Value = 0D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "B:";
            // 
            // numeralTextBoxB
            // 
            this.numeralTextBoxB.Location = new System.Drawing.Point(186, 6);
            this.numeralTextBoxB.Name = "numeralTextBoxB";
            this.numeralTextBoxB.Size = new System.Drawing.Size(100, 20);
            this.numeralTextBoxB.TabIndex = 3;
            this.numeralTextBoxB.Text = "0";
            this.numeralTextBoxB.Value = 0D;
            // 
            // buttonIntegral
            // 
            this.buttonIntegral.Location = new System.Drawing.Point(31, 48);
            this.buttonIntegral.Name = "buttonIntegral";
            this.buttonIntegral.Size = new System.Drawing.Size(75, 23);
            this.buttonIntegral.TabIndex = 4;
            this.buttonIntegral.Text = "Интеграл";
            this.buttonIntegral.UseVisualStyleBackColor = true;
            this.buttonIntegral.Click += new System.EventHandler(this.buttonIntegral_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(27, 88);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(36, 20);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "___";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 141);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(305, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 173);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonIntegral);
            this.Controls.Add(this.numeralTextBoxB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeralTextBoxA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCom.NumeralTextBox numeralTextBoxA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MyCom.NumeralTextBox numeralTextBoxB;
        private System.Windows.Forms.Button buttonIntegral;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

