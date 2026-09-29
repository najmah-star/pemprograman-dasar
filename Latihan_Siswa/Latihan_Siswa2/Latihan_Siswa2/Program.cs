using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Siswa2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. buat program yang menerima suhu. jika suhu >= 30 tampilkan "Panas", 20-29 "Sejuk", dan < 20 "Dingin"
            Console.Write("masukkan suhu: ");
            int suhu = Convert.ToInt32(Console.ReadLine());

            if (suhu >= 30)
            {
                Console.WriteLine("Panas");
            }
            else if (suhu >= 20)
            {

                Console.WriteLine("sejuk");
            }
            else
            {

                Console.WriteLine("Dingin");
            }

        }
    }
}
