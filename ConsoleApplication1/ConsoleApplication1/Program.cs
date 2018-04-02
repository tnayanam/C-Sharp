using System;
using System.Threading;

class Program
{
    static int Total = 0;
    public static void Main()
    {
        Thread th1 = new Thread(AddOneMillion);
        AddOneMillion();
        Thread th2 = new Thread(AddOneMillion);
        AddOneMillion();
        Thread th3 = new Thread(AddOneMillion);
        AddOneMillion();
        th1.Start();
        th2.Start();
        th3.Start();
        th1.Join();
        th2.Join();
        th3.Join();
        Console.WriteLine("Total = " + Total);
    }

    public static void AddOneMillion()
    {
        for (int i = 1; i <= 1000000; i++)
        {
            Total++;
        }
    }
}
// Eveytime we are gettig different vslues because Total is a shared resource thus all thread shares its avlue and thus issue occurs.
// ech thread starts adding to total when total has alredy been incremented by sme counter by other threads. 