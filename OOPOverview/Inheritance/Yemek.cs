using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Yemek
    {
        public double Fiyat { get; set; }
        public int PismeSuresi { get; set; }
        public List<string> Malzemeleri { get; set; }
        public string Ad { get; set; }

        public void Pisir()
        {
            Console.WriteLine($"{Ad} pişti");
        }

    }

    public class Pizza : Yemek
    {
        public bool BuyukMu { get; set; }

    }

    public class Corba: Yemek
    {
        //derived: miras alan
        //base: miras veren
        public bool KasarVarMi { get; set; }

    }

    public class Tatli:Yemek
    {
        public bool SerbetliMi { get; set; }
    }

    public class VeganPizza : Pizza
    {

    }
}
