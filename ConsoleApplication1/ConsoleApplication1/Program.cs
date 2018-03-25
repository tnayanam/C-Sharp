namespace ConsoleApplication1
{
    // Hiding  Example One
    // Simple Class Example
    class Program
    {
        static void Main(string[] args)
        {
            Child c1 = new Child();
            /// now this is calling the display method of child. Hence the \parent display method is hidden.
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
        public void Display() // we will see a green
                              //squiggly here which tells use that because of this method parent method is getting HIDDEN.
        {
            System.Console.WriteLine("I am child");
        }
    }
}

