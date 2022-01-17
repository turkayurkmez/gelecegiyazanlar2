using System;
using System.Collections.Generic;

namespace ArraysAndCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] aylar = { "Ocak", "Şubat", "Mart" };
            string[] enSevdigim = { "Pink Floyd", "AC/DC", "Metallica" };

            string[] turkcellgg = new string[31];

            turkcellgg[0] = "Türkay";
            string sonEleman = enSevdigim[enSevdigim.Length - 1];


            /*
             * Kullanıcının girdiği iki basamaklı sayıyı okunuşuna çeviren uygulama
             * --24
             * --yirmi dört
             * 
             * -- 982517
             */
            string[] birler = { "", "Bir", "İki", "Üç", "Dört", "Beş ", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] onlar = { "", "On", "Yirmi", "Otuz", "Kırk", "Elli ", "Altmış", "Yetmiş", "Seksen", "Doksan" };

            Console.WriteLine("Sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int onlarBasamagindakiSayi = sayi / 10;
            int birlerBasamagindakiSayi = sayi % 10;

           


            string okunus = onlar[onlarBasamagindakiSayi] +" "+ birler[birlerBasamagindakiSayi];

            Console.WriteLine(okunus);


            string[] kelimeler = new string[0];
            string cevap = string.Empty;
            do
            {
                
                Array.Resize(ref kelimeler, kelimeler.Length + 1);
                Console.WriteLine("bir kelime girin");
                kelimeler[kelimeler.Length - 1] = Console.ReadLine();
                Console.WriteLine("kelime sayısı:" + kelimeler.Length);
                Console.WriteLine("Başka kelime eklemek ister misiniz (E/H)?");
                cevap = Console.ReadLine(); 
            } while (cevap.ToUpper() != "H");

            foreach (var kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }


           
               
         }
    }
}
