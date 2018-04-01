using System;

namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            Customer c1 = new Customer();
            System.Console.WriteLine(c1.ToString()); //  Pragim.Customer
            System.Console.WriteLine(Convert.ToString(c1));  //  Pragim.Customer
            Customer c2 = null;
            System.Console.WriteLine(Convert.ToString(c2));  // ""
            System.Console.WriteLine(c2.ToString()); // Exception
        }
    }

    public class Customer
    {
        public string FName { get; set; }
    }
}

