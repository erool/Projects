using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kararyapılari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
               
                

            if (sayi1>sayi2)
            {
                MessageBox.Show(sayi1 + " sayı " + sayi2 + " den buyuk");
            }
            else
            {
                MessageBox.Show(sayi2 + " sayı " + sayi1 + " den buyuk");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rasgele = new Random();
           
            for (int i = 0; i < 4; i++)
            {
                button1.BackColor = Color.Red;
            }
        }
    }
}
