using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person soldier = new Person();
            try
            {
                soldier.SetAge(18);
                
                Console.WriteLine($"asker yaşı: {soldier.GetAge()} ");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
               
            }

            Person politician = new Person();
            politician.SetAge(44);
            Console.WriteLine($"Politikacının yaşı { politician.GetAge()}");

            politician.Name = "İhsan";
            politician.LastName = "Bakkalcı";

            politician.Salary = 35000;
            politician.Address = "İstanbul";



        }
    }
}
