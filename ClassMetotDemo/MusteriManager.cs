using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + "  " + musteri.AdiSoyadi + "  " + "Ekleme Başarılı");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + "  " + musteri.AdiSoyadi);
        }
        public void Liste(Musteri[] Listele)
        {
            foreach (Musteri musteri in Listele)
            {
                Console.WriteLine(musteri.Id + "  " + musteri.AdiSoyadi);
            }
        }

    }
}
