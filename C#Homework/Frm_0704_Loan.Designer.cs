namespace C_Homework
{
    partial class Frm_0704_Loan
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
            this.btnMonthPay = new System.Windows.Forms.Button();
            this.btnTotalPay = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.labTotal = new System.Windows.Forms.Label();
            this.labYearToMonth = new System.Windows.Forms.Label();
            this.labToMonthRate = new System.Windows.Forms.Label();
            this.labFirstPay = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMonthPay
            // 
            this.btnMonthPay.Location = new System.Drawing.Point(176, 305);
            this.btnMonthPay.Name = "btnMonthPay";
            this.btnMonthPay.Size = new System.Drawing.Size(78, 50);
            this.btnMonthPay.TabIndex = 0;
            this.btnMonthPay.Text = "PMT(月付)";
            this.btnMonthPay.UseVisualStyleBackColor = true;
            this.btnMonthPay.Click += new System.EventHandler(this.btnMonthPay_Click);
            // 
            // btnTotalPay
            // 
            this.btnTotalPay.Location = new System.Drawing.Point(345, 305);
            this.btnTotalPay.Name = "btnTotalPay";
            this.btnTotalPay.Size = new System.Drawing.Size(78, 50);
            this.btnTotalPay.TabIndex = 1;
            this.btnTotalPay.Text = "總付款";
            this.btnTotalPay.UseVisualStyleBackColor = true;
            this.btnTotalPay.Click += new System.EventHandler(this.btnTotalPay_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(544, 305);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(78, 50);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Location = new System.Drawing.Point(46, 107);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(53, 12);
            this.labTotal.TabIndex = 3;
            this.labTotal.Text = "貸款金額";
            // 
            // labYearToMonth
            // 
            this.labYearToMonth.AutoSize = true;
            this.labYearToMonth.Location = new System.Drawing.Point(46, 144);
            this.labYearToMonth.Name = "labYearToMonth";
            this.labYearToMonth.Size = new System.Drawing.Size(49, 12);
            this.labYearToMonth.TabIndex = 4;
            this.labYearToMonth.Text = "期限(年)";
            // 
            // labToMonthRate
            // 
            this.labToMonthRate.AutoSize = true;
            this.labToMonthRate.Location = new System.Drawing.Point(46, 192);
            this.labToMonthRate.Name = "labToMonthRate";
            this.labToMonthRate.Size = new System.Drawing.Size(46, 12);
            this.labToMonthRate.TabIndex = 5;
            this.labToMonthRate.Text = "利率(%)";
            // 
            // labFirstPay
            // 
            this.labFirstPay.AutoSize = true;
            this.labFirstPay.Location = new System.Drawing.Point(46, 228);
            this.labFirstPay.Name = "labFirstPay";
            this.labFirstPay.Size = new System.Drawing.Size(41, 12);
            this.labFirstPay.TabIndex = 6;
            this.labFirstPay.Text = "頭期款";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(151, 182);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(151, 228);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 22);
            this.textBox4.TabIndex = 10;
            // 
            // Frm_0704_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labFirstPay);
            this.Controls.Add(this.labToMonthRate);
            this.Controls.Add(this.labYearToMonth);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotalPay);
            this.Controls.Add(this.btnMonthPay);
            this.Name = "Frm_0704_Loan";
            this.Text = "Frm_0704_Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMonthPay;
        private System.Windows.Forms.Button btnTotalPay;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.Label labYearToMonth;
        private System.Windows.Forms.Label labToMonthRate;
        private System.Windows.Forms.Label labFirstPay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}