using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float sayi1, sayi2;
            float ort;
            sayi1 = Convert.ToSingle(txtsayi1.Text);
            sayi2 = Convert.ToSingle(txtsayi2.Text);
            ort = sayi1 / sayi2;
            MessageBox.Show(ort.ToString());
          

        }
    }
}
