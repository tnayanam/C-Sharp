namespace Sub2
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(5, num3: 2); // I only want to pass value fo num1 and num 3
        }

        public static void Add(int num1, int num2 = 4, int num3 = 8)
        {
            System.Console.WriteLine("num1: " + num1);
            System.Console.WriteLine("num2: " + num2);
            System.Console.WriteLine("num3: " + num3);
        }
    }

}

// delimeter is the space. so outputis Hello and then World
// If you want values directly to this file stand alone select this exe then right clik on this project and go to debugger section and add the parameter with space separatd

