using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Homework
{
    public partial class Frm_0712_ForDoWhile : Form
    {
        public Frm_0712_ForDoWhile()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labResult1.Text = " ";
        }

        //}
        private void btnTree_Click(object sender, EventArgs e)
        {
            int height;
            if (!int.TryParse(txtRows.Text, out height))
            {
                MessageBox.Show("請輸入正確的整數");
                return;
            }

            labResult1.Text = "";//先清空文字
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    labResult1.Text += "*";
                }
                labResult1.Text += "\n";
            }
        }

        private void btnbinary_Click(object sender, EventArgs e)
        {
            int num = 100;
            string binary = Convert.ToString(num, 2);
            labResult1.Text = binary;
        }

        private void btnLottery_Click(object sender, EventArgs e)
        {
            int[] lottery = new int[6];  // 宣告長度為 6 的整數陣列
            Random random = new Random(Guid.NewGuid().GetHashCode());  // 產生亂數物件

            for (int i = 0; i < lottery.Length; i++)
            {
                int num;
                do
                {
                    num = random.Next(1, 50);  // 隨機產生一個整數，範圍在 1 到 49 之間
                } while (lottery.Contains(num));  // 如果這個數字已經出現過，就繼續產生新的數字

                lottery[i] = num;  // 將這個數字放入陣列中
            }

            Array.Sort(lottery);  // 將陣列中的元素排序
            string result = "樂透號碼:";
            foreach (int num in lottery)
            {
                result += num + " ";
            }
            labResult1.Text = result;  // 輸出樂透號碼
        }

        private void btn99times_Click(object sender, EventArgs e)
        {
            labResult1.Text = ""; // 清空文字
            for (int j = 1; j <= 9; j++)
            {
                for (int i = 2; i <= 9; i++)
                {
                    labResult1.Text += i + "*" + j + "=" + (i * j).ToString().PadLeft(2, ' ') + "  "; ;

                }
                labResult1.Text += "\n";
            }
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            try
            {
                int sum = 0;
                int from = int.Parse(txtFrom.Text);
                int to = int.Parse(txtTo.Text);
                int step = int.Parse(txtStep.Text);

                for (int i = from; i <= to; i += step)
                {
                    labResult1.Text += i + " ";
                    sum += i;
                }

                labResult1.Text = "從" + txtFrom.Text + "到" + txtTo.Text + "相隔2\n加總為" + sum;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("輸入的數值格式有誤，請重新輸入。" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void btnDo_Click(object sender, EventArgs e)
        {
            try

            {
                int sum = 0;
                int from = int.Parse(txtFrom.Text);
                int to = int.Parse(txtTo.Text);
                int step = int.Parse(txtStep.Text);

                int i = from;
                do
                {
                    labResult1.Text += i + " ";
                    sum += i;
                    i += step;
                } while (i <= to);

                labResult1.Text = "從" + txtFrom.Text + "到" + txtTo.Text + "相隔2\n加總為" + sum;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("輸入的數值格式有誤，請重新輸入。" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            try
            {

            
            int sum = 0;
            int from = int.Parse(txtFrom.Text);
            int to = int.Parse(txtTo.Text);
            int step = int.Parse(txtStep.Text);

            int i = from;
            while (i <= to)
            {
                labResult1.Text += i + " ";
                sum += i;
                i += step;
            }

            labResult1.Text = "從" + txtFrom.Text + "到" + txtTo.Text + "相隔2\n加總為" + sum;}
            catch (FormatException ex)
            {
                MessageBox.Show("輸入的數值格式有誤，請重新輸入。" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
