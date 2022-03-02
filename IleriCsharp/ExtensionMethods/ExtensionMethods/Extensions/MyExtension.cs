using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Extensions
{
   public static class MyExtension
    {
        public static char NextLetter(this Random random)
        {
            return (char)random.Next(65, 90);
        }

        public static string NextWord(this Random random, int length)
        {
            string word = string.Empty;
            while (word.Length != length)
            {
                word += random.NextLetter().ToString();
            }
            return word;
        }
        public static string NextWord(this Random random, params string[] words)
        {
            return words[random.Next(0, words.Length)];
        }

        //public static string NextWord(this Console console, params string[] words)
        //{
        //    return words[random.Next(0, words.Length)];
        //}

        public static int TotalWorkDays(this DateTime date)
        {
            DateTime startDate = new DateTime(date.Year, 1, 1);
            DateTime finalDate = new DateTime(date.Year, 12, 31);
            int totalDays = 0;
            for (DateTime i = startDate; i <= finalDate; i= i.AddDays(1))
            {
                if (i.DayOfWeek != DayOfWeek.Sunday && i.DayOfWeek != DayOfWeek.Saturday)
                {
                    totalDays++;
                }
            }

            return totalDays;
        }
    }
}
