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

    // In a way, asynchronous methods behave contagiously. To call an asynchronous method with await, you must make the calling method
    asynchronous as well, even if it was not async before. Now, all methods calling this newly asynchronous method must also become
    asynchronous. This pattern repeats itself up the call stack until it finally reaches the entry points, e.g. event handlers.
    // When multiple await operations need to be awaited
    public async Task<ActionResult> PWGasync()
{
    ViewBag.SyncType = "Asynchronous";
    var widgetService = new WidgetService();
    var prodService = new ProductService();
    var gizmoService = new GizmoService();

    var widgetTask = widgetService.GetWidgetsAsync();
    var prodTask = prodService.GetProductsAsync();
    var gizmoTask = gizmoService.GetGizmosAsync();

    await Task.WhenAll(widgetTask, prodTask, gizmoTask);

    var pwgVM = new ProdGizWidgetVM(
       widgetTask.Result,
       prodTask.Result,
       gizmoTask.Result
       );

    return View("PWG", pwgVM);
}

    A better slogan is async all the way up. Because you start with an asynchronous operation and make its caller asynchronous and then the next caller etc.

You should use async-await when you have an inherently asynchronous operation (usually I/O but not necessarily) and you don't want to waste a thread idly waiting for the operation to complete. Choosing an async operation instead of a synchronous one doesn't speed up the operation. It will take the same amount of time (or even more). It just enables that thread to continue executing some other CPU bound work instead of wasting resources.

But to be able to await that operation the method needs to be an async one and the caller needs to await it and so forth and so forth.

So async all the way up enables you to actually make an asynchronous call and release any threads. If it isn't async all the way then some thread is being blocked.

So, this:

async Task FooAsync()
{
    await Func1();
    // do other stuff
}

async Task Func1()
{
    await Func2();
    // do other stuff
}

async Task Func2()
{
    await tcpClient.SendAsync();
    // do other stuff
}
Is better than this:

void Foo()
{
    Func1();
    // do other stuff
}

void Func1()
{
    Func2().Wait();  // Synchronously blocking a thread.
    // do other stuff
}

async Task Func2()
{
    await tcpClient.SendAsync();
    // do other stuff
}

 */
