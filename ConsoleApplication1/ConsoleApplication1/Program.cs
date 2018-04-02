using System;

class Program
{
    static int Total = 0;
    public static void Main()
    {

        Console.WriteLine(Environment.ProcessorCount);
    }
}
// now it is locked adn we will get 3000000 all the time and it will not change.