using System;
using System.Collections.Generic;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. bir kelime koleksiyonundan rastgele bir kelime seçilir
             * 2. bu rastgele kelime "* * * * " biçiminde yıldızlara çevrilir.
             * 3. Kullanıcı, harf girer
             * 4. girilen harf kelime içinde aranır
             * 5. varsa o sıradaki yıldız harfe çevrilir.
             * 6. bütün yıldızlar açılana dek bu adımlar devam eder
             */
            List<string> liste = new List<string> { "mikrofon", "troleybüs" };
            string secilenKelime = kelimeSec(liste);
            Console.WriteLine(secilenKelime);
            string bulmaca = kelimeyiYildizaDonustur(secilenKelime);
            ekrandaGoster(bulmaca);
            string harf = Console.ReadLine();

            if (harfVarMi(secilenKelime,harf))
            {
                bulmaca = harfeCevir(secilenKelime, bulmaca, harf);
                ekrandaGoster(bulmaca);
            }


            ////Senaryo: E harfi ile başlayan illeri ayır:
            //string[] sehirler = { "Urfa", "Gaziantep", "Antakya", "Mardin", "Diyarbakır", "Edirne", "Eskişehir" };
            //string[] eilebaslayanlar = filtrele(sehirler, "e");

        }

        //private static string[] filtrele(string[] sehirler, string ilkHarf)
        //{
        //    List<string> sonuc = new List<string>();
        //    foreach (var sehir in sehirler)
        //    {
        //       sonuc =   ilkHarfeGoreFiltrele(ilkHarf,  sehir);
        //    }

        //    return sonuc.ToArray();
        //}

        //private static List<string> ilkHarfeGoreFiltrele(string ilkHarf, string sehir)
        //{
        //    List<string> sonuc = new List<string>();
        //    if (sehir.StartsWith(ilkHarf))
        //    {
        //        sonuc.Add(sehir);
        //    }
        //    return sonuc;
        //}

        static string kelimeSec(List<string> kelimeListesi)
        {
            int randomIndex = new Random().Next(0, kelimeListesi.Count);
            return kelimeListesi[randomIndex];
        }

        private static string kelimeyiYildizaDonustur(string secilenKelime)
        {
            string sonuc = string.Empty;
            for (int i = 0; i < secilenKelime.Length; i++)
            {
                sonuc += "*";
            }
            return sonuc;
        }

        private static void ekrandaGoster(string bulmaca)
        {
            Console.WriteLine(bulmaca);
        }

        private static bool harfVarMi(string secilenKelime, string harf)
        {
            return secilenKelime.Contains(harf);
        }

        private static string harfeCevir(string secilenKelime, string bulmaca, string harf)
        {
            return "*i**i*****";

        }

       

    }
}
