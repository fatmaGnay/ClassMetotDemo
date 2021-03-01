using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        readonly List<Musteri> musteriler = new List<Musteri>();

        public MusteriManager()
        {
        }

        public MusteriManager(List<Musteri> musteriler)
        {
            this.musteriler = musteriler;
        }

        public void Ekle(Musteri musteri)
        {
            musteriler.Add(musteri);
            Console.WriteLine("Müşteri Eklendi : " , musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.HesapNumara);
            Console.WriteLine("------------------------------");
            Console.WriteLine(" ");
        }

        //Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
        public void Listele( )
        {
            foreach (Musteri musteri in musteriler)
            {
                
                Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.HesapNumara);
                Console.WriteLine(" ");
            }


        }
        public void Sil(Musteri musteri)
        {
            musteriler.Remove(musteri);
            Console.WriteLine("Müşteri silindi!");
            Console.WriteLine(" ");
        }
    }
}
