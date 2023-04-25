namespace C_Homework
{
    partial class Frm_0703_Hello
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
            this.btnSayHello = new System.Windows.Forms.Button();
            this.btnSayHi = new System.Windows.Forms.Button();
            this.labName = new System.Windows.Forms.Label();
            this.labEnglishName = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.labHoroscope = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEnglishName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtHoroscope = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSayHello
            // 
            this.btnSayHello.Location = new System.Drawing.Point(62, 287);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(100, 73);
            this.btnSayHello.TabIndex = 0;
            this.btnSayHello.Text = "Say Hello";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // btnSayHi
            // 
            this.btnSayHi.Location = new System.Drawing.Point(200, 287);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(100, 73);
            this.btnSayHi.TabIndex = 1;
            this.btnSayHi.Text = "Say Hi";
            this.btnSayHi.UseVisualStyleBackColor = true;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(71, 84);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(29, 12);
            this.labName.TabIndex = 2;
            this.labName.Text = "姓名";
            // 
            // labEnglishName
            // 
            this.labEnglishName.AutoSize = true;
            this.labEnglishName.Location = new System.Drawing.Point(71, 129);
            this.labEnglishName.Name = "labEnglishName";
            this.labEnglishName.Size = new System.Drawing.Size(70, 12);
            this.labEnglishName.TabIndex = 3;
            this.labEnglishName.Text = "English Name";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Location = new System.Drawing.Point(71, 176);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(29, 12);
            this.labGender.TabIndex = 4;
            this.labGender.Text = "性別";
            // 
            // labHoroscope
            // 
            this.labHoroscope.AutoSize = true;
            this.labHoroscope.Location = new System.Drawing.Point(71, 222);
            this.labHoroscope.Name = "labHoroscope";
            this.labHoroscope.Size = new System.Drawing.Size(29, 12);
            this.labHoroscope.TabIndex = 5;
            this.labHoroscope.Text = "星座";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(180, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtEnglishName
            // 
            this.txtEnglishName.Location = new System.Drawing.Point(180, 129);
            this.txtEnglishName.Name = "txtEnglishName";
            this.txtEnglishName.Size = new System.Drawing.Size(120, 22);
            this.txtEnglishName.TabIndex = 7;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(180, 176);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(120, 22);
            this.txtGender.TabIndex = 8;
            // 
            // txtHoroscope
            // 
            this.txtHoroscope.Location = new System.Drawing.Point(180, 219);
            this.txtHoroscope.Name = "txtHoroscope";
            this.txtHoroscope.Size = new System.Drawing.Size(120, 22);
            this.txtHoroscope.TabIndex = 9;
            // 
            // Frm_0703_Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHoroscope);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtEnglishName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labHoroscope);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.labEnglishName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.btnSayHi);
            this.Controls.Add(this.btnSayHello);
            this.Name = "Frm_0703_Hello";
            this.Text = "Frm_0703_Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Button btnSayHi;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labEnglishName;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labHoroscope;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEnglishName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtHoroscope;
    }
}