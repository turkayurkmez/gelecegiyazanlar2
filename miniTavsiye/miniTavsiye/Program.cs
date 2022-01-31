using System;

namespace miniTavsiye
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. kullanıcıya menü gösterecek.
            string userAnswer = string.Empty;
            do
            {
                showMenu();
                Console.WriteLine("Menüden istediğiniz adımı seçin. Çıkmak için 0 girin ");
                userAnswer = Console.ReadLine();
                directToAction(userAnswer);
            } while (userAnswer != "0");

        }

        //One job at a time!

        private static void directToAction(string userAnswer)
        {
            switch (userAnswer)
            {
                case "1":
                    selectContains();
                    break;
                case "2":
                    selectSubString();
                    break;
                case "3":
                    selectSplit();
                    break;
                default:
                    break;
            }
        }

        private static void selectSplit()
        {
            Console.WriteLine("Split örneği...");
        }

        private static void selectSubString()
        {
            Console.WriteLine("Substring örneği...");
        }

        private static void selectContains()
        {
            Console.WriteLine("Contains örneği...");
        }

        private static void showMenu()
        {
            Console.WriteLine("1. Contains");
            Console.WriteLine("2. Substring");
            Console.WriteLine("3. Split");
        }
    }
}
