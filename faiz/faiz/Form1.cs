using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int anapara = 0;
            //int faiz=0;
            //int vade=0;
            //float ort;
            //anapara = Convert.ToInt32(textBox1.Text);
            //faiz = Convert.ToInt32(textBox2.Text);
            //vade = Convert.ToInt32(textBox3.Text);
            // ort=Convert.ToSingle(((anapara * vade)*faiz) / 100)/12;
            // label4.Text = "paramız=" + ort;
            decimal anapara = Convert.ToDecimal(textBox1.Text);
            decimal faizorani = Convert.ToDecimal(textBox2.Text);
            int vade = Convert.ToInt32(textBox3.Text);
            decimal hesapla = anapara * (faizorani / 100) * vade;
            label4.Text = "paramız" + (hesapla+anapara);
        }
    }
}
