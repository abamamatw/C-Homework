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
    public partial class Guess : Form
    {
        public Guess()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //int guess;
            //Random random = new Random();
            //int secretNumber = random.Next(1, 101); // 產生1~10的隨機數字
            //labGuessNumber.Text = "";
            //if (!int.TryParse(txtNumber.Text, out guess)) // 檢查輸入是否為整數
            //{
            //    MessageBox.Show("請輸入有效的整數！");
            //    return;
            //}

            //if (guess < secretNumber)
            //{
            //    labGuessNumber.Text = "太小了，再猜一次！";
            //}
            //else if (guess > secretNumber)
            //{
            //    labGuessNumber.Text = "太大了，再猜一次！";
            //}
            //else
            //{
            //    labGuessNumber.Text = "恭喜你猜對了！";
            //}
        }
    }
}
