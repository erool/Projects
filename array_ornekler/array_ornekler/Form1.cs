using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array_ornekler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rx = new Random();
        List<int> ekle = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            lbldeger1.Text = rasgelesayigetir();

            lbldeger1.Text = rasgelesayigetir();
            lbldeger2.Text = rasgelesayigetir();
            lbldeger3.Text = rasgelesayigetir();
            lbldeger4.Text = rasgelesayigetir();
            lbldeger5.Text = rasgelesayigetir();
            lbldeger6.Text = rasgelesayigetir();

           
        }

        private string rasgelesayigetir()
        {
            int sayi = rx.Next(0,50);
            return sayi.ToString();
        }
    }
}
