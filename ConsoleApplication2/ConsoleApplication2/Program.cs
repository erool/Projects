using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
          decimal  top=0;
            decimal sayac=0;
            decimal ort=0;
            string y="";
           basla:
                Console.WriteLine("bir sayı gir");
                x = Convert.ToInt16(Console.ReadLine());
                top=top+x;
                sayac++;
            ort=top/sayac;
               Console.WriteLine("sayı girmek istiyormusun");
            y=Console.ReadLine();
               if (y == "e")
               {
                   goto basla;
               }
               else
               {
                   Console.WriteLine("ortalama={0}", ort);
               }
               Console.ReadKey();
                
            
            
        }
    }
}
