namespace ConsoleApplication1
{
    // Suppose we want to call derived class functions using a parent class refernce variable meaning polymorphism we need to do below.
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new FullTimeEmployee();
            e1.DisplayName(); // this is calling hidden method in base class - Method Hiding
            e1.PrintName();// this is calling method in deroved class - Method Overriding
        }
    }

    class Employee
    {
        public string firstName = "FN";
        public string lastName = "LN";
        public void DisplayName()
        {
            System.Console.WriteLine(firstName + lastName);
        }
        public virtual void PrintName()
        {
            System.Console.WriteLine(firstName + lastName);
        }
    }

    class FullTimeEmployee : Employee
    {
        public void DisplayName()
        {
            System.Console.WriteLine(firstName + lastName + " - FullTime");
        }
        public override void PrintName()
        {
            System.Console.WriteLine(firstName + lastName + " - FullTime");
        }
    }

    class PartTimeEmployee : Employee
    {
        public void DisplayName()
        {
            System.Console.WriteLine(firstName + lastName + " - PartTime");
        }

    }

    class TemporaryEmployee : Employee
    {
        public void DisplayName()
        {
            System.Console.WriteLine(firstName + lastName + " - Temporary");
        }
    }
}


