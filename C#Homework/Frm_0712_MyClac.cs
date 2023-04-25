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
    public partial class Frm_0712_MyClac : Form
    {
        public Frm_0712_MyClac()
        {
            InitializeComponent();
        }
        
        private void btnplus_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            if (!int.TryParse(txtNum1.Text, out num1) || !int.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("請輸入有效的整數");
                return;
            }

            int sum = num1 + num2;
            txtAnswer.Text = sum.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            if (!int.TryParse(txtNum1.Text, out num1) || !int.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("請輸入有效的整數");
                return;
            }

            int minus = num1 - num2;
            txtAnswer.Text = minus.ToString();
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            if (!int.TryParse(txtNum1.Text, out num1) || !int.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("請輸入有效的整數");
                return;
            }

            int times = num1 * num2;
            txtAnswer.Text = times.ToString();
        }

        private void btnDividedBy_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            if (!int.TryParse(txtNum1.Text, out num1) || !int.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("請輸入有效的整數");
                return;
            }

            int dividedby = num1 / num2;
            txtAnswer.Text = dividedby.ToString();
        }

       
    }
 }   

