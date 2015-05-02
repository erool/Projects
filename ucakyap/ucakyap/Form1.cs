using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucakyap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yan = 0;
        int arka = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 2;
        }

        private void butonolustur_Click(object sender, EventArgs e)
        {
            yan = Convert.ToInt32(numxsira.Value);
            arka = Convert.ToInt32(numysira.Value);
            
            //int sayac = 1;
            for (int i = 0; i < yan; i++)
            {
                
                
                for (int j = 0; j < arka; j++)
                {
                    Button btn = new Button();
                    btn.Location = getlocation(i,j,i>=yan/2);
                    btn.Size = new System.Drawing.Size(30,30);
                    scanapanel.Panel2.Controls.Add(btn);
                    //btn.Text=(sayac++).ToString();
                    koltuk koltuk = new koltuk();
                    koltuk.xkonumu = i;
                    koltuk.ykonumu = j;
                    koltuk.cinsiyettipi = Cinsiyettipi.tanimlidegil;
                    btn.Text = "-";
                    btn.Click += btn_Click;
                    btn.Tag = koltuk;

                   
                }
            }

             
        }

        class koltuk
        {
        public int xkonumu;
        public int ykonumu;
        public Cinsiyettipi cinsiyettipi;
        }

        enum Cinsiyettipi
        {
            tanimlidegil=0,
            erkek=1,
            kadin=2,
            hicbiri=3
        }


        void btn_Click(object sender, EventArgs e)
        {
            Button btn=(sender as Button);
            koltuk koltuk = ((koltuk)btn.Tag);

            Cinsiyettipi cinsiyettipi = koltuk.cinsiyettipi;
            int xkonumu = koltuk.xkonumu;
            int ykonumu = koltuk.ykonumu;

            koltuk yankoltuk = yankoltugugetir(koltuk);

            //if (koltuk.cinsiyettipi != yankoltuk.cinsiyettipi)
            //{
                
            //}
            //else
            //{




                if (cinsiyettipi == Cinsiyettipi.tanimlidegil)
                {
                    if (rderkek.Checked)
                    {
                        if(yankoltuk.cinsiyettipi==Cinsiyettipi.erkek
                            || yankoltuk.cinsiyettipi==Cinsiyettipi.tanimlidegil
                            || yankoltuk.cinsiyettipi==Cinsiyettipi.hicbiri
                            )
                        {
                             btn.Text = "E";
                        btn.BackColor = Color.Red;
                        koltuk.cinsiyettipi = Cinsiyettipi.erkek;
                        btn.Tag = koltuk;
                        }else
                        {
                            MessageBox.Show("yan yana koltuklara aynı cinsiyet olması gerekiyor");
                        }
                       
                    }
                    else if (rdkiz.Checked)
                    {
                        if (yankoltuk.cinsiyettipi == Cinsiyettipi.kadin
                            || yankoltuk.cinsiyettipi == Cinsiyettipi.tanimlidegil
                            || yankoltuk.cinsiyettipi == Cinsiyettipi.hicbiri
                            )
                        {
                            btn.Text = "K";
                            btn.BackColor = Color.Blue;
                            koltuk.cinsiyettipi = Cinsiyettipi.kadin;
                            btn.Tag = koltuk;
                        }
                        else
                        {
                          DialogResult mesajsonuc= MessageBox.Show("yan yana koltuklara aynı cinsiyet olması gerekiyor","MessageBoxButtons.YesNo");
                            if(mesajsonuc==System.Windows.Forms.DialogResult.Yes)
                            {
                                btn.Text = "E";
                                btn.BackColor = Color.Red;
                                koltuk.cinsiyettipi = Cinsiyettipi.erkek;
                                btn.Tag = koltuk;
                            }
                        }

                        
                    }
                    else if (rdhicbiri.Checked)
                    {
                        
                      
                            btn.Text = "H";
                            btn.BackColor = Color.Purple;
                            koltuk.cinsiyettipi = Cinsiyettipi.hicbiri;
                            btn.Tag = koltuk;
                        

                        
                    }
                }

                else
                {
                    btn.Text = "-";

                    btn.BackColor = Color.Empty;
                    koltuk.cinsiyettipi = Cinsiyettipi.tanimlidegil;
                    btn.Tag = koltuk;
                }
            
        }

        private koltuk yankoltugugetir(koltuk koltuk)
        {
            koltuk yankoltuk = new koltuk();
            foreach (Control control in scanapanel.Panel2.Controls)
            {
                if(control is Button)
                {
                    Button btn=(control as Button);
                    koltuk dongukoltugu=((koltuk)btn.Tag);
                    if(koltuk.ykonumu==dongukoltugu.ykonumu)
                    {
                        
                        int artissayisi;
                        if(koltuk.xkonumu % 2==0)
                        {
                            artissayisi = 1;
                        }
                        else
                        {
                            artissayisi = -1;
                        }
                        if(dongukoltugu.xkonumu==koltuk.xkonumu+artissayisi)
                        {
                            yankoltuk = dongukoltugu;
                            break;
                        }
                    }
                }
            }
            return yankoltuk;
          
        }

        private Point getlocation(int x,int y,bool koridor)
        {
            Point p = new Point();
            int pointx = 10 + (x * 30);
            int pointy=30+(y*30);
            int kori = 30;
            if (koridor)
                pointx += kori;

            p.X = pointx;
            p.Y = pointy;
            return p;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "pencere")
            {
                foreach (Control control in scanapanel.Panel2.Controls)
                {
                    if (control is Button)
                    {
                        Button btn = (control as Button);
                        koltuk dongukoltugu = ((koltuk)btn.Tag);
                        if (dongukoltugu.xkonumu == 1 || dongukoltugu.xkonumu==2)
                        {

                            btn.Enabled = false;
                        }
                        else
                        {
                            btn.Enabled = true;
                        }
                    }
                }
            }
            else if (comboBox1.SelectedItem == "koridor")
            {
                foreach (Control control in scanapanel.Panel2.Controls)
                {
                    if (control is Button)
                    {
                        Button btn = (control as Button);
                        koltuk dongukoltugu = ((koltuk)btn.Tag);
                        if (dongukoltugu.xkonumu == 0 || dongukoltugu.xkonumu == 3)
                        {

                            btn.Enabled = false;
                        }
                        else
                        {
                            btn.Enabled = true;
                        }
                    }
                }
            }
            else
                MessageBox.Show("bi yer sec");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem=="hicbiri")
            {
                foreach (Control control in scanapanel.Panel2.Controls)
                {
                    if (control is Button)
                    {
                        Button btn = (control as Button);
                        koltuk dongukoltugu = ((koltuk)btn.Tag);

                        btn.Enabled = true;
                    }
                }
            }
            else if(listBox1.SelectedItem=="erkek")
            {
                foreach (Control control in scanapanel.Panel2.Controls)
                {
                    if (control is Button)
                    {
                        Button btn = (control as Button);
                        koltuk koltuk = ((koltuk)btn.Tag);

                        koltuk yankoltuk = yankoltugugetir(koltuk);
                        if (yankoltuk.cinsiyettipi == Cinsiyettipi.erkek)
                            btn.Enabled = true;
                        else
                            btn.Enabled = false;

                    }
                }

            }
            else if(listBox1.SelectedItem=="kadin")
            {
                foreach (Control control in scanapanel.Panel2.Controls)
                {
                    if (control is Button)
                    {
                        Button btn = (control as Button);
                        koltuk koltuk = ((koltuk)btn.Tag);

                        koltuk yankoltuk = yankoltugugetir(koltuk);
                        if (yankoltuk.cinsiyettipi == Cinsiyettipi.erkek)
                            btn.Enabled = true;
                        else
                            btn.Enabled = false;

                    }
                }
            }
            else
            {
                MessageBox.Show("secim yap");
            }
        }
      

      

       
        
    }
}
