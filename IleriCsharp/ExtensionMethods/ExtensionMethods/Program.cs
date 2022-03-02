using ExtensionMethods.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "ayna", "bilgisayar", "troleybüs", "harddisk","bilim", "bilye", "balmumu" };
            List<int> numbers = new List<int> { 12, 5, 6, 79, 22 };
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(random.NextLetter());
                Console.WriteLine(random.NextWord(5));
                Console.WriteLine(random.NextWord("ayna", "bilgisayar", "troleybüs", "harddisk"));

                Console.WriteLine(DateTime.Now.TotalWorkDays());
            }

            Console.WriteLine("---------------------------------------");
            var startWithB = words.ToList().Where(w => w.StartsWith("b"));
            startWithB.ToList().ForEach(w => Console.WriteLine(w));
            var total = numbers.Sum();
            var avg = numbers.Average();
            var min = numbers.Min();
            var max = numbers.Max();

            Console.WriteLine($"Toplam: {total}, Ortalama: {avg}, max: {max}, min:{min}");

           
        }
    }
}
