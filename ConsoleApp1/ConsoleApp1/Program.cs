using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = GetNumbersGreaterThan3(new List<int>()
            {
                1, 2, 3, 4, 5
            });
        }
        // custom iteration:
        // suppose we want to get all the numbers greater then 3
        public static IEnumerable<int> GetNumbersGreaterThan3(List<int> lst)
        {
            var theNumbers = new List<int>();
            foreach (var i in lst)
            {
                if (i > 3)
                    theNumbers.Add(i);
            }

            return theNumbers;
        }
    }
}
// Disadvantage here:
/*
 * We have to create a temporary list to store the output "theNumbers"
 *
 */

