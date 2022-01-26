using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
   public class Ekmek
    {
        public int Adet { get; set; } 
        public string Tur { get; set; }

        public Ekmek()
        {
            Adet = 1; 
            Tur = "Beyaz Ekmek";
        }

        public Ekmek(int adet)
        {
            Adet = adet;
            Tur = "Beyaz Ekmek";
        }

        public Ekmek(string tur)
        {
            Adet = 1;
            Tur = tur;
        }

        public Ekmek(int adet, string tur)
        {
            Adet = adet;
            Tur = tur;
        }

    }
}
