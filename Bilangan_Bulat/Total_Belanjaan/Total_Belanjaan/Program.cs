using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_Belanjaan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Praktik 3
            // program diskon berdasarkan total belanja

            Console.Write("total belanja: ");
            double total = Convert.ToDouble(Console.ReadLine());

            double diskon;

            if (total >= 500000)
            {
                diskon = 0.15;
            }
            else if (total >= 250000)
            {
                diskon = 0.10;
            }
            else
            {
                diskon = 0;
            }

            double potongan = total * diskon;
            double bayar = total - potongan;

            Console.WriteLine("diskon : " + potongan);
            Console.WriteLine("bayar  : " + bayar);
        }
    }
}
