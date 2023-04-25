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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_0703_Hello frm1 = new Frm_0703_Hello();
            frm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_0704_Loan frm2 = new Frm_0704_Loan();
            frm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_0708_StructForm frm3 = new Frm_0708_StructForm();
            frm3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_0711_Method frm4 = new Frm_0711_Method();
            frm4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_0712_MyClac frm5 = new Frm_0712_MyClac();
            frm5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_0712_ForDoWhile frm6 = new Frm_0712_ForDoWhile();
            frm6.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Frm_0716_OXGame frm7 = new Frm_0716_OXGame();
            frm7.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Frm_Notepad frm8 = new Frm_Notepad();
            frm8.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Frm_Drawpaint frm9 = new Frm_Drawpaint();
            frm9.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Frm_ScreenSaver frm10 = new Frm_ScreenSaver();
            frm10.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Frm_PictureViewer frm11 = new Frm_PictureViewer();
            frm11.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Frm_0705_POS frm12 = new Frm_0705_POS();
            frm12.ShowDialog();
        }
    }
}
