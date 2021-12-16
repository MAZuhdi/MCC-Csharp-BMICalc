using System;
using System.Collections.Generic;


namespace MyConsoleApp
{
    public class BmiCalc
    {
        private string nama, kategori, gender;
        private double bb, tb, bmi;
        //public double bb { get; set; }
        //public double tb { get; set; }


        public void InputGender()
        {
            int genderInt;
            do
            {
                try
                {
                    Console.WriteLine("Pilih gender anda:");
                    Console.WriteLine("1. Laki-laki");
                    Console.WriteLine("2. Perempuan");
                    Console.Write("Pilihan: ");
                    genderInt = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Masukkan angka 1 atau 2");
                    continue;
                }
                break;
            } while (true);
            
            if (genderInt == 1)
            {
                gender = "Laki-laki";
            }
            else if (genderInt == 2)
            {
                gender = "Perempuan";
            }
            else
            {
                Console.WriteLine("Input tidak valid");
                InputGender();
            }
        }

        public void InputBB()
        {
            Console.Write("Berapa berat badan anda? (dalam Kg) ");
            try
            {
                bb = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Input tidak valid");
                InputBB();
            }
            
        }

        public double GetBB()
        {
            return bb;
        }

        public void InputTB()
        {
            Console.Write("Berapa tinggi badan anda? (dalam Cm) ");
            try
            {
                tb = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Input tidak valid ");
                InputTB();
            }
            
        }

        public double GetTB()
        {
            return tb;
        }

        public void InputNama()
        {
            do
            {
                try
                {
                    Console.Write("Nama anda? ");
                    nama = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Input tidak valid");
                    continue;
                }

                if (nama.Length > 15)
                {
                    Console.WriteLine("Maksimal 15 huruf");
                    continue;
                }                
                
                if (String.IsNullOrWhiteSpace(nama))
                {
                    Console.WriteLine("Nama tidak bisa kosong");
                    continue;
                }

                break;
            } while (true);
        }

        public string GetNama()
        {
            return nama;
        }

        public double GetBmi()
        {
            return bmi;
        }

        public void SetBmi(double bmiVal)
        {
            bmi = Math.Round(bmiVal,2);
        }

        public double CalcBmi()
        {
            return bb / Math.Pow((tb / 100), 2);
        }

        public void SetKategori(string kategoriVal)
        {
            kategori = kategoriVal;
        }

        public string GetKategori()
        {
            return kategori;
        }

        public string DecideCategory()
        {
            switch (gender)
            {
                case "Laki-laki":
                    if (bmi < 17)
                    {
                        return "Kurus";
                    }
                    else if (bmi <= 23)
                    {
                        return "Normal(Ideal)";
                    }
                    else if (bmi <= 27)
                    {
                        return "Gemuk";
                    }
                    else if (bmi > 27)
                    {
                        return "Obesitas";
                    }
                    return "Failure";
                case "Perempuan":
                    if (bmi < 18)
                    {
                        return "Kurus";
                    }
                    else if (bmi <= 25)
                    {
                        return "Normal(Ideal)";
                    }
                    else if (bmi <= 27)
                    {
                        return "Gemuk";
                    }
                    else if (bmi > 27)
                    {
                        return "Obesitas";
                    }
                    return "Failure";
                default:
                    return "Mohon pilih gender 1 atau 2";
            }
        }

        public void Print()
        {
        Console.WriteLine($"{nama, 15} | {gender, 10} | {tb, 5} | {bb, 5} | {bmi, 5} | {kategori, 14}");
        }

        public void PrintDetail()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("                Hasil");
            Console.WriteLine("===================================");
            Console.WriteLine($"Halo {nama},");
            Console.WriteLine($"Berat badan     = {bb} Kg");
            Console.WriteLine($"Tinggi badan    = {tb} Cm");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"BMI             = {bmi}");
            Console.WriteLine($"Kategori        = {kategori}");
        }
    }
}
