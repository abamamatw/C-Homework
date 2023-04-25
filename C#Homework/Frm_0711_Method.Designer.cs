namespace C_Homework
{
    partial class Frm_0711_Method
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labResult = new System.Windows.Forms.Label();
            this.labResult1 = new System.Windows.Forms.Label();
            this.btnArray1 = new System.Windows.Forms.Button();
            this.btnArray2 = new System.Windows.Forms.Button();
            this.btnArray3 = new System.Windows.Forms.Button();
            this.btnArray4 = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btn2Array1 = new System.Windows.Forms.Button();
            this.btn2Array2 = new System.Windows.Forms.Button();
            this.btn2Array3 = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(68, 21);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(81, 22);
            this.txtNumber.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Location = new System.Drawing.Point(596, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "輸入的數字為奇數還是偶數";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labResult.Location = new System.Drawing.Point(80, 45);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(101, 24);
            this.labResult.TabIndex = 3;
            this.labResult.Text = "Result:";
            // 
            // labResult1
            // 
            this.labResult1.AutoSize = true;
            this.labResult1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labResult1.Location = new System.Drawing.Point(196, 45);
            this.labResult1.Name = "labResult1";
            this.labResult1.Size = new System.Drawing.Size(60, 24);
            this.labResult1.TabIndex = 4;
            this.labResult1.Text = "結果";
            // 
            // btnArray1
            // 
            this.btnArray1.Location = new System.Drawing.Point(23, 172);
            this.btnArray1.Name = "btnArray1";
            this.btnArray1.Size = new System.Drawing.Size(130, 60);
            this.btnArray1.TabIndex = 5;
            this.btnArray1.Text = "陣列統計奇偶數";
            this.btnArray1.UseVisualStyleBackColor = true;
            this.btnArray1.Click += new System.EventHandler(this.btnArray1_Click);
            // 
            // btnArray2
            // 
            this.btnArray2.Location = new System.Drawing.Point(23, 238);
            this.btnArray2.Name = "btnArray2";
            this.btnArray2.Size = new System.Drawing.Size(130, 60);
            this.btnArray2.TabIndex = 6;
            this.btnArray2.Text = "陣列中最長的名字";
            this.btnArray2.UseVisualStyleBackColor = true;
            this.btnArray2.Click += new System.EventHandler(this.btnArray2_Click);
            // 
            // btnArray3
            // 
            this.btnArray3.Location = new System.Drawing.Point(23, 304);
            this.btnArray3.Name = "btnArray3";
            this.btnArray3.Size = new System.Drawing.Size(130, 60);
            this.btnArray3.TabIndex = 7;
            this.btnArray3.Text = "陣列中最大/最小值";
            this.btnArray3.UseVisualStyleBackColor = true;
            this.btnArray3.Click += new System.EventHandler(this.btnArray3_Click);
            // 
            // btnArray4
            // 
            this.btnArray4.Location = new System.Drawing.Point(23, 372);
            this.btnArray4.Name = "btnArray4";
            this.btnArray4.Size = new System.Drawing.Size(130, 60);
            this.btnArray4.TabIndex = 8;
            this.btnArray4.Text = "陣列中有C/c的字樣";
            this.btnArray4.UseVisualStyleBackColor = true;
            this.btnArray4.Click += new System.EventHandler(this.btnArray4_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(693, 193);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(95, 39);
            this.btnSum.TabIndex = 9;
            this.btnSum.Text = "陣列總和";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(693, 238);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(95, 39);
            this.btnMax.TabIndex = 10;
            this.btnMax.Text = "陣列最大值";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(693, 283);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(95, 33);
            this.btnMin.TabIndex = 11;
            this.btnMin.Text = "陣列最小值";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btn2Array1
            // 
            this.btn2Array1.Location = new System.Drawing.Point(558, 238);
            this.btn2Array1.Name = "btn2Array1";
            this.btn2Array1.Size = new System.Drawing.Size(100, 40);
            this.btn2Array1.TabIndex = 12;
            this.btn2Array1.Text = "二維陣列[邊1內0]";
            this.btn2Array1.UseVisualStyleBackColor = true;
            this.btn2Array1.Click += new System.EventHandler(this.btn2Array1_Click);
            // 
            // btn2Array2
            // 
            this.btn2Array2.Location = new System.Drawing.Point(558, 311);
            this.btn2Array2.Name = "btn2Array2";
            this.btn2Array2.Size = new System.Drawing.Size(100, 40);
            this.btn2Array2.TabIndex = 13;
            this.btn2Array2.Text = "二維陣列[邊0內1]";
            this.btn2Array2.UseVisualStyleBackColor = true;
            this.btn2Array2.Click += new System.EventHandler(this.btn2Array2_Click);
            // 
            // btn2Array3
            // 
            this.btn2Array3.Location = new System.Drawing.Point(558, 379);
            this.btn2Array3.Name = "btn2Array3";
            this.btn2Array3.Size = new System.Drawing.Size(100, 40);
            this.btn2Array3.TabIndex = 14;
            this.btn2Array3.Text = "二維陣列[10101]";
            this.btn2Array3.UseVisualStyleBackColor = true;
            this.btn2Array3.Click += new System.EventHandler(this.btn2Array3_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(693, 322);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(95, 33);
            this.btnSwap.TabIndex = 15;
            this.btnSwap.Text = "swap[int,int]";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(688, 398);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "清空結果";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Frm_0711_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btn2Array3);
            this.Controls.Add(this.btn2Array2);
            this.Controls.Add(this.btn2Array1);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnArray4);
            this.Controls.Add(this.btnArray3);
            this.Controls.Add(this.btnArray2);
            this.Controls.Add(this.btnArray1);
            this.Controls.Add(this.labResult1);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_0711_Method";
            this.Text = "Frm_0711_Method";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Label labResult1;
        private System.Windows.Forms.Button btnArray1;
        private System.Windows.Forms.Button btnArray2;
        private System.Windows.Forms.Button btnArray3;
        private System.Windows.Forms.Button btnArray4;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btn2Array1;
        private System.Windows.Forms.Button btn2Array2;
        private System.Windows.Forms.Button btn2Array3;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnClear;
    }
}