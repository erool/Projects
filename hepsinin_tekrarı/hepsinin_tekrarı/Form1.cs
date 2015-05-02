using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hepsinin_tekrarı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int xb=0;
        int yb=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Button btn = new Button();
            //btn.Location = new Point(10,30);
            //btn.Size = new System.Drawing.Size(50,50);
            //gbkoltuklar.Controls.Add(btn);

            //Button btn2 = new Button();
            //btn2.Location = new Point(10+btn.Width+10, 30);
            //btn2.Size = new System.Drawing.Size(50, 50);
            //gbkoltuklar.Controls.Add(btn2);

        

          
        }
        private void KoltuklariYarat(int widht, int height)
        {
            gbKoltuklar.Controls.Clear();
            gbKoltuklar.Width = (widht + 1) * (50 + 10) + 10;

            int koridorBasindakiKoltuk = (widht / 2) - 1;
            int sonKoltuk = height - 1;
            // Her X sırasındaki koltuk sayısı kadar dongu
            for (int x = 0; x < widht; x++)
            {
               

                // Her Y sırasındaki koltuk sayısı kadar dongu
                for (int y = 0; y < height; y++)
                {
                    KoltukYarat(x, y, (x > koridorBasindakiKoltuk));
                    // Arka Koltukları beşlemek için kordor boşluğuna bir buton daha atıldı
                    if (x == koridorBasindakiKoltuk && y == sonKoltuk)
                        KoltukYarat(x + 1, y, false);
                }
            }
        }

        // Group Box içine koltukları buton olarak yaratır
        private void KoltukYarat(int x, int y, bool koridorVarmi)
        {
           if(y==0)
           {
               Button btn = new Button();
               btn.Location = new Point(10,20);
               btn.Size = new System.Drawing.Size(110, 50);
               gbKoltuklar.Controls.Add(btn);
           }
           else
           {

          
           if(x>=(xb/2) && (y==yb/2))
           { 
           
           }
           else
           {
               Button btn = new Button();
               btn.Location = GetLocation(x, y, koridorVarmi);
               btn.Size = new System.Drawing.Size(50, 50);
               gbKoltuklar.Controls.Add(btn);

           }
           }
        }

        // Koltuğun konumuna göre groupbox taki orjinal location degerini dondurur
        private Point GetLocation(int x, int y, bool koridorVarmi)
        {
            int pointX = 10 + (x * 60);
            int pointY = 30 + (y * 60);
            int koridor = 60;
            if (koridorVarmi)
                pointX += koridor;//pointX = pointX + koridor;

            Point p = new Point();
            p.X = pointX;
            p.Y = pointY;

            return p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             xb =Convert.ToInt32(textBox1.Text);
            yb = Convert.ToInt32(textBox2.Text);
            
            KoltuklariYarat(xb, yb);
        }

       
    }
}
