using System.Threading;

namespace ThreadStartDelegateExample
{
    // suppose we want to guarantee that main method only ends after threa 1 and thread 2 has been executed. Then we need to do something like below
    class Program
    {
        public static void Main()
        {
            System.Console.WriteLine("Main Thread Started.");
            Thread T1 = new Thread(ThreadOne);
            T1.Start();
            Thread T2 = new Thread(ThreadTwo);
            T2.Start();
            T1.Join();
            System.Console.WriteLine("ThreadOne Completed");
            T2.Join();
            System.Console.WriteLine("ThreadTwo Completed");
            // so now the main method will not execute unless t1 and t2 finish its execution and merges back to main UI thread
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

//// Same Output all the time
//Main Thread Started.
//ThreadOne Started.
//ThreadTwo Started.
//Main Thread End.
//Press any key to continue . . .






