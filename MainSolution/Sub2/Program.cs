using System.Collections.Generic;
using System.Linq;

namespace Sub2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] cs = new Customer[5];
            Customer c1 = new Customer { Id = 1, Name = "John", Salary = 4500 };
            Customer c2 = new Customer { Id = 2, Name = "Cena", Salary = 7800 };
            Customer c3 = new Customer { Id = 3, Name = "Check", Salary = 6500 };
            Customer c4 = new Customer { Id = 4, Name = "Smith", Salary = 3500 };
            Customer c5 = new Customer { Id = 5, Name = "Singh", Salary = 500 };
            cs[0] = c1;
            cs[1] = c2;
            cs[2] = c3;
            cs[3] = c4;
            cs[4] = c5;
            // convert array to dict. key is id value is customer itself


            Dictionary<int, Customer> dict = cs.ToDictionary(c => c.Id, c => c);

            foreach (var Cust in dict)
            {
                System.Console.WriteLine(Cust.Value.Name);
            }

        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}

/*
 * Dictionary provides fast look up.
 * 
 */
