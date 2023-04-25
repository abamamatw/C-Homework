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
    public partial class LoanShow : Form
    {
        public LoanShow(string AA, string BB, string CC, string DD, string EE)
        {
            InitializeComponent();
            txtAmount.Text = AA;
            txtYear.Text = BB;
            txtRate.Text = CC;
            txtMonthPay.Text = DD;
            txtTotalPay.Text = EE;

        }

    }
}
