namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer
            {
                Name = "Tanuj",
                Gender = 1 //now by just looking at this code one canot tell what gender 1 signifies. thats why we need ENUMS
            };
            customers[1] = new Customer
            {
                Name = "Mona",
                Gender = 0
            };
            customers[2] = new Customer
            {
                Name = "Arun",
                Gender = 2
            };

            foreach (var cut in customers)
            {
                System.Console.WriteLine(cut.Name + " " + Customer.GetGender(cut.Gender));
            }
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }

        public static string GetGender(int Gender)
        {
            switch (Gender)
            {
                case 0:
                    return "Unknown";

                case 1:
                    return "Male";

                case 2:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }
    }
}
