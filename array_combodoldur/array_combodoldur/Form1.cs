using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace array_combodoldur
{
    public partial class Form1 : Form
    {
  
        
    

        public Form1()
        {
            InitializeComponent();
        }
        //List<string> liste = new List<string>();
        //string[] ekle=new string[4];
        int sayac = 0;
        ArrayList cokekle = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            
            //ekle[sayac] = txtdeger.Text;
    
            //string deger=txtdeger.Text;
            //if(!liste.Contains(deger))
            //    liste.Add(deger);
            
            cokekle[sayac] = txtdeger.Text;
            sayac++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Clear();
            //foreach (string item in liste)
            // {
            //comboBox1.Items.Add(item);
            //    }
            comboBox1.Items.Clear();
            foreach (var item in cokekle )
            {
                comboBox1.Items.Add(item);
            }
        }
    }
}
