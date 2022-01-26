using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Ekmek ekmek = new Ekmek();
            
            Console.WriteLine(ekmek.Tur);

            Ekmek ekmek2 = new Ekmek(3);

            Ekmek ekmek3 = new Ekmek("Kepekli");

            Ekmek ekmek4 = new Ekmek(2, "Trabzon");
            
            RaporUretici uretici  = new RaporUretici()

        }
    }
}
