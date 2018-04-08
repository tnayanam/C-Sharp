using System.Collections.Generic;

namespace Sub2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer { Id = 1, Name = "John", Salary = 4500 };
            Customer c2 = new Customer { Id = 2, Name = "Cena", Salary = 7800 };
            Customer c3 = new Customer { Id = 3, Name = "Check", Salary = 6500 };
            Customer c4 = new Customer { Id = 4, Name = "Smith", Salary = 3500 };
            Customer c5 = new Customer { Id = 5, Name = "Singh", Salary = 500 };

            Dictionary<int, Customer> dict = new Dictionary<int, Customer>();
            dict.Add(c1.Id, c1);
            dict.Add(c2.Id, c2);
            dict.Add(c3.Id, c3);
            dict.Add(c4.Id, c4);
            dict.Add(c5.Id, c5);
            // this will throw exception
            //dict.Add(c1.Id, c5);
            // checks f key already present., if presernt returns true.
            if (!dict.ContainsKey(c1.Id))
            {
                System.Console.WriteLine("If key is not presernt then only we will add");
                dict.Add(c1.Id, c5);
            }
            // this will throw exception because that key does not exist.
            //System.Console.WriteLine(dict[34].Name);

            if (dict.ContainsKey(34))
            {
                System.Console.WriteLine("If key is not presernt then only we will add");
                dict.Add(c1.Id, c5);
            }

            foreach (var dic in dict)
            {
                System.Console.WriteLine("Key: " + dic.Key);
                System.Console.WriteLine("Name: " + dic.Value.Name);
                System.Console.WriteLine("Salary: " + dic.Value.Salary);
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
