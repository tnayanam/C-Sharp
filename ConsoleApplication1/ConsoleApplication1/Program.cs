﻿namespace ConsoleApplication1
{
    // Hiding  Example One
    // Simple Class Example
    class Program
    {
        static void Main(string[] args)
        {
            Child c1 = new Child();
            /// now this is calling the display method of child. Hence the \parent display method is hidden.
            ((Employee)c1).Display();
        }
    }
    class Employee
    {
        public void Display()
        {
            System.Console.WriteLine("I am parent");
        }
    }

    class Child : Employee
    {
        public new void Display() //After adding NEW keyword green squiggly goes off
        {
            System.Console.WriteLine("I am child");
        }
    }
}

/* 
I am parent
Press any key to continue . . .



 */

