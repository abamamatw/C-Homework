using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Homework
{
    public partial class Frm_ScreenSaver : Form
    {
        public Frm_ScreenSaver()
        {
            InitializeComponent();
        }

        private void Frm_ScreenSaver_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        Random rd = new Random();
        int speedX = 12;
        int speedY = 12;
        private void timer1_Tick(object sender, EventArgs e)
        {
            picbox1.Text = DateTime.Now.ToString();
            picbox1.Left += speedX;
            picbox1.Top += speedY;

            if (picbox1.Left < 0 || picbox1.Right > this.ClientSize.Width)
            {
                speedX = -speedX; //改變方向
            }

            if (picbox1.Top < 0 || picbox1.Bottom > this.ClientSize.Height)
            {
                speedY = -speedY; //改變方向
            }
        }
        int mmx, mmy;
        private void Frm_ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            mmx = e.X; mmy = e.Y;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            int D = rd.Next(this.Height);
            int X = rd.Next(this.Width - D);
            int Y = rd.Next(this.Height - D);
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillEllipse(Brushes.Blue, X, Y, D, D);
            g.DrawLine(Pens.Black, 0, mmy, this.Width, mmy);
            g.DrawLine(Pens.Black, mmx, 0, mmx,this.Width);
            this.BackgroundImage = bmp;

            foreach (Control c in this.Controls)
            {
                if (c is PictureBox)
                {
                    c.Left += rd.Next(11) - 5;
                    c.Top += rd.Next(11) - 5;
                    if (c.Left < 0) c.Left = 0;
                    if (c.Top < 0) c.Top = 0;
                    if (c.Right > this.ClientSize.Width) c.Left = this.ClientSize.Width - c.Width;
                    if (c.Bottom > this.ClientSize.Height) c.Top = this.ClientSize.Height - c.Height;
                }
            }
        }

        
    }
}
        

   