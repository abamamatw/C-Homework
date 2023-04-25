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
    public partial class Frm_0708_StructForm : Form
    {
        public Frm_0708_StructForm()
        {
            InitializeComponent();
        }
        int a = 0;
        bool b = false;
        bool c = false; 
        private void btnSave_Click(object sender, EventArgs e)
        {
            b= true;
        }

        private void btnSaveShow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text)|| string.IsNullOrEmpty(txtChinese.Text)|| string.IsNullOrEmpty(txtEnglish.Text)
                || string.IsNullOrEmpty(txtMath.Text))
            {
                txtShow.Text = "姓名:" + Environment.NewLine + "國文:"+a + Environment.NewLine + "英文:"+a
                    + Environment.NewLine + "數學:"+a;
                b= false;
                c = true;
            }
            else
            {
                if (b)
                {
                    txtShow.Text = "姓名:" +txtName.Text+Environment.NewLine + 
                        "國文:" + txtChinese.Text + Environment.NewLine + "英文:" + txtEnglish.Text
                    + Environment.NewLine + "數學:" + txtMath.Text;
                    b= false;
                    c = true;
                }
            }
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtChinese.Text) || string.IsNullOrEmpty(txtEnglish.Text)
                || string.IsNullOrEmpty(txtMath.Text))
            {
                txtGrade.Text = "最高分科目為:" + Environment.NewLine + "最低分科目為:";
                c= false;
            }
            else
            { if (c)
                {
                    Dictionary <string,int> dic = new Dictionary<string,int>();
                    dic.Add("國文",int.Parse(txtChinese.Text));
                    dic.Add("英文",int.Parse(txtEnglish.Text));
                    dic.Add("數學",int.Parse(txtMath.Text));
                    int maxscore = dic.Values.Max();
                    int minscore = dic.Values.Min();
                    string maxname = dic.FirstOrDefault(x => x.Value == maxscore).Key;
                    string minname = dic.FirstOrDefault(x => x.Value == minscore).Key;
                txtGrade.Text= "最高分科目為:"+maxname+maxscore+"分"+ Environment.NewLine + "最低分科目為:"+minname+minscore+"分";
                } 
            }
        }
    }
}
