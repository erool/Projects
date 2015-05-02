using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fak_dongu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            int top = 1;
            for (int i = 1; i <= sayi; i++)
            {
                top = top * i;
            }
            label1.Text = top.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int sayi = Convert.ToInt32(textBox1.Text);
                int top = 1;
                int i = 1;
                while (i <= sayi)
                {
                    top = top * i;
                    i++;
                }
                label1.Text = top.ToString();
            }
        }
    }
}
