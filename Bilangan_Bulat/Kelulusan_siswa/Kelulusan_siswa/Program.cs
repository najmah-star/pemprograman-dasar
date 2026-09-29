using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelulusan_siswa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Praktik 2

            Console.Write("Nama Siswa: ");
            string nama = Console.ReadLine();

            Console.Write("Nilai: ");
            int nilai = Convert.ToInt32(Console.ReadLine());

            if (nilai < 0 || nilai > 100)
            {
                Console.WriteLine("Nilai tidak valid");
            }
            else if (nilai >= 75)
            {
                Console.WriteLine(nama + " dinyatakan Tuntas.");
            }
            else
            {
                Console.WriteLine(nama + "dinyatakan Belum Tuntas.");



            }
        }
    }
}
