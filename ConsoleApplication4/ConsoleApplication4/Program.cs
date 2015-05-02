using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] rakamlar = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("sayılarımızı giriniz");
            //    rakamlar[i] = Convert.ToInt16(Console.ReadLine());
            //}
            //foreach (var item in rakamlar)
            //{
            //    Console.WriteLine("rakamlarımız={0}",item);
            //}
            //Console.ReadKey();

            Random sayi = new Random();
            //StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                int xx = sayi.Next(0, 50);
               // char karekter = Convert.ToChar(sifre);
               // sb.Append(karekter);
            }
            Console.WriteLine(xx.ToString());
            Console.ReadKey();

            //float sayi1,sayi2;
            //decimal ort;
            //Console.WriteLine("birinci sayiyi gir");
            //sayi1 =Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("ikinci sayiyi gir");
            //sayi2 = Convert.ToSingle(Console.ReadLine());
            //ort = Convert.ToDecimal(sayi1 / sayi2);
            //Console.WriteLine("ortlama ={0}",ort);
            //Console.ReadKey();






        }

        public static object[] xx { get; set; }
    }
}
