using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<int> numbers = new List<int> { 1, 8, 7, 5, 2, 3, 4, 9, 6 };

        Console.WriteLine("Numbers before sorting");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        // Sort() will sort data in ascending order 
        numbers.Sort();

        Console.WriteLine("Numbers after sorting");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        // Use Reverse() method to retrieve data in descending order
        numbers.Reverse();

        Console.WriteLine("Numbers in descending order");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        List<string> alphabets = new List<string>() { "B", "F", "D", "E", "A", "C" };

        Console.WriteLine("Alphabets before sorting");
        foreach (string alphabet in alphabets)
        {
            Console.WriteLine(alphabet);
        }

        alphabets.Sort();

        Console.WriteLine("Alphabets after sorting");
        foreach (string alphabet in alphabets)
        {
            Console.WriteLine(alphabet);
        }

        alphabets.Reverse();

        Console.WriteLine("Alpabets in descending order");
        foreach (string alphabet in alphabets)
        {
            Console.WriteLine(alphabet);
        }

        Customer customer1 = new Customer()
        {
            ID = 101,
            Name = "Zark",
            Salary = 4000
        };

        Customer customer2 = new Customer()
        {
            ID = 102,
            Name = "Mam",
            Salary = 7000
        };

        Customer customer3 = new Customer()
        {
            ID = 103,
            Name = "Rob",
            Salary = 5500
        };

        List<Customer> listCustomers = new List<Customer>();
        listCustomers.Add(customer1);
        listCustomers.Add(customer2);
        listCustomers.Add(customer3);

        Console.WriteLine("Customers before sorting");
        foreach (Customer customer in listCustomers)
        {
            Console.WriteLine(customer.Name);
        }
        // workig fine now
        listCustomers.Sort();

        Console.WriteLine("Customers after sorting");
        foreach (Customer customer in listCustomers)
        {
            Console.WriteLine(customer.Name);
        }
    }
}

public class Customer : IComparable<Customer>
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }

    public int CompareTo(Customer other)
    {
        return this.Name.CompareTo(other.Name); // int implements compare to so we can use it.
    }
}