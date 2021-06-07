using System;

namespace Odev5Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            yemeksepeti yemek1 = new yemeksepeti();
            yemek1.yemekAdi = "Hamburger";
            yemek1.fiyat = 30;
            yemek1.puan = 6;

            yemeksepeti yemek2 = new yemeksepeti();
            yemek2.yemekAdi = "Pizza";
            yemek2.fiyat = 45;
            yemek2.puan = 8;

            yemeksepeti yemek3 = new yemeksepeti();
            yemek3.yemekAdi = "Döner";
            yemek3.fiyat = 15;
            yemek3.puan = 9;

            yemeksepeti yemek4 = new yemeksepeti();
            yemek4.yemekAdi = "Köfte";
            yemek4.fiyat = 32;
            yemek4.puan = 3;

            yemeksepeti[] yemekler = new yemeksepeti[] {yemek1, yemek2, yemek3, yemek4};

            foreach (var yemek in yemekler)
            {
                if (yemek.puan > 5)
                {
                    Console.WriteLine(yemek.yemekAdi + " : " + yemek.fiyat);
                }
               

            }

        }
    }

    class yemeksepeti
    {
        // prop iki kez tab tuşuna bas
        public string yemekAdi { get; set; }
        public int fiyat  { get; set; }
        public int puan { get; set; }

    }
}
