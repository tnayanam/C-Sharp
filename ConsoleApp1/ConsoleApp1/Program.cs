using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 50; x++)
                {
                    Console.Write("Hi ");
                }
            });
            t.Wait();
        }
    }
}
