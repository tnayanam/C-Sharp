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

            T1.Join(2000); // 1 sec now this main will just wait for 2 second for the thread `1 to join it. if it does not join main will proceed
            System.Console.WriteLine("ThreadOne Completed");
            T2.Join();
            System.Console.WriteLine("ThreadTwo Completed");
            // so now the main method will not execute unless t1 and t2 finish its execution and merges back to main UI thread
            System.Console.WriteLine("Main Thread End.");
        }

        public static void ThreadOne()
        {
            System.Console.WriteLine("ThreadOne Started.");
            Thread.Sleep(5000);// 5 secs
            System.Console.WriteLine("ThredaOne is now about to complete");
        }

        public static void ThreadTwo()
        {
            System.Console.WriteLine("ThreadTwo Started.");
        }
    }


}

// output
//Main Thread Started.
//ThreadOne Started.
//ThreadTwo Started.
//ThreadOne Completed // clearly see here that main did not wait for the thread 1 to reutrn after 2 sceond and it proceed further
//ThreadTwo Completed
//Main Thread End.
//ThredaOne is now about to complete
//Press any key to continue . . .








