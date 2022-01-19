using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ListAndCollection
{
    class Program
    {

        static List<int> sayilar = new List<int> { 96, 104, -5, 0, 1024, 1 };
        static void Main(string[] args)
        {
            //object x = "deneme";
            //str deger = (int)x;

            //Console.WriteLine(deger);
            biseyYap(3);

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(5);
            //arrayList.Add("Kırmızı");

            //List<string> sehirler = new List<string>();

            int enKucuk = sayilar[0];

            for (int i = 1; i < sayilar.Count; i++)
            {
                if (sayilar[i] < enKucuk)
                {
                    enKucuk = sayilar[i];
                }
            }

            Console.WriteLine(enKucuk.ToString());

            //string[] arkadaslar = { "Meryem", "Necla", "Sibel" };
            //Console.WriteLine(arkadaslar[0]);
            //Console.WriteLine(arkadaslar[1]);
            //Console.WriteLine(arkadaslar[2]);

            //while (true)
            //{

            //}

            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }

            int ortalama = toplam / sayilar.Count;
            Console.WriteLine(ortalama.ToString());

            List<string> sehirler = new List<string> { "Adana", "Adıyaman", "Ankara", "Eskişehir", "Edirne", "Elazığ", "Çanakkale", "Sakarya" };

            List<string> eIcerenSehirler = new List<string>();
            foreach (var sehir in sehirler)
            {
                if (sehir.StartsWith("E"))
                {
                    eIcerenSehirler.Add(sehir);
                    //sehirler.Remove(sehir);
                }
            }

            foreach (var eileBaslayan in eIcerenSehirler)
            {
                sehirler.Remove(eileBaslayan);
            }


            foreach (var kalan in sehirler)
            {
                Console.WriteLine(kalan);
            }
            //IndexOf()
            //Contains()
            //Split()

            // 
        }

        static void biseyYap(object o)
        {

        }
    }
}
