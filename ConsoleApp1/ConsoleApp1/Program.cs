using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var s in GetNumbersGreaterThan3(new List<int>()
            {
                1, 2, 3, 4, 5
            }))
            {
                Console.WriteLine(s);
            }
        }  // no intermediary storage is required.

        // custom iteration:
        // suppose we want to get all the numbers greater then 3
        public static IEnumerable<int> GetNumbersGreaterThan3(List<int> lst)
        {
            foreach (var i in lst)
            {
                if (i > 3)
                    yield return i;
            }
        }
    }
}
// Disadvantage here:
/*
 * We have to create a temporary list to store the output "theNumbers"
 *
 */

