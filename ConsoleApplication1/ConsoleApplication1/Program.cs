using System.Collections.Generic;

namespace ConsoleApplication1
{
    delegate bool CheckIfEligible(Employee emp);
    // Problem when delegates are not present!

    class Employee
    {
        public int Salary;
        public string Name;
        public static void PromoteEmployee(List<Employee> empL, CheckIfEligible chk)
        {
            foreach (var emp in empL)
            {
                if (chk(emp))
                    System.Console.WriteLine(emp.Name + " promoted");
            }
        }
    }

    class Program
    {
        //public static bool IsPromotable(Employee emp)
        //{
        //    return (emp.Salary > 4000) ? true : false;
        //}

        //public static bool IsPromotable1(Employee emp)
        //{
        //    return (emp.Salary > 200) ? true : false;
        //}

        static void Main(string[] args)
        {
            List<Employee> empL = new List<Employee>
            {
                new Employee {Name = "Patrick", Salary = 4500 },
                new Employee {Name = "Messy", Salary = 500 },
                new Employee {Name = "Gordon", Salary = 200 },
                new Employee {Name = "Marey", Salary = 5500 }
            };
            //CheckIfEligible c1 = new CheckIfEligible(Program.IsPromotable);
            Employee.PromoteEmployee(empL, emp => emp.Salary > 4000);

            // Now supose I want to promote based on just >200 salary then I dont need to chnage any code in the helper function/framework.
            //c1 = new CheckIfEligible(Program.IsPromotable1);
            Employee.PromoteEmployee(empL, emp => emp.Salary > 200);
        }
    }

    // now if someone wants to change the logic of promotion of employee it has to come here and change the class methods. that sthe problem.
    // delegates are extensively used in framweork development as we can inject our own logic to it w/o modifying the framework code.
}


