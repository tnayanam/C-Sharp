namespace ConsoleApplication1
{
    public delegate void DelForMethod(string Message);
    // Delegate
    class Program
    {
        static void Main(string[] args)
        {
            DelForMethod d1 = new DelForMethod(Add);
            d1("Hmmm");
        }
        public static void Add(string strMessage)
        {
            System.Console.WriteLine(strMessage);
        }
    }

    // delegate is a type safe function pointer
    // signature of delegate must match the signature of the method it points too.
}


