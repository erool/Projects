using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arraay2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //List<string> arraylist = new List<string>();
        string[] kk=new string[0];
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string deger = textBox1.Text;
            //if (!arraylist.Contains(deger))
            //    arraylist.Add(deger);

            if(!varmixx(deger))
            {
                Array.Resize(ref kk, kk.Length+1);
                kk[kk.Length - 1] = deger;
            }
        }

        private bool varmixx(string deger)
        {
            bool varmi = false;
            for (int i = 0; i < kk.Length; i++)
            {
                string item = kk[i];
                if (item == deger)
                {
                    varmi = true;
                    break;
                }
                   
            }
            return varmi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //foreach (string item in arraylist)
            //{
            //    listBox1.Items.Add(item);
            //}

            cbListe.Items.Clear();
            foreach (string item in liste)
            {
                cbListe.Items.Add(item);
            }
        }
    }
}
