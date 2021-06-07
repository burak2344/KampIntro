using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type safe ---- tip güvenli
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("-------------Metotlar-------------------");
            //instance - örnek
            //encapsulation ---> düzensiz bir sistemi daha düzenli hale getiriyoruz.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut", "Yeşil armut", 23,10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 23,9);
            sepetManager.Ekle2("Karpuz", "Yeşil karpuz", 23,8);
          
        }
    }
}


//Dont repeat yourself(Kendini tekrar etme ) - Clean Code - Best Practice 