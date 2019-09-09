using System;
using System.Collections.Generic;
namespace MainSolution
{
    class Program
    {
        static void Main(string[] args)
        {

            // Environment value of BRB at user level as Hello and System level as /bin. 
            // Everytime you make changes in system variable one needs to restart Visual Studio
            System.Console.WriteLine("Learn Environment Variable");
            Console.WriteLine(Environment.GetEnvironmentVariable("BRB", EnvironmentVariableTarget.Process)); // Hello
            Console.WriteLine(Environment.GetEnvironmentVariable("BRB", EnvironmentVariableTarget.Machine)); // /bin
            Console.WriteLine(Environment.GetEnvironmentVariable("BRB", EnvironmentVariableTarget.User)); //  Hello
            Console.WriteLine(Environment.GetEnvironmentVariable("BRB")); // Hello default it takes from user first.


            //Stack<int> S1 = new Stack<int>();
            //S1.Push(23);
            //S1.Push(3);
            //S1.Push(18);
            //S1.Push(30);
            //// loop but no popping or peeking
            //foreach (var item in S1)
            //{
            //    System.Console.WriteLine(item);
            //}
            //System.Console.WriteLine("---------");
            //System.Console.WriteLine(S1.Count);
            //while (S1.Count > 0)
            //{
            //    System.Console.WriteLine(S1.Peek()); // Displays all elements
            //    System.Console.WriteLine(S1.Pop()); // Print and pops out all elements
            //}
            //S1.Push(1);
            //S1.Push(2);
            //S1.Push(3);
            //S1.Push(4);
            //System.Console.WriteLine("-------------------------------");
            //System.Console.WriteLine(S1.Count);
            //S1.Clear(); // deletes all elements
            //System.Console.WriteLine("=================================");
            //System.Console.WriteLine(S1.Count); // count the elements in stack
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            //Stack<int> s2 = new Stack<int>(arr); // all elements assigned
            //while (s2.Count > 0)
            //{
            //    System.Console.WriteLine(s2.Peek()); // Displays all elements
            //    System.Console.WriteLine(s2.Pop()); // Displays all elements
            //}
            //Stack<int> s3 = new Stack<int>(new int[] { 1, 2, 3, 4 }); // all elements assigned
            //System.Console.WriteLine(s3.Contains(3));
        }
    }
}
