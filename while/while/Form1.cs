﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i <= 100; i++)
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int i = 1;
            do
            {
                listBox1.Items.Add(i.ToString());
                i++;
            } while (i<=100);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int i=1;
            while (i<=100)
            {
                listBox1.Items.Add(i.ToString());
                i++;
            }
        }
    }
}
