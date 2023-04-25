namespace C_Homework
{
    partial class Frm_0708_StructForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveShow = new System.Windows.Forms.Button();
            this.btnGrade = new System.Windows.Forms.Button();
            this.labName = new System.Windows.Forms.Label();
            this.labChinese = new System.Windows.Forms.Label();
            this.labEnglish = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.gpbGrade = new System.Windows.Forms.GroupBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.gpbGrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(95, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 56);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveShow
            // 
            this.btnSaveShow.Location = new System.Drawing.Point(213, 325);
            this.btnSaveShow.Name = "btnSaveShow";
            this.btnSaveShow.Size = new System.Drawing.Size(96, 56);
            this.btnSaveShow.TabIndex = 1;
            this.btnSaveShow.Text = "顯示儲存內容";
            this.btnSaveShow.UseVisualStyleBackColor = true;
            this.btnSaveShow.Click += new System.EventHandler(this.btnSaveShow_Click);
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(602, 364);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(135, 56);
            this.btnGrade.TabIndex = 2;
            this.btnGrade.Text = "最高分/最低分科目";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(29, 96);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(32, 12);
            this.labName.TabIndex = 3;
            this.labName.Text = "姓名:";
            // 
            // labChinese
            // 
            this.labChinese.AutoSize = true;
            this.labChinese.Location = new System.Drawing.Point(29, 143);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(32, 12);
            this.labChinese.TabIndex = 4;
            this.labChinese.Text = "國文:";
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Location = new System.Drawing.Point(29, 191);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(32, 12);
            this.labEnglish.TabIndex = 6;
            this.labEnglish.Text = "英文:";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Location = new System.Drawing.Point(29, 232);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(32, 12);
            this.labMath.TabIndex = 5;
            this.labMath.Text = "數學:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtChinese
            // 
            this.txtChinese.Location = new System.Drawing.Point(112, 143);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(144, 22);
            this.txtChinese.TabIndex = 8;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(112, 191);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(144, 22);
            this.txtEnglish.TabIndex = 9;
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(112, 232);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(144, 22);
            this.txtMath.TabIndex = 10;
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(6, 21);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(276, 178);
            this.txtShow.TabIndex = 11;
            // 
            // gpbGrade
            // 
            this.gpbGrade.Controls.Add(this.txtGrade);
            this.gpbGrade.Controls.Add(this.txtShow);
            this.gpbGrade.Location = new System.Drawing.Point(455, 43);
            this.gpbGrade.Name = "gpbGrade";
            this.gpbGrade.Size = new System.Drawing.Size(282, 315);
            this.gpbGrade.TabIndex = 12;
            this.gpbGrade.TabStop = false;
            this.gpbGrade.Text = "成績";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(6, 205);
            this.txtGrade.Multiline = true;
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(275, 101);
            this.txtGrade.TabIndex = 12;
            // 
            // Frm_0708_StructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbGrade);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labChinese);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.btnSaveShow);
            this.Controls.Add(this.btnSave);
            this.Name = "Frm_0708_StructForm";
            this.Text = "Frm_0708_StructForm";
            this.gpbGrade.ResumeLayout(false);
            this.gpbGrade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveShow;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.GroupBox gpbGrade;
        private System.Windows.Forms.TextBox txtGrade;
    }
}