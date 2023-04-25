namespace C_Homework
{
    partial class LoanShow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.RichTextBox();
            this.txtYear = new System.Windows.Forms.RichTextBox();
            this.txtRate = new System.Windows.Forms.RichTextBox();
            this.txtMonthPay = new System.Windows.Forms.RichTextBox();
            this.txtTotalPay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "貸款金額:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "期限(年):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "利率(%):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "月付款:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "總付款:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(262, 100);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(134, 24);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.Text = "";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(262, 146);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(134, 24);
            this.txtYear.TabIndex = 6;
            this.txtYear.Text = "";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(262, 189);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(134, 24);
            this.txtRate.TabIndex = 7;
            this.txtRate.Text = "";
            // 
            // txtMonthPay
            // 
            this.txtMonthPay.Location = new System.Drawing.Point(262, 225);
            this.txtMonthPay.Name = "txtMonthPay";
            this.txtMonthPay.Size = new System.Drawing.Size(134, 24);
            this.txtMonthPay.TabIndex = 8;
            this.txtMonthPay.Text = "";
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.Location = new System.Drawing.Point(262, 263);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.Size = new System.Drawing.Size(134, 24);
            this.txtTotalPay.TabIndex = 9;
            this.txtTotalPay.Text = "";
            // 
            // LoanShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotalPay);
            this.Controls.Add(this.txtMonthPay);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoanShow";
            this.Text = "LoanShow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtAmount;
        private System.Windows.Forms.RichTextBox txtYear;
        private System.Windows.Forms.RichTextBox txtRate;
        private System.Windows.Forms.RichTextBox txtMonthPay;
        private System.Windows.Forms.RichTextBox txtTotalPay;
    }
}