using System;

namespace indexOfHikayesi
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime = "bilgisiyar";
            int baslangicNoktasi = 0;
            string harf = Console.ReadLine();
            while (kelime.IndexOf(harf,baslangicNoktasi)!=-1)
            {
                int bulunanIndex = kelime.IndexOf(harf, baslangicNoktasi);
                Console.Write(bulunanIndex+",");
                bulunanIndex++;
                baslangicNoktasi = bulunanIndex;

            }

            
       
           
        }
    }
}
