﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datetimepicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            for (int i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 12; i++)
            {
                if(i<10)
                {
                    comboBox2.Items.Add(0+i.ToString());
                }
                else if(i>=10)
                {
                    comboBox2.Items.Add(i.ToString());
                }

                //comboBox2.Items.Add(i.ToString());
               
              
            }
            for (int i = 1990; i <=DateTime.Now.Year; i++)
            {
                comboBox3.Items.Add(i.ToString());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
