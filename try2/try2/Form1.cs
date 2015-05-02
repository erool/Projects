using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace try2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int red, green, blue;
        private void button1_Click(object sender, EventArgs e)
        {
           
            timer1.Enabled = true;
            //tur=0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        int tur = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            red = rnd.Next(0, 256);
            green = rnd.Next(0, 256);
            blue = rnd.Next(0, 256);

            Color renk1 = Color.FromArgb(red,green,blue);
            red = rnd.Next(0, 256);
            green = rnd.Next(0, 256);
            blue = rnd.Next(0, 256);
            Color renk2 = Color.FromArgb(red, green, blue);

            zar1.BackColor = renk1;
            zar2.BackColor = renk2;

            int sayi1, sayi2;
            sayi1 = rnd.Next(1, 7);
            sayi2 = rnd.Next(1, 7);
            zar1.Text = sayi1.ToString();
            zar2.Text = sayi2.ToString();
            tur++;
            if (tur == 20)
            {
                timer1.Enabled = false;
                tur = 0;
            }
        }
        
    }
}
