using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        //Musteri ekleme, listeleme,silme 
        public void Ekle( string adi,string soyadi,string tcKimlikNo,int yas,int krediPuani )
        {
            Console.WriteLine("Müşterinin Adı: "+adi+" "+"Müşterinin Soyadı: "+soyadi+""+"Müsterinin TC Kimlik Numarası: "+tcKimlikNo+""+"Müşternin Yaşı: "+yas+""+"Müşterinin Kredi Puanı: "+krediPuani);
            Console.WriteLine("Müşteri Eklendi");
            
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("***************MÜŞTERİLER**************");
            Console.WriteLine("Müşterinin Id'si: "+musteri.id);
            Console.WriteLine("Müşterinin Adı: " + musteri.adi);
            Console.WriteLine("Müşterinin Soyadı: " + musteri.soyadi);
            Console.WriteLine("Müşterinin Adı: " + musteri.tcKimlikNo);
            Console.WriteLine("Müşterinin Adı: " + musteri.yas);
            Console.WriteLine("Müşterinin Adı: " + musteri.krediPuani);


        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("********************************");
            Console.WriteLine(musteri.adi+" "+musteri.soyadi+" "+musteri.tcKimlikNo+" "+musteri.yas+" "+musteri.krediPuani);
            Console.WriteLine("Müşteri Silindi");
        }
    }
}
