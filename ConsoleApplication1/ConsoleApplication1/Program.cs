namespace ConsoleApplication1
{
    // Hiding  Example One
    // Simple Class Example
    class Program
    {
        static void Main(string[] args)
        {
            Employee c1 = new Child(); // parent is potining to address of Child
            //Child c2 = new Employee(); // THIS WILL NOT WORK!!
            c1.Display();
        }
    }
    class Employee
    {
        public void Display()
        {
            System.Console.WriteLine("I am parent");
        }
    }
    class Child : Employee
    {
        public new void Display() //After adding NEW keyword green squiggly goes off
        {
            System.Console.WriteLine("I am child");
        }
    }
}

//I am parent
//Press any key to continue . . .




