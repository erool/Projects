using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Random rx = new Random();
            //Label[] lab = new Label[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    lab[i].Text = rx.Next(0, 10).ToString();
            //}
           
        }
        Random ran = new Random();
        private void button3_Click(object sender, EventArgs e)
        {
            at1.Left = 0;
            at2.Left = 0;
            timer1.Enabled = true;
            
        }
        decimal kazanilanpara = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
         
           
           
                at1.Left += ran.Next(5, 25);
                at2.Left += ran.Next(5, 15);


                
                int misli = Convert.ToInt32(comboBox1.Text);
            if((at1.Left+at1.Width>=label1.Left)&(at1.Left>at2.Left))
            {
                timer1.Enabled = false;
               if(rdnkirmizi.Checked)
               {
                   kazanilanpara += 1.70m * Convert.ToInt32(textBox1.Text)*misli;
                   MessageBox.Show("kazandınız\n kazanılan para"+kazanilanpara);
               }
                else
               {
                   kazanilanpara -= 1.70m * Convert.ToInt32(textBox1.Text) * misli;
                   MessageBox.Show("kalan para:"+kazanilanpara);
               }
               
                
            }
            else if ((at2.Left + at2.Width >= label1.Left) & (at2.Left > at1.Left))
            {
                timer1.Enabled = false;
                if (rdnsiyah.Checked)
                {
                    kazanilanpara += 3.200m * Convert.ToInt32(textBox1.Text) * misli;
                    MessageBox.Show("kazandınız\n kazanılan para" + kazanilanpara);
                }
                else
                {
                    kazanilanpara -= 3.20m * Convert.ToInt32(textBox1.Text) * misli;
                    MessageBox.Show("kalan para:" + kazanilanpara);
                }
                
            }
            else if((at1.Left+at1.Width==label1.Left)&(at2.Left+at2.Width==label1.Left))
            {
                timer1.Enabled = false;
                MessageBox.Show("berabere");
               
              
            }
           
           
        }
    }
}
