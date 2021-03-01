using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();

            Console.Write("Ad Giriniz: ");
            musteri1.Ad = Console.ReadLine();
            Console.Write("Soyad Giriniz: ");
            musteri1.Soyad = Console.ReadLine();
            Console.Write("Hesap Numarası: ");
            musteri1.HesapNumara = int.Parse(Console.ReadLine());
            musteriManager.Ekle(musteri1);

            Console.Write("Ad Giriniz: ");
            musteri2.Ad = Console.ReadLine();
            Console.Write("Soyad Giriniz: ");
            musteri2.Soyad = Console.ReadLine();
            Console.Write("Hesap Numarası: ");
            musteri2.HesapNumara = int.Parse(Console.ReadLine());
            musteriManager.Ekle(musteri2);

            Console.WriteLine("Müşteriler");
            musteriManager.Listele();
            musteriManager.Sil(musteri1); 
            Console.WriteLine("Müşteriler");
            musteriManager.Listele();

        }
    }
}
