using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // LINQ Aggregate
            /*
             * The easiest-to-understand definition of Aggregate is that it performs an operation on each element of the list taking into account the operations that have gone before.
             * That is to
             * say it performs the action on the first and second element and carries the result forward. Then it operates on the previous result and the third element and carries
             * forward. etc.
             */
            //var nums = new[] { 1, 2, 3, 4 };
            //var sum = nums.Aggregate((a, b) => a + b);
            //Console.WriteLine(sum); // output: 10 (1+2+3+4)

            //var chars = new[] { "a", "b", "c", "d" };
            //var csv = chars.Aggregate((a, b) => a + ',' + b);
            //Console.WriteLine(csv); // Output a,b,c,d

            // OVERLOAD:
            var multipliers = new[] { 10, 20, 30, 40 };
            var multiplied = multipliers.Aggregate(5, (a, b) => a * b);
            Console.WriteLine(multiplied); //Output 1200000 ((((5*10)*20)*30)*40)
            /*
             * flow of output: initially 5*10 and then all this will get stord in a and b will be 20, then again a = 5*10*20 and b = 30, then a = 5*10*20*30 and b = 40
             */
            /*
             * uch like the above examples, this starts with a value of 5 and multiplies it by the first element of the sequence 10 giving a result of
             * 50. This result is carried forward and multiplied by the next number in the sequence 20 to give a result of 1000. This continues through
             * the remaining 2 element of the sequence.
             */

            //int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            //int aggregatedValue = numbers.Aggregate((total, nextValue) => total + nextValue);

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

