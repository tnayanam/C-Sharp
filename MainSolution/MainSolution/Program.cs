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
 * all the partials for a class must have same access modifiers
 * if any of the paritals is set to abstract then all the partials for that class gets abstract
 * different part of partial class cannot put different base class because
 * c# does not suport multiple class inheritance.
 * Any member that are declared in the partial is available in other parial too
 * 
 */
