namespace MainSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Hello();
            c1.World();
        }
    }
}
/*
 * visual studio uses partial classes to s`eperate automatically generated designer code from
 * developer code.
 * During run time these partial classes combine into one file.
 * 
 * All parts spread across different files, must use the keyword "partial" keyword.
 */
