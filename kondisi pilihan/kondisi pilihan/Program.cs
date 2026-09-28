using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kondisi_pilihan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Percabangan IF Tunggal & IF-ELSE

            Console.Write("Masukkan nilai siswa");
            int nilai =
            int.Parse(Console.ReadLine());

            if (nilai >= 75)
            {
                Console.WriteLine("Selamat Anda Dinyatakan LULUS");
            }
            else
            {
                Console.WriteLine("Mohon maaf, Anda harus mengikuti REMIDI");
            }

            Console.Write("Masukkan nilai ujian: ");
            int nilai1 =
            int.Parse(Console.ReadLine());

            string grade;

            if (nilai >= 90)
            {
                grade = "A (Sangat Baik)";
            }
            else if (nilai >= 80)
            {
                grade = "B (Baik)";
            }
            else if (nilai >= 70)
            {
                grade = "C (Cukup)";
            }
            else
            {
                grade = "D (Kurang)";
            }

            Console.WriteLine($"Grade Anda: {grade}");

            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            if (username == "nana_BSK-alok")
            {
                if (password == "nanotnat")
                {
                    Console.WriteLine("Login berhasil! Selamat datang, Admin.");
                }
                else
                {
                    Console.WriteLine("Password salah.");
                }
            }
            else
            {
                Console.WriteLine("Username salah.");
            }





















            }
    }
}
