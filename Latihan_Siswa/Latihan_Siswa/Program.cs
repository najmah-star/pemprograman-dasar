using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Siswa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Latihan Siswa 

            // 1. buat program yang menerima sebuah bilangan dan menampilkan "Genap" atau "Ganjil"
            Console.Write("masukkan sebuah bilangan: ");
            int bilangan = Convert.ToInt32(Console.ReadLine());

            if (bilangan % 2 == 0)
            {
                Console.WriteLine("Genap");
            }
            else
            {
                Console.WriteLine("Ganjil");
            }
        }
    }
}
