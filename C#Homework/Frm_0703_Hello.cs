using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C_Homework
{
    public partial class Frm_0703_Hello : Form
    {
        public Frm_0703_Hello()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            String Name = txtName.Text + ",\n";
            String EnglishName = txtEnglishName.Text + ",\n";
            String Gender = txtGender.Text + ",\n";
            String Horoscope = txtHoroscope.Text + ",\n";
            MessageBox.Show("Hello , 我是" + Name + "英文姓名是" + EnglishName + "性別是" + Gender + "星座是" + Horoscope + "很高興認識你");
        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            String Name = txtName.Text + ",\n";
            String EnglishName = txtEnglishName.Text + ",\n";
            String Gender = txtGender.Text + ",\n";
            String Horoscope = txtHoroscope.Text + ",\n";
            MessageBox.Show("Hi , 我是" + Name + "英文姓名是" + EnglishName + "性別是" + Gender + "星座是" + Horoscope + "很高興認識你");
        }
    }
}
