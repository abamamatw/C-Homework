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
    public partial class Frm_PictureViewer : Form
    {
        public Frm_PictureViewer()
        {
            InitializeComponent();
        }

        private void Frm_PictureViewer_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pic1 pc1 = new Pic1();
            pc1.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Pic2 pc2 = new Pic2();
            pc2.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Pic3 pc3 = new Pic3();
            pc3.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Pic4 pc4 = new Pic4();
            pc4.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Pic5 pc5 = new Pic5();
            pc5.ShowDialog();
        }
    }
}
