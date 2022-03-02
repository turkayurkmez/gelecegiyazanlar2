using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegate
{
    class Program
    {
        static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static void Main(string[] args)
        {
            //1.0
           // var evenNumbers = FilterGenerator.Filter(numbers, bigThanFive);

            //2.0:
            var oddNumbers = FilterGenerator.Filter(numbers, delegate (int num)
            {
                return num % 2 == 1;
            });

            //3.5:
            var multiply3 = FilterGenerator.Filter(numbers, num => num % 3 == 0);

            showNumber(multiply3);
        }

        private static void showNumber(int[] array)
        {
            //foreach (var number in array)
            //{
            //    Console.WriteLine(number);
            //}

            array.ToList().ForEach(num => Console.WriteLine(num));
        }





        static bool isEvenNumber(int number)
        {
            return number % 2 == 0;
        }

        static bool bigThanFive(int number)
        {
            return number > 5;
        }

    }
}
