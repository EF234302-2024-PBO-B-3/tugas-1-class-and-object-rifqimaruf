using ClassAndObject.Perpustakaan;
using ClassAndObject.Kendaraan;
using ClassAndObject.TokoLaptop;
using ClassAndObject.TokoSepeda;
using ClassAndObject.OperasiMatematika;
using System;

namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Buku
            Buku buku1 = new Buku("PBO B C-Sharp", "Maruf", 2024);

            // Kendaraan
            Mobil mobil1 = new Mobil("Tesla", "Cybertruck", 2024);

            // Laptop
            Laptop laptop1 = new Laptop("Asus", "11th Gen Intel(R) Core(TM) i5-1135G7", 20, 512);
           
            // Sepeda
            Sepeda sepeda1 = new Sepeda("Poligon", "High End", 20.7);

            // Kalkulator
            Kalkulator kalkulator = new Kalkulator();

            buku1.TampilkanInfo();
            mobil1.TampilkanSpesifikasi();
            laptop1.TampilkanSpesifikasi();
            sepeda1.TampilkanInformasi();

            kalkulator.Tambah(8, 7);
            kalkulator.Kurang(8, 7);
            kalkulator.Kali(8, 7);
            kalkulator.Bagi(8, 7);
        }
    }
}
