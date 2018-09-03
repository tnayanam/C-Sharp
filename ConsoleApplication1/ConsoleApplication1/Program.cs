// Three things to note in the signature:  
//  - The method has an async modifier.   
//  - The return type is Task or Task<T>. (See "Return Types" section.)  
//    Here, it is Task<int> because the return statement returns an integer.  
//  - The method name ends in "Async." 

using System;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start the HandleFile method.
            Task<int> task = HandleFileAsync();

            // Control returns here before HandleFileAsync returns.
            // ... Prompt the user.
            Console.WriteLine("Please wait patiently " +
                "while I do something important.");

            // Do something at the same time as the file is being read.
            string line = Console.ReadLine();
            Console.WriteLine("You entered (asynchronous logic): " + line);

            // Wait for the HandleFile task to complete.
            // ... Display its results.
            task.Wait();
            var x = task.Result; // this is how we get result from a task
            Console.WriteLine("Count: " + x);

            Console.WriteLine("[DONE]");
            Console.ReadLine();
        }

        static async Task<int> HandleFileAsync()
        {
            string file = @"C:\programs\enable1.txt";
            Console.WriteLine("HandleFile enter");
            int count = 0;

            // Read in the specified file.
            // ... Use async StreamReader method.
            using (StreamReader reader = new StreamReader(file))
            {
                string v = await reader.ReadToEndAsync();

                // ... Process the file data somehow.
                count += v.Length;

                // ... A slow-running computation.
                //     Dummy code.
                for (int i = 0; i < 10000; i++)
                {
                    int x = v.GetHashCode();
                    if (x == 0)
                    {
                        count--;
                    }
                }
            }
            Console.WriteLine("HandleFile exit");
            return count;
        }
    }
}

/*
 * An async method typically returns a Task or a Task<TResult>. Inside an async method, an await operator is applied to a task that's returned from a call to another async method.

You specify Task<TResult> as the return type if the method contains a return statement that specifies an operand of type TResult.

You use Task as the return type if the method has no return statement or has a return statement that doesn't return an operand.
 */
