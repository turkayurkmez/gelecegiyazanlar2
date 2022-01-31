using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public class Silah
    {
        public int VurusGucu { get; set; }
        public int Agirlik { get; set; }

        public void Gorsel()
        {

        }
    }

    public class Ak47 : Silah
    {
       
    }

    public class Sniper: Silah
    {

    }

    public class MP5: Silah
    {

    }
}
