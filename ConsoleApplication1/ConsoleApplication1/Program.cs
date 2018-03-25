using System;

namespace ConsoleApplication1
{
    // Now a better approach, using properties
    // Business Rule
    /*
     * Id should not be negative
     * Name should not be empty or null
     * Passing Marks cannot be changed
     */
    class Test
    {
        private int _Passmarks = 345;
        private string _Name;
        private int _Id;
        // Now suppose there are certain scenarios where you  dont want any  validation on the field so for that  we have auto incremented
        //  properties
        // Example w/o autoincremented
        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        // Example with autoincremented
        public string State { get; set; }

        public int PassMarks
        {
            get
            {
                return _Passmarks;

            }
        }

        public string Name
        {
            get { return string.IsNullOrEmpty(_Name) ? "No Name" : _Name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("No Name Given");
                _Name = value;
            }
        }

        public int Id
        {
            get { return _Id; }
            set
            {
                if (value < 0)
                    throw new Exception("Id cannot be negative");
                _Id = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.Id = 3;
            t1.Name = "Hello";
            Console.WriteLine(t1.PassMarks);
            Console.WriteLine(t1.Name);
            Console.WriteLine(t1.Id); // now we are treating the setter getter as if they are variables. so that is the benefit of using PROPERTIES
            t1.State = "California";
            t1.City = "Delhi";
        }
    }
}

/*
 * So we cannot control what gets into those properties. So we need Encapsulation.
 * We use get and  set  methods  to implement properties
 
     */
