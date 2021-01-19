using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1000000000;
            musteri1.AdiSoyadi = "halil Acar";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2000000000;
            musteri2.AdiSoyadi = "George Hagi";
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Müşteri Listesi ");
            musteriManager.Liste(musteriler);
            Console.WriteLine("-------------------------------");
            musteriManager.Sil(musteri1);
        }
    }
}
