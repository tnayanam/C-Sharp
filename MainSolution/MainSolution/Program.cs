using System;
namespace MainSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "2";
            string s2 = "t";

            int temp1 = Int32.Parse(s1); // it converts integer to exact integer output - 2 but if string cannot be converted to integer it throws exception
            Console.WriteLine(temp1);
            int temp2;
            Console.WriteLine(Int32.TryParse(s2, out temp2)); // output = false
            Console.WriteLine(temp2); // no exception is raised only default value of interger is saved.
            string str = "1d2";
            string[] temparr = str.Split('d'); // temparr[0] = 1 and temp[1] = 2 => string array
            string[] temparr1 = str.Split('r'); // temparr1[0] since no split can be done it returns the entire string  

            Random r = new Random();

            Console.WriteLine(r.Next(2,10));
            Console.WriteLine(r.Next(2, 10));
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
