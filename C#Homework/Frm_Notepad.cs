using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace C_Homework
{
    public partial class Frm_Notepad : Form
    {
        public Frm_Notepad()
        {
            InitializeComponent();
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtNotepad.Text=File.ReadAllText(openFileDialog1.FileName,Encoding.Default);
            }
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, txtNotepad.Text,Encoding.Default);
            }
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.FileName == "")
            {
                if(saveFileDialog1.ShowDialog()==DialogResult.OK) 
                {
                    File.WriteAllText(saveFileDialog1.FileName,txtNotepad.Text,Encoding.Default);
                }
            }
            else
            {
                File.WriteAllText(openFileDialog1.FileName, txtNotepad.Text, Encoding.Default);
            }
        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            txtNotepad.Clear();
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.SelectAll();
        }

        private void 字型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            txtNotepad.Font = fontDialog1.Font;
        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtNotepad.ForeColor = colorDialog1.Color;
        }
    }
}
