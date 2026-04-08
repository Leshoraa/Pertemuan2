using System;

namespace main {
    class main {
        static void Main(string[] args) {
            Console.WriteLine("Latian");

            Menu();
            Console.Write("Input nomor menu [1..4]: ");
            double numMenu = Convert.ToDouble(Console.ReadLine());
            if (numMenu == 1) {
                Console.Write("Input angka 1: ");
                double numInput1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input angka 2: ");
                double numInput2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Hasil Penambahan: " + Penambahan(numInput1, numInput2));
            }else if (numMenu == 2) {
                Console.Write("Input angka 1: ");
                double numInput1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input angka 2: ");
                double numInput2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Hasil Pengurangan: " + Pengurangan(numInput1, numInput2));
            }else if (numMenu == 3) {
                Console.Write("Input angka 1: ");
                double numInput1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input angka 2: ");
                double numInput2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Hasil Perkalian: " + Perkalian(numInput1, numInput2));
            }else if (numMenu == 4) {
                Console.Write("Input angka 1: ");
                double numInput1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input angka 2: ");
                double numInput2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Hasil Pembagian: " + Pembagian(numInput1, numInput2));
            } else {
                Console.Write("Sek genah\n");
            }
        }

        static void Menu() {
            Console.WriteLine("Pilih menu calculator:\n\n" + "1. Penambahan\n" + "2. Pengurangan\n" + "3. Perkalian\n" + "4. Pembagian\n");
        }
        static double Penambahan(double a, double b) {
            return a + b;
        }
        
        static double Pengurangan(double a, double b) {
            return a - b;
        }
        static double Perkalian(double a, double b) {
            return a * b;
        }
        static double Pembagian(double a, double b) {
            return a / b;
        }
    }
}