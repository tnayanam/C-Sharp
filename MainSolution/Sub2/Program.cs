using System;
using System.Runtime.InteropServices;

namespace Sub2
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(5, 5); // I only want to pass value fo num1 and num 3
        }

        public static void Add(int firstNumber, int secondNumber,
            [Optional] int[] restOfTheNumbers)
        {
            int result = firstNumber + secondNumber;

            // loop thru restOfTheNumbers only if it is not null
            // otherwise you will get a null reference exception
            if (restOfTheNumbers != null)
            {
                foreach (int i in restOfTheNumbers)
                {
                    result += i;
                }
            }

            Console.WriteLine("Total = " + result.ToString());
        }

    }

}

// delimeter is the space. so outputis Hello and then World
// If you want values directly to this file stand alone select this exe then right clik on this project and go to debugger section and add the parameter with space separatd

