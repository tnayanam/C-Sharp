using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    // so everytime yield is called GetNumbers() get hit and yield returns to the caller one by one and result is processed.
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var num in GetNumbers())
            {
                Console.WriteLine(num);
            }
        }
        public static IEnumerable<int> GetNumbers() { yield return 1; yield return 2; yield return 3; }
    }
}
