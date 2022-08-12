using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_main.Font = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_main.ForeColor = colorDialog1.Color;
            }
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_main.BackColor = colorDialog1.Color;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_main.Text = null;
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                txt_main.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(txt_main.Text);
                sw.Close();
            } 
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_main.Text = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (txt_main.Font.Italic == true)
            {
                txt_main.Font = new Font(txt_main.Font.FontFamily, txt_main.Font.Size);
            }
            else
            {
                txt_main.Font = new Font(txt_main.Font.FontFamily, txt_main.Font.Size, FontStyle.Italic);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (txt_main.Font.Underline == true)
            {
                txt_main.Font = new Font(txt_main.Font.FontFamily, txt_main.Font.Size);
            }
            else
            {
                txt_main.Font = new Font(txt_main.Font.FontFamily, txt_main.Font.Size, FontStyle.Underline);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_main.Font = new Font(cbx_font.Text, txt_main.Font.Size);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change font size txt_main
            txt_main.Font = new Font(txt_main.Font.FontFamily, Convert.ToInt32(cbx_size.Text));

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(txt_main.Font.Bold == true)
            {
                txt_main.Font = new Font(txt_main.Font.FontFamily, txt_main.Font.Size);
            }
            else
            {
                txt_main.Font = new Font(txt_main.Font.FontFamily, txt_main.Font.Size, FontStyle.Bold);
            }
        }

        private void myInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am build by M Faraz Ali with roll no 2021-CS-122 who s under study in Computer Science Department of University of Engineering and Technology, Lahore. He is curently pursuing his bachelors. I am his lab task.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbx_font.Text = txt_main.Font.FontFamily.Name;
            cbx_size.Text = txt_main.Font.Size.ToString();
        }
    }
}
