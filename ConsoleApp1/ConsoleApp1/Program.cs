using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    // so every time yield is called GetNumbers() get hit and yield returns to the caller one by one and result is processed.
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var l in GenerateWithoutYield())
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
            while (i < 5)
            {
                list.Add(++i);
            }

            return list;
        }
    }
}
