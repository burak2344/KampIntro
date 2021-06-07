using System;

namespace Odev6Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.urunAdi = "Bilgisayar";
            urun1.urunAciklama = "Monster Notebook";
            urun1.urunKodu = "#10";
            urun1.Fiyat = 3500;
            urun1.stokDurumu = true;

            Urun urun2 = new Urun();
            urun2.urunAdi = "Bilgisayar";
            urun2.urunAciklama = "Acer Notebook";
            urun2.urunKodu = "#11";
            urun2.Fiyat = 7500;
            urun2.stokDurumu = false;

            Urun urun3 = new Urun();
            urun3.urunAdi = "Telefon";
            urun3.urunAciklama = "Apple Iphone";
            urun3.urunKodu = "#12";
            urun3.Fiyat = 3200;
            urun3.stokDurumu = true;

            Urun urun4 = new Urun();
            urun4.urunAdi = "Telefon";
            urun4.urunAciklama = "Samsung A150";
            urun4.urunKodu = "#13";
            urun4.Fiyat = 4500;
            urun4.stokDurumu = true;

            Urun[] urunler = new Urun[] {urun1, urun2, urun3, urun4};
            foreach (var products in urunler)
            {
                if (products.stokDurumu == true)
                {
                    Console.WriteLine(products.urunAdi + " : " + products.urunAciklama);
                }
            }
            int j = 3;
            while (j < urunler.Length)
            {
                Console.WriteLine(urun1.urunAciklama + " : " + urun1.Fiyat + " " + urun2.urunAciklama + " : " + urun2.Fiyat + " " + urun3.urunAciklama + " : " + urun3.Fiyat + " " + urun4.urunAciklama + " : " + urun4.Fiyat);
                j++;
            }
        }
    }

    class Urun
    {
        public string urunAdi { get; set; }
        public string urunAciklama { get; set; }
        public string urunKodu { get; set; }
        public int Fiyat { get; set; }
        public Boolean stokDurumu { get; set; }


    }
}
