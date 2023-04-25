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
    public partial class Frm_GuessNumber : Form
    {
        public Frm_GuessNumber()
        {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Guess gs = new Guess();
            gs.Show(); 
        }
        
    }
}

