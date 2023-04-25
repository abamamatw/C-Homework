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
    public partial class Frm_0704_Loan : Form
    {
        public Frm_0704_Loan()
        {
            InitializeComponent();
        }

        private void btnMonthPay_Click(object sender, EventArgs e)
        {
            double Total = double.Parse(textBox1.Text);//貸款金額
            double YearToMonth = (double.Parse(textBox2.Text)) * 12;//期限月份數
            double ToMonthRate = ((double.Parse(textBox3.Text)) / 12) / 100;//月利率計算
            double FirstPay = double.Parse(textBox4.Text);//頭期款

            double AvgRatePay = Math.Pow((1 + ToMonthRate), YearToMonth) * ToMonthRate / (Math.Pow(1 + ToMonthRate, YearToMonth) - 1);
            String MonthPay;//月付款
            MonthPay = Convert.ToString(Math.Round(Math.Round(Total - FirstPay) * AvgRatePay));
            //math.round四捨五入
            MessageBox.Show("月付款:" + MonthPay + "元");
        }
        String TotalPay; String MonthPay;
        private void btnTotalPay_Click(object sender, EventArgs e)
        {
            double Total = double.Parse(textBox1.Text);//貸款金額
            double YearToMonth = (double.Parse(textBox2.Text)) * 12;//期限月份數
            double ToMonthRate = ((double.Parse(textBox3.Text)) / 12) / 100;//月利率計算
            double FirstPay = double.Parse(textBox4.Text);//頭期款

            double AvgRatePay = Math.Pow((1 + ToMonthRate), YearToMonth) * ToMonthRate / (Math.Pow(1 + ToMonthRate, YearToMonth) - 1);
            //String MonthPay;//月付款
            //String TotalPay;
            MonthPay = Convert.ToString(Math.Round(Total - FirstPay) * AvgRatePay);
            TotalPay = Convert.ToString(Math.Round(double.Parse(MonthPay) * YearToMonth));
            MessageBox.Show("總付款金額:" + TotalPay + "元");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            LoanShow ls = new LoanShow(textBox1.Text, textBox2.Text, textBox3.Text, MonthPay, TotalPay);
            ls.Show();
        }
    }
}
