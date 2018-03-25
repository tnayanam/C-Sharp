namespace ConsoleApplication1
{
    // Simple Class Example
    class Program
    {
        static void Main(string[] args)
        {
            //Customer c1 = new Customer(); // this will throw error because compiler does not provide default contructor if
            // you alreadfy have created an constructor.(
            // so now if we want a default constructor we need to provide explicitly.  (**)
            Customer c1 = new Customer(); // now this will not throw error.
            Customer c2 = new Customer("Tanuj", "Nayanam");
            c1.Display();
        }
    }

    class Customer
    {
        private string _lastName; // keep underscore for private varibles name
        private string _firstName;
        // (**)
        public Customer()
        {

        }

        public Customer(string FirstName, string LastName)
        {
            _firstName = FirstName;
            _lastName = LastName;
        }

        public void Display()
        {
            System.Console.WriteLine("FirstName is {0} and LastName is {1}", _firstName, _lastName);
        }
    }
}

