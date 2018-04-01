using System.Threading;

namespace ThreadStartDelegateExample
{

    class Program
    {
        public static void Main()
        {
            System.Console.WriteLine("Main Thread Started.");
            Thread T1 = new Thread(ThreadOne);
            T1.Start();
            Thread T2 = new Thread(ThreadTwo);
            T2.Start();
            System.Console.WriteLine("Main Thread End.");
        }

        public static void ThreadOne()
        {
            System.Console.WriteLine("ThreadOne Started.");
        }

        public static void ThreadTwo()
        {
            System.Console.WriteLine("ThreadTwo Started.");
        }
    }


}

//// Output
//Main Thread Started.
//ThreadOne Started.
//Main Thread End.
//ThreadTwo Started.
//Press any key to continue . . .

// Output 2:
//Main Thread Started.
//ThreadOne Started.
//ThreadTwo Started.
//Main Thread End.
//Press any key to continue . . .

// Note thatn sequence is undetermined. Because anythread can start any sequence and main method does not wait for any of the threads.
