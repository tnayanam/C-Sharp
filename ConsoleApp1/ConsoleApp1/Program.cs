using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    // so every time yield is called GetNumbers() get hit and yield returns to the caller one by one and result is processed.
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var l in GenerateWithoutYield().Take(5))
            {
                Console.WriteLine(l);
            }
        }

        public static IEnumerable<int> GenerateWithoutYield() // just in the first iteration of the loop breakpoint will get hit
        // and we will get the entire list, and then we will loop through it in the "main" foreach loop.
        // so this method gets called just once
        {
            var i = 0;
            var list = new List<int>();
            while (true)
                yield return ++i; // here the loop will infintiely and we will never get the output
        }
    }
}

// Output: 1
//2
//3
//4
//5
