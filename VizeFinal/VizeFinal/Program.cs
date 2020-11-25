using System;
using System.Collections.Generic;

namespace VizeFinal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sınıf mevcudu giriniz:");
            int Mevcut = Convert.ToInt32(Console.ReadLine());
            Ogrenci[] Ogr = new Ogrenci[Mevcut];
            //List<Ogrenci> Ogr = new List<Ogrenci>();
            Hesap _hesap = new Hesap();

            for (int i = 0; i < Mevcut;)
            {
                Ogr[i] = new Ogrenci();
                Console.WriteLine((i+1)+ ". öğrencinin,");

                Console.WriteLine("adı:");
                Ogr[i].OgrAd = Convert.ToString(Console.ReadLine());
                Console.WriteLine("soyadı:");
                Ogr[i].OgrSoyad = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Öğrenci numarası:");

                Ogr[i].OgrNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("vize notu giriniz:");
                Ogr[i].Vize = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("final notu giriniz:\n");
                Ogr[i].final = Convert.ToInt32(Console.ReadLine());


                Ogr[i].Ortalama = _hesap.OrtalamaHesapla(Ogr[i].Vize, Ogr[i].final);
                Ogr[i].HarfNotu = _hesap.HarfNotuHesapla(Ogr[i].Ortalama);
                Ogr[i].GecmeDurumu = _hesap.GecmeDurumu(Ogr[i].HarfNotu);


                Console.WriteLine(Ogr[i].OgrNo + " numaralı öğrencinin \n ortalaması:" + Ogr[i].Ortalama);
                Console.WriteLine("harf notu:" + Ogr[i].HarfNotu);
                Console.WriteLine("Durum:" + Ogr[i].GecmeDurumu);
                i++;
            }

            

        }




    }
}
