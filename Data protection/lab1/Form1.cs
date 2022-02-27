using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        string A = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ_";
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string str_orig = "";
            string str_encryp = "";
            int shift = 0;
            textBox2.Text = "";
            str_orig = textBox1.Text;
            shift = (int)numericUpDown1.Value;
            for(int i=0; i<str_orig.Length; i++)
                str_encryp += A[(A.IndexOf(str_orig[i]) + shift)%A.Length];
            textBox2.Text = str_encryp;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string str_orig = "";
            string str_encryp = "";
            int shift = 0;
            textBox3.Text = "";
            str_encryp = textBox4.Text;
            shift = (int)numericUpDown2.Value;
            for (int i = 0; i < str_encryp.Length; i++)
                str_orig += A[(A.IndexOf(str_encryp[i]) - shift + A.Length) % A.Length];
            textBox3.Text = str_orig;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string str_orig = "";
            string str_encryp = "";
            richTextBox1.Text = "";
            str_encryp = textBox5.Text;
            int sh = 1;
            for (sh=1; sh<A.Length; sh++)
            {
                for (int i = 0; i < str_encryp.Length; i++)
                    str_orig += A[(A.IndexOf(str_encryp[i]) - sh + A.Length) % A.Length];
                richTextBox1.Text += sh.ToString() + ':' + str_orig + "\n";
                str_orig = "";
            }
        }
    }
}
