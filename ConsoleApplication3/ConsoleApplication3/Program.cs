using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int fak = 0;
            int top = 1;
            Console.WriteLine("faktoriyel gir");
            fak = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= fak; i++)
            {
                top = top * i;
            }
            Console.WriteLine("faktoriyel={0}",top);
            Console.ReadKey();
        }
    }
}
