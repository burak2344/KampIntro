using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Burak ";
            musteri1.MusteriSoyad = "Yünkül";
            musteri1.AlisverisUcreti = 300;
            musteri1.Aciklama = "Spor Ayakkabı";


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Ahmet ";
            musteri2.MusteriSoyad = "Debiz";
            musteri2.AlisverisUcreti = 100;
            musteri2.Aciklama = "Pantolon";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAdi = "Kerim ";
            musteri3.MusteriSoyad = "Aydın";
            musteri3.AlisverisUcreti = 600;
            musteri3.Aciklama = "Mont";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
                 
            MusteriManager musteriManager = new MusteriManager();
            foreach (var musteri in musteriler)
            {
                musteriManager.Listele(musteri);
            }

            Console.WriteLine("------------------------------------");
            musteriManager.Ekleme(musteri1);
            musteriManager.Ekleme(musteri2);
            musteriManager.Ekleme(musteri3);

            Console.WriteLine("------------------------------------");
            foreach (var musteri in musteriler)
            {
                musteriManager.Silme(musteri);
            }


        }
    }
}
