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
    public partial class Frm_0716_OXGame : Form
    {
        bool drawX = true; // 標誌下一步要畫的圖案
        public Frm_0716_OXGame()
        {
            InitializeComponent();
        }


        private void Frm_0716_OXGame_Load(object sender, EventArgs e)
        {
            // 初始化遊戲畫面
            ResetGame();
        }

        private void ResetGame()
        {
            // 重置遊戲畫面
            drawX = true;
            //labelResult.Text = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button btn = Controls.Find("button" + i.ToString() + j.ToString(), true).FirstOrDefault() as Button;
                    btn.Text = "";
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "") // 確保按鈕還沒有被點擊過
            {
                btn.Text = drawX ? "X" : "O";
                drawX = !drawX; // 切換標誌
                CheckResult();
            }
        }
        private void CheckResult()
        {
            // 檢查遊戲結果
            string[,] board = new string[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button btn = Controls.Find("button" + i.ToString() + j.ToString(), true).FirstOrDefault() as Button;
                    board[i, j] = btn.Text;
                }
            }
            // 檢查橫排
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != "")
                {
                    MessageBox.Show(board[i, 0] + " wins!");
                    return;
                }
            }
            // 檢查直排
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == board[1, j] && board[1, j] == board[2, j] && board[0, j] != "")
                {
                    MessageBox.Show(board[0, j] + " wins!");
                    return;
                }
            }
            // 檢查對角線
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != "")
            {
                MessageBox.Show(board[0, 0] + " wins!");
                return;
            }
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != "")
            {
                MessageBox.Show(board[0, 2] + " wins!");
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
