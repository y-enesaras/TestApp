using System;
//Bir bankada müşteri takibi yapmak istiyorsunuz.
//Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
//MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme, silme gibi metotları simule ediniz.
namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Yusuf Enes";
            musteri1.Lokasyon = "Izmir";
            musteri1.Meslek = "Bilgisayar Bilimcisi";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Baran";
            musteri2.Lokasyon = "Izmir";
            musteri2.Meslek = "Doktor";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Emre";
            musteri3.Lokasyon = "Izmir";
            musteri3.Meslek = "Elektirik Mühendisi";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("----------------Musteriler Eklendi-------------");
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine("----------------Musteriler Silindi-------------");
            musteriManager.Sil(musteri3);
            Console.WriteLine("----------------Musteriler Listelendi-------------");
            musteriManager.Listele(musteriler);

        }
    }
}
