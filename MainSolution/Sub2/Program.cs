using System.Linq;

namespace Sub2
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(5, 10);
        }

        public static void Add(int num1, int num2, params int[] nums) // params needs to be last parameter
        {
            int sum = 0;
            sum = num1 + num2;
            if (nums.Length != 0)
            {
                sum += nums.Sum();
            }
            System.Console.WriteLine(sum);
        }
    }

}

// delimeter is the space. so outputis Hello and then World
// If you want values directly to this file stand alone select this exe then right clik on this project and go to debugger section and add the parameter with space separatd

