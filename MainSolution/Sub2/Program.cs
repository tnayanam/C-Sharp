namespace Sub2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(20000);
            System.Console.WriteLine(args[0]);
            System.Console.WriteLine(args[1]);
            System.Console.WriteLine("Sub2 Solution Executed.");
        }
    }
}

// delimeter is the space. so outputis Hello and then World
// If you want values directly to this file stand alone select this exe then right clik on this project and go to debugger section and add the parameter with space separatd

