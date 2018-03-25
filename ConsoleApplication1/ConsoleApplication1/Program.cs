namespace ConsoleApplication1
{
    // Suppose we want to call derived class functions using a parent class refernce variable meaning polymorphism we need to do below.
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emps = new Employee[4];
            emps[0] = new Employee();
            emps[1] = new FullTimeEmployee();
            emps[2] = new PartTimeEmployee();
            emps[3] = new TemporaryEmployee();

            foreach (var e in emps)
            {
                e.DisplayName();
            }
        }
    }

    class Employee
    {
        public string firstName = "FN";
        public string lastName = "LN";
        public virtual void DisplayName()
        {
            System.Console.WriteLine(firstName + lastName);
            System.Console.WriteLine();
        }
    }

    class FullTimeEmployee : Employee
    {
        override public void DisplayName()
        {
            System.Console.WriteLine(firstName + lastName + " - FullTime");
            System.Console.WriteLine();
        }
    }


    class PartTimeEmployee : Employee
    {
        override public void DisplayName()
        {
            System.Console.WriteLine(firstName + lastName + " - PartTime");
            System.Console.WriteLine();
        }
    }

    class TemporaryEmployee : Employee
    {
        public void DisplayName()
        {
            System.Console.WriteLine(firstName + lastName + " - Temporary");
            System.Console.WriteLine();
        }
    }
}

/*
 * Polymorphism allows us to invoke derivd class methods with parent class reference variable
 * 
 * Output
 * FNLN

FNLN

FNLN

FNLN

Ideally we should have expected differnet output as methods of child should have been called, even we are getting green squiggly that
parent method is hidden still only the parent method is getting called.


    // New Output:
    FNLN

FNLN - FullTime

FNLN - PartTime

FNLN - (**)

    Now we are able to call child method function using the parent reference vaiable
    (**) note that if child class does not override then parent method gets called.



 */






