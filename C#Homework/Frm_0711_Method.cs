using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Homework
{
    public partial class Frm_0711_Method : Form
    {
        public Frm_0711_Method()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;

            if (int.TryParse(txtNumber.Text, out number))
            {
                if (number % 2 == 0)
                {
                    labResult1.Text = "輸入的數字為偶數。";
                }
                else
                {
                    labResult1.Text = "輸入的數字為奇數。";
                }
            }
            else
            {
                MessageBox.Show("請輸入正確數字!");
                txtNumber.Clear();
                txtNumber.Focus();
            }
        }

        private void btnArray1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int oddCount = 0;
            int evenCount = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
                labResult1.Text = "奇數有" + oddCount + "個," + "偶數有" + evenCount + "個";
            }
        }

        private void btnArray3_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int max = numbers[0]; // 假設第一個元素是最大的
            int min = numbers[0]; // 假設第一個元素是最小的

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max) // 如果有更大的元素，則更新max的值
                {
                    max = numbers[i];
                }

                if (numbers[i] < min) // 如果有更小的元素，則更新min的值
                {
                    min = numbers[i];
                }
            }
            labResult1.Text = "最大值為" + max + "最小值為" + min;
        }

        private void btnArray2_Click(object sender, EventArgs e)
        {
            string[] names = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            string longestName = names[0]; // 假設第一個名字是最長的

            for (int i = 1; i < names.Length; i++)
            {
                if (names[i].Length > longestName.Length) // 如果有更長的名字，則更新longestName的值
                {
                    longestName = names[i];
                }
            }
            labResult1.Text = "最長的名字為" + longestName;
        }

        private void btnArray4_Click(object sender, EventArgs e)
        {
            string[] words = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            int countBigC = 0; // 初始值為0，用於計算大寫C的數量
            int countSmallC = 0; // 初始值為0，用於計算小寫c的數量
            int result;
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] == 'C')
                    {
                        countBigC++; // 如果該字母是大寫C，則將大寫C的計數器加1
                    }
                    else if (word[j] == 'c')
                    {
                        countSmallC++; // 如果該字母是小寫c，則將小寫c的計數器加1
                    }

                }
            }
            result = countBigC + countSmallC;
            labResult1.Text = "有C或c的共有" + result + "個";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int sum = 0; // 初始值為0，用於計算總和

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i]; // 將每個元素加到總和上
            }
            labResult1.Text = "總和為" + sum;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            labResult1.Text = "最大值為" + max;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            labResult1.Text = "最小值為" + min;
        }
        void Swap(ref int A, ref int B)
        {
            int T = A; // 使用中間變量保存a的值
            A = B;        // 將b的值賦給a
            B = T;     // 將中間變量T的值賦給b
        }
        private void btnSwap_Click(object sender, EventArgs e)
        {
            int A = 100; int B = 200;
            Swap(ref A, ref B);
            labResult1.Text = ($"a:{A},b:{B}");
        }

        private void btn2Array1_Click(object sender, EventArgs e)
        {
            int[,] array = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 || i == 9 || j == 0 || j == 9)
                    {
                        array[i, j] = 1;
                    }
                }
            }
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result += (array[i, j] + " ");
                }
                result += "\n";
            }
            labResult1.Text = result;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            labResult1.Text = " ";
        }

        private void btn2Array2_Click(object sender, EventArgs e)
        {
            {
                int[,] array = new int[10, 10];

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (i == 0 || i == 9 || j == 0 || j == 9)
                        {
                            array[i, j] = 0;
                        }
                        else
                        {
                            array[i, j] = 1;
                        }
                    }
                }

                string result = "";
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        result += (array[i, j] + " ");
                    }
                    result += "\n";
                }
                labResult1.Text = result;
            }
        }

        private void btn2Array3_Click(object sender, EventArgs e)
        {
            int[,] array = new int[10, 10];

            // 初始化 1 和 0 的格子
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        array[i, j] = 1;
                    }
                    else
                    {
                        array[i, j] = 0;
                    }
                }
            }

            // 設定第一列的格子值
            for (int j = 0; j < 10; j++)
            {
                if (j % 2 == 1)
                {
                    array[0, j] = 0;
                }
                else
                {
                    array[0, j] = 1;
                }
            }

            // 將二維陣列轉換為字串
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result += array[i, j] + " ";
                }
                result += "\n";
            }
            labResult1.Text = result;
        }

    }
}
