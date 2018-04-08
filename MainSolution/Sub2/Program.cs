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
            List<Customer> lst = new List<Customer>();
            lst.Add(c1);
            lst.Add(c2);
            lst.Add(c3);
            lst.Add(c4);
            lst.Add(c5);

            foreach (var ls in lst)
            {
                System.Console.WriteLine("Name: {0}", ls.Name);
            }
            // index starts with 0
            System.Console.WriteLine(lst[0].Name);
            // list are bascially expandable arrays.
            // l;ist are strongly typed
            //if we do something like below
            //lst.Add(12);// only customer can be added
            // insert a customer in a specific location, pushes rest of tge lement down
            // current output
            //            Name: John
            //Name: Cena
            //Name: Check
            //Name: Smith
            //Name: Singh
            lst.Insert(0, c5);
            foreach (var ls in lst)
            {
                System.Console.WriteLine("Name: {0}", ls.Name);
            }
            // new output
            //            Name: Singh
            //Name: John
            //Name: Cena
            //Name: Check
            //Name: Smith
            //Name: Singh

            // to find index of
            System.Console.WriteLine(lst.IndexOf(c3));
            System.Console.WriteLine(lst.IndexOf(c5)); // output = 0
            // fiund index but start searcing from where
            System.Console.WriteLine(lst.IndexOf(c5, 1)); //outp[ut 5 

            if (lst.Contains(c3))
            {
                System.Console.WriteLine("customer 3 exist");
            }
            else
            {
                System.Console.WriteLine("cusotomr 3 does not exist");
            }
            // exists we can put a condition lambda expression
            if (lst.Exists(c => c.Name.StartsWith("J")))
            {
                System.Console.WriteLine("Name with J exists");
            }
            else
            {
                System.Console.WriteLine("Does not exist");
            }

            // finds first matching element from list
            Customer ct = lst.Find(cust => cust.Salary > 7000);
            System.Console.WriteLine(ct.Name + ct.Salary);
            // find last returns the last matcing element
            Customer ctt = lst.FindLast(cust => cust.Salary > 7000);
            System.Console.WriteLine(ctt.Name + ctt.Salary);
            System.Console.WriteLine("---------------");
            // find all returns all the cstomer that matches the condition
            List<Customer> cttt = lst.FindAll(cust => cust.Salary > 6000);
            foreach (var item in cttt)
            {
                System.Console.WriteLine(item.Name);
            }

            // find index
            lst.FindIndex(c => c.Name == "John");

            Customer[] carr = new Customer[3];
            carr[0] = new Customer { Id = 1, Name = "Hello", Salary = 6700 };
            carr[1] = new Customer { Id = 2, Name = "Foo", Salary = 6700 };
            carr[2] = new Customer { Id = 3, Name = "Bar", Salary = 6700 };
            List<Customer> cr = carr.ToList(); // array to list

            // add range allows to add a list to a list

            cr.AddRange(lst);
            foreach (var item in cr)
            {
                System.Console.WriteLine(item.Name);
            }
            // get multipl items
            List<Customer> cf = cr.GetRange(2, 5); // from index positin 2 we wat 5 items
            System.Console.WriteLine("-----------------");

            foreach (var item in cf)
            {
                System.Console.WriteLine(item.Name);
            }
            // remove
            cf.Remove(carr[0]);
            cf.RemoveAt(3);
            cf.RemoveRange(0, 3);
            cf.RemoveAll(d => d.Salary > 4000);
            cf.RemoveRange(2, 4);
            cf.Clear();
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
