using System;

namespace TemelKavramlar
{


    class Program
    {

        static void Main(string[] args)
        {
            //int sayi = 257;
            //sbyte negatif = -128;

            //checked
            //{
            //    byte deger = (byte)sayi;
            //    Console.WriteLine(deger);
            //}

            //int deger = 1000;
            //long buyuk = deger;
            //short kucuk = (short)deger;

            Console.WriteLine("Kilonuzu giriniz:");
            string girilenKilo = Console.ReadLine();

            try
            {
                int kilo = Convert.ToInt32(girilenKilo);
                Console.WriteLine("Boyunuzu metre olarak giriniz");
                string girilenBoy = Console.ReadLine();
                double boy = Convert.ToDouble(girilenBoy);

                double bmi = kilo / (boy * boy);
                if (double.IsInfinity(bmi))
                {
                    throw new Exception("boy 0 olduğundan bmi hesapnamadı");
                }
                else
                {
                    Console.WriteLine($"Vücut kitle endeksiniz: {bmi}");
                }

            }
            catch (FormatException)
            {

                Console.WriteLine("Lütfen sayısal değer giriniz");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Tam sayılar 0'a bölünemez");
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            String s = "merhaba";
            string x = "merhaba";
            

            //bool olurMu = true;
            //Boolean olsunMu = false;
            //int sayi = 5;
         




        }
    }
}
