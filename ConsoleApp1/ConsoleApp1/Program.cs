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

        public static IEnumerable<int> GenerateWithoutYield() // in this case this method will get hit 5 times as the foreach in the main
        //iterates.
        {
            var i = 0;
            var list = new List<int>();
            while (i < 5)
                yield return ++i;
        }
    }
}
