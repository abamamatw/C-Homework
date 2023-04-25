namespace C_Homework
{
    partial class Frm_0705_POS
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnBeer = new System.Windows.Forms.Button();
            this.btnTequila = new System.Windows.Forms.Button();
            this.btnWhisky = new System.Windows.Forms.Button();
            this.btnWine = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(528, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 244);
            this.listBox1.TabIndex = 0;
            // 
            // btnBeer
            // 
            this.btnBeer.Location = new System.Drawing.Point(29, 112);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(80, 93);
            this.btnBeer.TabIndex = 1;
            this.btnBeer.Text = "Beer";
            this.btnBeer.UseVisualStyleBackColor = true;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // btnTequila
            // 
            this.btnTequila.Location = new System.Drawing.Point(128, 112);
            this.btnTequila.Name = "btnTequila";
            this.btnTequila.Size = new System.Drawing.Size(80, 93);
            this.btnTequila.TabIndex = 2;
            this.btnTequila.Text = "Tequila";
            this.btnTequila.UseVisualStyleBackColor = true;
            // 
            // btnWhisky
            // 
            this.btnWhisky.Location = new System.Drawing.Point(29, 230);
            this.btnWhisky.Name = "btnWhisky";
            this.btnWhisky.Size = new System.Drawing.Size(80, 93);
            this.btnWhisky.TabIndex = 3;
            this.btnWhisky.Text = "Whisky";
            this.btnWhisky.UseVisualStyleBackColor = true;
            // 
            // btnWine
            // 
            this.btnWine.Location = new System.Drawing.Point(128, 230);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(80, 93);
            this.btnWine.TabIndex = 4;
            this.btnWine.Text = "Wine";
            this.btnWine.UseVisualStyleBackColor = true;
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(273, 230);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(80, 43);
            this.btnCash.TabIndex = 5;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.Location = new System.Drawing.Point(381, 230);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(80, 43);
            this.btnCreditCard.TabIndex = 6;
            this.btnCreditCard.Text = "信用卡";
            this.btnCreditCard.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(684, 355);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 43);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Frm_0705_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreditCard);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnWine);
            this.Controls.Add(this.btnWhisky);
            this.Controls.Add(this.btnTequila);
            this.Controls.Add(this.btnBeer);
            this.Controls.Add(this.listBox1);
            this.Name = "Frm_0705_POS";
            this.Text = "Frm_0705_POS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.Button btnTequila;
        private System.Windows.Forms.Button btnWhisky;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnClear;
    }
}