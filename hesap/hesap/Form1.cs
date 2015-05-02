using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string girilensayi;
        int gecmis=0;
        bool topla, carp, bol, cikar;
        int sonuc = 0;
        private void btn1_Click(object sender, EventArgs e)
        {
            girilensayi += btn1.Text;
            textBox1.Text = girilensayi;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            girilensayi += btn2.Text;
            textBox1.Text = girilensayi;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            girilensayi += btn3.Text;
            textBox1.Text = girilensayi;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            girilensayi += btn4.Text;
            textBox1.Text = girilensayi;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            girilensayi += btn5.Text;
            textBox1.Text = girilensayi;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            girilensayi += btn6.Text;
            textBox1.Text = girilensayi;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            girilensayi += btn7.Text;
            textBox1.Text = girilensayi;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            girilensayi += btn8.Text;
            textBox1.Text = girilensayi;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            girilensayi += btn9.Text;
            textBox1.Text = girilensayi;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            girilensayi += btn0.Text;
            textBox1.Text = girilensayi;
        }

        private void btnarti_Click(object sender, EventArgs e)
        {
            
            gecmis = Convert.ToInt32(girilensayi);
            topla = true;
            textBox1.Text = "";
            girilensayi = "";
            
        }

        private void btneksi_Click(object sender, EventArgs e)
        {
            
            gecmis = Convert.ToInt32(girilensayi);
            cikar = true;
            textBox1.Text = "";
            girilensayi = "";
       
        }

        private void btnbolu_Click(object sender, EventArgs e)
        {
            
            gecmis = Convert.ToInt32(girilensayi);
            bol = true;
            textBox1.Text = "";
            girilensayi = "";
        
        }

        private void btncarpi_Click(object sender, EventArgs e)
        {
           
            gecmis = Convert.ToInt32(girilensayi);
            carp = true;
            textBox1.Text = "";
            girilensayi = "";
          
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            girilensayi = "";
            textBox1.Text = "";
           
        }

        private void btnesittir_Click(object sender, EventArgs e)
        {
            if(topla)
            {
                sonuc = gecmis + Convert.ToInt32(textBox1.Text);
                textBox1.Text = sonuc.ToString();
            }
            else if(bol)
            {
                sonuc = gecmis /Convert.ToInt32(textBox1.Text);
                textBox1.Text = sonuc.ToString();
            }
            else if(cikar)
            {
                sonuc = gecmis - Convert.ToInt32(textBox1.Text);
                textBox1.Text = sonuc.ToString();
            }
            else if(carp)
            {
                sonuc = gecmis * Convert.ToInt32(textBox1.Text);
                textBox1.Text = sonuc.ToString();
            }
        }
    }
}
