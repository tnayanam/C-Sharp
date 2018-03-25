using System;

namespace ConsoleApplication1
{
    // Business Rule
    /*
     * Id should not be negative
     * Name should not be empty or null
     * Passing Marks cannot be changed
     */
    class Test
    {
        private int _Passmarks;
        private string _Name;
        private int _Id;

        public void SetID(int Id)
        {
            if (Id < 0)
                throw new Exception("Id cannot be negative");
            _Id = Id;
        }
        public int GetID()
        {
            return _Id;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
                throw new Exception("No Name Given");
            _Name = Name;
        }

        public string GetName()
        {
            return string.IsNullOrEmpty(_Name) ? "No Name" : _Name;
        }

        public int GetMarks()
        {
            return _Passmarks;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            //t1.passingMarks - passing marks cannot be set now.
            //t1.SetID(-2); // this will throw exception
            Console.WriteLine(t1.GetName()); // No Name output
            t1.SetName(null); // Exception

        }
    }
}

/*
 * So we cannot control what gets into those properties. So we need Encapsulation.
 
     */
