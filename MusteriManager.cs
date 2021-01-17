using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        Musteri musteri = new Musteri();

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri added." + " " + musteri.Adi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Kayıt yok.");
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " " + musteri.Adi + " " + musteri.Lokasyon + " " + musteri.Meslek);
            }
        }
    }
}
