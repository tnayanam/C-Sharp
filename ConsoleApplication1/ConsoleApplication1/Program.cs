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
                Gender = Gender.Male //now by just looking at this code one canot tell what gender 1 signifies. thats why we need ENUMS
            };
            customers[1] = new Customer
            {
                Name = "Mona",
                Gender = Gender.Female
            };
            customers[2] = new Customer
            {
                Name = "Arun",
                Gender = Gender.Unknown
            };

            foreach (var cut in customers)
            {
                System.Console.WriteLine(cut.Name + " " + Customer.GetGender(cut.Gender));
            }
        }
    }

    public enum Gender
    {
        Male,
        Female,
        Unknown
    }

    class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }

        public static string GetGender(Gender Gender)
        {
            switch (Gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }
    }
}
