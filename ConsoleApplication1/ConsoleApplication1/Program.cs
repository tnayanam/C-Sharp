using System.Collections.Generic;

namespace ConsoleApplication1
{
    // Problem when delegates are not present!

    class Employee
    {
        public int Salary;
        public string Name;
        public static void PromoteEmployee(List<Employee> empL)
        {
            foreach (var emp in empL)
            {
                if (emp.Salary > 4000)
                    System.Console.WriteLine(emp.Name + " promoted");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empL = new List<Employee>
            {
                new Employee {Name = "Patrick", Salary = 4500 },
                new Employee {Name = "Messy", Salary = 500 },
                new Employee {Name = "Gordon", Salary = 200 },
                new Employee {Name = "Marey", Salary = 5500 }
            };
            Employee.PromoteEmployee(empL);
        }
    }

    // now if someone wants to change the logic of promotion of employee it has to come here and change the class methods. that sthe problem.
    // delegates are extensively used in framweork development as we can inject our own logic to it w/o modifying the framework code.
}


