using System;
using System.Collections.Generic;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BmiCalc> histories = new List<BmiCalc>();

            bool jalan = true;
            while (jalan)
            {
                Console.Clear();
                Console.WriteLine("==========================================");
                Console.WriteLine("Selamat datang di Aplikasi Kalkulator BMI!");
                Console.WriteLine("==========================================");
                Console.WriteLine("  Pilihan menu :");
                Console.WriteLine("     1. Hitung BMI");
                Console.WriteLine("     2. Histori Penghitungan");
                Console.WriteLine("     3. Keluar");
                Console.Write("Pilihan : ");
                int pilihanMenu;
                do
                {
                    try
                    {
                        pilihanMenu = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Masukkan angka 1, 2, atau 3");
                        continue;
                    }
                    break;
                } while (true);

                
                switch (pilihanMenu)
                {
                    case 1:
                        histories.Add(HitungBmi());
                        break;
                    case 2:
                        ShowHistories(histories);
                        break;
                    case 3:
                        jalan = false;  
                        Console.Clear();
                        Console.WriteLine("Aplikasi berhenti");
                        break;
                    default:
                        break;
                }
            }
        }

        public static BmiCalc HitungBmi()
        {
            BmiCalc bmiCalc = new BmiCalc();
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("           1. Hitung BMI");
            Console.WriteLine("===================================");

            //Proses input dan perhitungan
            bmiCalc.InputNama();
            bmiCalc.InputGender();
            bmiCalc.InputBB();
            bmiCalc.InputTB();
            bmiCalc.SetBmi(bmiCalc.CalcBmi());
            bmiCalc.SetKategori(bmiCalc.DecideCategory());

            //Output
            bmiCalc.PrintDetail();

            Console.WriteLine("\nTekan apa saja untuk kembali");
            Console.ReadKey();
            return bmiCalc;
        }

        public static void ShowHistories(List<BmiCalc> histories)
        {
            Console.Clear();
            Console.WriteLine("=========================");
            Console.WriteLine(" 2. Histori Penghitungan");
            Console.WriteLine("=========================");
            Console.WriteLine($"No. |{"Nama",15} | {"Gender",10} | {"TB",5} | {"BB",5} | {"BMI",5} | {"Kategori",14}");
            int i = 0;
            foreach (BmiCalc history in histories)
            {
                i++;
                Console.Write($"{i}.  |"); history.Print();
            }
            Console.WriteLine("\nTekan apa saja untuk kembali");
            Console.ReadKey();
        }
    }
}
