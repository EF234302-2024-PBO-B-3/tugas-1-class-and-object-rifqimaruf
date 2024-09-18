using System;

namespace ClassAndObject.Kendaraan
{
    public class Mobil
    {
        public string Merk{ get; set; }
        public string Model{ get; set; }
        public int TahunProduksi{ get; set; }

        public Mobil(string Merk, string Model, int TahunProduksi)
        {
            this.Merk = Merk;
            this.Model = Model; 
            this.TahunProduksi = TahunProduksi;
        }

        public void TampilkanSpesifikasi()
        {
            Console.WriteLine($"Merk: {Merk}, Model: {Model}, Tahun Produksi: {TahunProduksi}");
        }

    }
}