using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayitahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ustsinir, altsınir, tahmin;
        private void button1_Click(object sender, EventArgs e)
        {
            ustsinir = 100;
            altsınir = 0;
            tahmin=(ustsinir+altsınir)/2;
            label1.Text = tahmin.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            altsınir = tahmin;
            tahmin=(altsınir+ustsinir)/2;
            label1.Text = tahmin.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ustsinir = tahmin;
            tahmin=(altsınir+ustsinir)/2;
            label1.Text = tahmin.ToString();
        }
    }
}
