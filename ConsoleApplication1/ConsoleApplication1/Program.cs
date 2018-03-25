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
        public int Passmarks;
        public string Name;
        public int Id;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.Id = -1;
            t1.Name = null;
            t1.Passmarks = 0;
        }
    }
}

/*
 * So we cannot control what gets into those properties. So we need Encapsulation.
 
     */
