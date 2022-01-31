using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Aşçı yemek yapar
             * 
             */
            Asci boluluBirAsci = new Asci();
            Yemek yemek = new Yemek();

            Corba corba = new Corba();
            corba.Ad = "Tarhana";

            Pizza pizza = new Pizza();
            pizza.Ad = "Vegan";

            Tatli tatli = new Tatli();
            tatli.Ad = "Baklava";

            boluluBirAsci.Pisir(yemek);
            boluluBirAsci.Pisir(corba);
            boluluBirAsci.Pisir(pizza);
            boluluBirAsci.Pisir(tatli);

            Ak47 ak47 = new Ak47();
            MP5 mP5 = new MP5();
            Sniper sniper = new Sniper();

            Oyuncu oyuncu = new Oyuncu();

            oyuncu.Silah = ak47;

            NFSPlayer nFSPlayer = new NFSPlayer();
            nFSPlayer.SelectedCar = new Nissan350Z();




        }
    }
}
