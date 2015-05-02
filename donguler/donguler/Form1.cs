using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            int sayac = 0;
            for (int i = 1; i < 100; i++)
            {
                if(i%2==0)
                listBox1.Items.Add(i.ToString());
                if (i % 3 == 0)
                    listBox2.Items.Add(i.ToString());
                if (i % 6 == 0)
                {
                    sayac++;
                    listBox3.Items.Add(i.ToString());
                    
                }
              
                   
            }
            MessageBox.Show(sayac.ToString());
        }
    }
}
