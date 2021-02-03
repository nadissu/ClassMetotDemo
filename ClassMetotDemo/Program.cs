using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.id = 1;
            musteri1.adi = "Nadide";
            musteri1.soyadi = "Sığırtmaç";
            musteri1.tcKimlikNo = "00000000";
            musteri1.yas = 23;
            musteri1.krediPuani = 100;


            Musteri musteri2 = new Musteri();
            musteri2.id = 2;
            musteri2.adi = "Kayra";
            musteri2.soyadi = "Sevim";
            musteri2.tcKimlikNo = "11111111";
            musteri2.yas = 42;
            musteri2.krediPuani = 90;


            Musteri musteri3 = new Musteri();
            musteri3.id = 3;
            musteri3.adi = "Ulaş";
            musteri3.soyadi = "Seven";
            musteri3.tcKimlikNo = "22222222";
            musteri3.yas = 25;
            musteri3.krediPuani = 80;


            Musteri musteri4 = new Musteri();
            musteri4.id = 4;
            musteri4.adi = "Funda";
            musteri4.soyadi = "Ezel";
            musteri4.tcKimlikNo = "33333333";
            musteri4.yas = 34;
            musteri4.krediPuani = 75;

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3,musteri4 };
            MusteriManager manager = new MusteriManager();

            foreach (Musteri musteri in musteriler)
            {
                manager.Listele(musteri);
            }
            Console.WriteLine("----------------MÜŞTERİLER İLE İLGİLİ İŞLEMLER--------------------");
            manager.Ekle("Ali", "Kaçar", "444444", 52, 56);
            manager.Sil(musteri4);




        }
    }
}
