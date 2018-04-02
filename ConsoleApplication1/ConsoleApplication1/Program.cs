using System;
class Program
{
    static int Total = 0;
    public static void Main()
    {
        AddOneMillion();
        AddOneMillion();
        AddOneMillion();
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
// Single threded we always get 300000 as output