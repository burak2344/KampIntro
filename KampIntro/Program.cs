using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety -- tip güvenliği 
            //Do not repeat yoruself- Kendini tekrarlama
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");

            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar butonu ");
            }
            else
            {
                Console.WriteLine("Giriş Yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(ogrenciSayisi);
            Console.WriteLine(faizOrani);

        }
    }
}
