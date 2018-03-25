namespace ConsoleApplication1
{
    // Simple Class Example
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FE = new FullTimeEmployee();
            FE.firstName = "Hello";
            FE.yearlySalary = 34000;
            PartTimeEmployee PE = new PartTimeEmployee() { firstName = "Tanuj", hourlyRate = 23 };
        }
    }

    class Employee
    {
        public string firstName;
        public Employee()
        {
            System.Console.WriteLine("This is base class constructor");
        }
    }

    class FullTimeEmployee : Employee
    {
        public int yearlySalary;
        public FullTimeEmployee()
        {
            System.Console.WriteLine("This is full time derived class constructor");
        }
    }

    class PartTimeEmployee : Employee
    {
        public int hourlyRate;
        public PartTimeEmployee()
        {
            System.Console.WriteLine("This is partime derived constructor");
        }
    }
}

/*
 * OUTPUT
 * This is base class constructor
This is full time derived class constructor
This is base class constructor
This is partime derived constructor
Always base class constructor gets called first before the child class.
Base class is automaticall yinstantiated when child class object is created.    
C# only supports single class inheritance

     class PartTimeEmployee : Employee, ABC this is not supported.
 */
