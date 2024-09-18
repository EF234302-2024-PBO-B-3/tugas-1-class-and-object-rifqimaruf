using System;

namespace ClassAndObject.TokoLaptop
{
    public class Laptop
    {
        public string Merk { get; set;}
        public string Prosesor { get; set;}
        public int Ram { get; set;}
        public int Penyimpanan { get; set;}

        public Laptop(string Merk, string Prosesor, int Ram, int Penyimpanan)
        {
            this.Merk = Merk;
            this.Prosesor = Prosesor;
            this.Ram = Ram;
            this.Penyimpanan = Penyimpanan;
        }

        public void TampilkanSpesifikasi()
        {
            Console.WriteLine($"Merk: {Merk}, Prosesor: {Prosesor}, RAM: {Ram} GB, Penyimpanan: {Penyimpanan} GB");
        }

    }
}