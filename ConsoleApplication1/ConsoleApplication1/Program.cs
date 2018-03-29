/*
 * Multicast Delegate
 * it is a delegate the references more than one function, when we invoke a multicast delegate all the delegate it points to gets invoked
 */

namespace ConsoleApplication1
{
    delegate void Del();
    class Program
    {
        static void Main(string[] args)
        {
            Del d1 = new Del(HelloOne);
            Del d2 = new Del(HelloTwo);
            Del d3 = d1 + d2;
            d3();
            /*
             * Output:
             * One
             * Two
             */

        }
        public static void HelloOne()
        {
            System.Console.WriteLine("One");
        }

        public static void HelloTwo()
        {
            System.Console.WriteLine("Two");
        }
    }
}


