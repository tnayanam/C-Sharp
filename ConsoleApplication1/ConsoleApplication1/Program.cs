namespace ConsoleApplication1
{
    // Simple Class Example
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Tanuj", "Nayanam");
            c1.Display();
        }
    }

    class Customer
    {
        private string _lastName; // keep underscore for private varibles name
        private string _firstName;

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

