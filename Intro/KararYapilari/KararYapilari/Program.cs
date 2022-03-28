using System;

namespace KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {



            int x = 8;
            if (x % 2 == 0)
            {
                Console.WriteLine("çifttir");
            }
            else
            {
                Console.WriteLine("tektir");
            }

            if (DateTime.Now.Month == 7 && DateTime.Now.Day == 1)
            {
                Console.WriteLine("Türkay'ın doğum günü");
            }

            string ay = string.Empty;
            if (ay == "Aralık" || ay == "Ocak" || ay == "Şubat")
            {
                Console.WriteLine("Kış ayındasınız");
            }


            Console.WriteLine("Hangi renk trafik lambası yaniyor (K, S, Y)");
            string renk = Console.ReadLine();
            if (renk == "K")
            {
                Console.WriteLine("DUR!");
            }
            else if (renk == "S")
            {
                Console.WriteLine("Dikkat");
            }
            else if (renk == "Y")
            {
                Console.WriteLine("Geç");
            }

            switch (renk)
            {
                case "K":
                    Console.WriteLine("DUR!");

                    break;
                case "S":
                    Console.WriteLine("Dikkat");
                    break;
                case "Y":
                    Console.WriteLine("Geç");
                    break;
                default:
                    break;
            }

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    break;
                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    break;
                default:
                    break;
            }





        }
    }
}
