using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            //sayi1 ?? 30


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] 999

            //int , decimal , float , double , bool -- değer tip ---->stack de gerçekleşiyor ----- burada değere atama
            //array , class , interface --referans tip ------>stack ve heap de birlikte gerçekleşir ----- burada adres değerine atama

        }
    }
}
