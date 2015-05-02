using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @try
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            bool ilkihatalimi = true;
            int say1, say2;
            try
            {
                say1 = Convert.ToInt32(txtsayi1.Text);
                ilkihatalimi = false;
                say2 = Convert.ToInt32(txtsayi2.Text);
            }
                catch(FormatException fex)
            {
                if (ilkihatalimi)
                {
                    int cevrilensayi;
                    bool donustur = int.TryParse(txtsayi2.Text, out cevrilensayi);
                    if (int.TryParse(txtsayi2.Text, out cevrilensayi))
                    {
                        MessageBox.Show("birinci deger hatalı"+fex.Message);
                    }
                    else
                    {
                        MessageBox.Show("her ikide  deger hatalı");
                    }
                }
                else
                {
                    MessageBox.Show("ikinci  deger hatalı");
                }
            }
            catch (Exception)
            {
                if(ilkihatalimi)
                {
                    int cevrilensayi;
                    bool donustur=int.TryParse(txtsayi2.Text,out cevrilensayi);
                    if(int.TryParse(txtsayi2.Text,out cevrilensayi))
                    {
                        MessageBox.Show("birinci deger hatalı");
                    }
                    else
                    {
                        MessageBox.Show("her ikide  deger hatalı");
                    }
                }
                else
                {
                    MessageBox.Show("ikinci  deger hatalı");
                }
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
