using System;

namespace MethodOverloading
{
    public enum Sekil
    {
        Kare,
        Daire,
        Ucgen,
        Dikdortgen
    }
    class Program
    {

       
        static void Main(string[] args)
        {
            var kareAlani = alanHesapla(5, Sekil.Kare);
            var ucgenAlani = alanHesapla(3, 6, Sekil.Ucgen);

            var opKare = opsiyonelAlanHesapla(4);
            var opDaire = opsiyonelAlanHesapla(4.2, sekil: Sekil.Daire);
            var opUcgen = opsiyonelAlanHesapla(5, 3, Sekil.Ucgen);
        }

        /// <summary>
        /// tek birim ile alan hesaplayabilecek fonksiyon
        /// </summary>
        /// <param name="birimUzunluk">double cinsinden şeklin birim uzunluğu</param>
        /// <param name="sekil">Kare veya daire</param>
        /// <returns></returns>
        static double alanHesapla(double birimUzunluk, Sekil sekil)
        {
            switch (sekil)
            {
                case Sekil.Kare:
                    return Math.Pow(birimUzunluk, 2);
                    
                case Sekil.Daire:
                    return Math.Pow(birimUzunluk, 2) * Math.PI;            
                default:
                    throw new Exception("şekil, sadece kare ya da daire olabilir! ");
            }
        }

        static double alanHesapla(double birim1, double birim2, Sekil sekil)
        {
            switch (sekil)
            {
                case Sekil.Dikdortgen:
                    return birim1 * birim2;

                case Sekil.Ucgen:
                    return (birim1 * birim2) / 2;
                default:
                    throw new Exception("şekil, sadece üçgen ya da dikdörtgen olabilir! ");
            }
        }

        static double opsiyonelAlanHesapla(double birim1, double birim2=1,Sekil sekil= Sekil.Kare)
        {
            switch (sekil)
            {
                case Sekil.Kare:
                    return Math.Pow(birim1, 2);
                case Sekil.Daire:
                    return Math.Pow(birim1, 2) * Math.PI;
                case Sekil.Ucgen:
                    return (birim1 * birim2) / 2;
                case Sekil.Dikdortgen:

                    return birim1 * birim2;
                default:
                    return 0;
            }
        }

        
        /// <summary>
        /// Mesaj gösterir
        /// </summary>
        static void goster()
        {

        }

    }
}
