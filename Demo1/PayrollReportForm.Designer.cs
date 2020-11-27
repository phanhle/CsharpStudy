namespace Demo1
{
    partial class PayrollReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbPay = new System.Windows.Forms.TextBox();
            this.btCalculatePay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSearchEmp = new System.Windows.Forms.Button();
            this.tbEmpCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmpAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmpName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(127, 34);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(200, 31);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Payroll Report";
            // 
            // tbPay
            // 
            this.tbPay.Location = new System.Drawing.Point(12, 108);
            this.tbPay.Margin = new System.Windows.Forms.Padding(5);
            this.tbPay.Name = "tbPay";
            this.tbPay.ReadOnly = true;
            this.tbPay.Size = new System.Drawing.Size(426, 27);
            this.tbPay.TabIndex = 1;
            // 
            // btCalculatePay
            // 
            this.btCalculatePay.Location = new System.Drawing.Point(149, 159);
            this.btCalculatePay.Name = "btCalculatePay";
            this.btCalculatePay.Size = new System.Drawing.Size(165, 37);
            this.btCalculatePay.TabIndex = 2;
            this.btCalculatePay.Text = "Calculate Pay!";
            this.btCalculatePay.UseVisualStyleBackColor = true;
            this.btCalculatePay.Click += new System.EventHandler(this.btCalculatePay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSearchEmp);
            this.groupBox1.Controls.Add(this.tbEmpCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbEmpAge);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbEmpName);
            this.groupBox1.Location = new System.Drawing.Point(12, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 266);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Information";
            // 
            // btSearchEmp
            // 
            this.btSearchEmp.Location = new System.Drawing.Point(135, 88);
            this.btSearchEmp.Name = "btSearchEmp";
            this.btSearchEmp.Size = new System.Drawing.Size(167, 38);
            this.btSearchEmp.TabIndex = 5;
            this.btSearchEmp.Text = "Search employee";
            this.btSearchEmp.UseVisualStyleBackColor = true;
            this.btSearchEmp.Click += new System.EventHandler(this.btSearchEmp_Click);
            // 
            // tbEmpCode
            // 
            this.tbEmpCode.Location = new System.Drawing.Point(6, 41);
            this.tbEmpCode.Name = "tbEmpCode";
            this.tbEmpCode.Size = new System.Drawing.Size(416, 27);
            this.tbEmpCode.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            // 
            // tbEmpAge
            // 
            this.tbEmpAge.Location = new System.Drawing.Point(121, 195);
            this.tbEmpAge.Name = "tbEmpAge";
            this.tbEmpAge.ReadOnly = true;
            this.tbEmpAge.Size = new System.Drawing.Size(212, 27);
            this.tbEmpAge.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // tbEmpName
            // 
            this.tbEmpName.Location = new System.Drawing.Point(121, 151);
            this.tbEmpName.Name = "tbEmpName";
            this.tbEmpName.ReadOnly = true;
            this.tbEmpName.Size = new System.Drawing.Size(212, 27);
            this.tbEmpName.TabIndex = 0;
            // 
            // PayrollReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCalculatePay);
            this.Controls.Add(this.tbPay);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PayrollReportForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbPay;
        private System.Windows.Forms.Button btCalculatePay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSearchEmp;
        private System.Windows.Forms.TextBox tbEmpCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmpAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmpName;
    }
}

