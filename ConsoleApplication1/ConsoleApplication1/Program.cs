using System;
using System.Threading;

class Program
{
    static int Total = 0;
    public static void Main()
    {
        Thread th1 = new Thread(AddOneMillion);
        Thread th2 = new Thread(AddOneMillion);
        Thread th3 = new Thread(AddOneMillion);
        th1.Start();
        th2.Start();
        th3.Start();
        th1.Join();
        th2.Join();
        th3.Join();
        Console.WriteLine("Total = " + Total);
    }

    static object _lock = new object();

    public static void AddOneMillion()
    {
        for (int i = 1; i <= 1000000; i++)
        {
            lock (_lock)
            {
                Total++;
            }
        }
    }
}
// now it is locked adn we will get 3000000 all the time and it will not change.