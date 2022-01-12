using System;

namespace TemelKavramlar
{


    class Program
    {
      
        static void Main(string[] args)
        {
             int sayi =257;
            sbyte negatif = -128;

            checked
            {
                byte deger = (byte)sayi;
                Console.WriteLine(deger);
            }
         

        }
    }
}
