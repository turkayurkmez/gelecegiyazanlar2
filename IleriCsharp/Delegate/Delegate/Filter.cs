using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //public delegate bool Criteria(int number);
   public static class FilterGenerator
    {

       public static int[] Filter(int[] numbers, Func<int,bool> criteria)
        {
            List<int> result = new List<int>();
            foreach (var number in numbers)
            {
                if (criteria(number))
                {
                    result.Add(number);
                }
            }

            return result.ToArray();
        }
    }
}
