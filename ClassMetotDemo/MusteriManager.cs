using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Adı :  " + musteri.MusteriAdi +"-------------------- " + "Alışveriş Ücreti :" + musteri.AlisverisUcreti);
        }
        public void Ekleme(Musteri musteri)
        {
            Console.WriteLine("Musteri Id: " + musteri.Id);
        }

        public void Silme(Musteri musteri)
        {
            if(musteri.AlisverisUcreti > 200)
            {
                Console.WriteLine("Müşteri Adı :  " + musteri.MusteriAdi + "-------------------- " + "Alışveriş Ücreti :" + musteri.AlisverisUcreti);
            }
        }
    }
}
