using System;
using System.Threading;

namespace ThreadStartDelegateExample
{
    class Program
    {
        public static void Main()
        {
            // Prompt the user for the target number
            Console.WriteLine("Please enter the target number");
            // Read from the console and store it in target variable
            int target = Convert.ToInt32(Console.ReadLine());

            // Create an instance of the Number class, passing it
            // the target number that was read from the console
            Number number = new Number(target);
            // Specify the Thread function
            Thread T1 = new Thread(new ThreadStart(number.PrintNumbers));
            // Alternatively we can just use Thread class constructor as shown below
            // Thread T1 = new Thread(number.PrintNumbers);
            T1.Start();
        }
    }

    // Number class also contains the data it needs to print the numbers
    class Number
    {
        int _target;
        // When an instance is created, the target number needs to be specified
        public Number(int target)
        {
            // The targer number is then stored in the class private variable _target
            this._target = target;
        }

        // Function prints the numbers from 1 to the traget number that the user provided
        public void PrintNumbers()
        {
            for (int i = 1; i <= _target; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

// see how cleverly during the class instance we need to provide the target by this now we will use threadstart delegate asd
// we no more need to pass the data via delegate call. Also, note that we have not provided default constructor int he Number
// class so one has to pass the target number. thus how cleverly we made everything type sae.