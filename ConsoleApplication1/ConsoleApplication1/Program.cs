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
// Multiple await in a program:

public async Task<HomeIndexModel> GetDataForIndexScreen()
{
    var client = new HttpClient();
    var step1 = client.GetStringAsync(...); 1st async operation
    var step2 = client.GetStringAsync(...); 2nd async operation
 
    // Assuming that return types from operations are HOMOGENEOUS
    var results = await Task.WhenAll(step1, step2); await both, when both is compelted then only continue.
 
    var model = new HomeIndexModel();
    model.News1 = ParseRssInternal(results[0]);
    model.News2 = ParseRssInternal(results[1]);
    return model;
} 

TO summarize the first guideline you should always prefer async task to async void.
async task methods enable easier error-handling, compasability and testability.
the exception to this is asynchronous event heandler, which must return void. 

Async Way of doing things

To Do This …	Instead of This …	Use This
Retrieve the result of a background task	Task.Wait or Task.Result	await
Wait for any task to complete           	Task.WaitAny	            await Task.WhenAny
Retrieve the results of multiple tasks  	Task.WaitAll            	await Task.WhenAll
Wait a period of time	                    Thread.Sleep	            await Task.Delay

To summarize this second guideline, you should avoid mixing async and blocking code. Mixed async and blocking code can cause deadlocks, 
more-complex error handling and unexpected blocking of context threads. The exception
 to this guideline is the Main method for console applications, or—if you’re an advanced user—managing a partially asynchronous codebase.
 If you use intellisence on task you will find two methods WaitAll and WhenAll, always use the WhenAll, as it keeps things asynchronous.
 
 
 One important point about awaitables is this: it is the type that is awaitable, not the method returning the type.
 In other words, you can await the result of an async method that returns Task … because the method returns Task, not because it’s async. 
 So you can also await the result of a non-async method that returns Task:

public async Task NewStuffAsync()
{
  // Use await and have fun with the new stuff.
  await ...
}

public Task MyOldTaskParallelLibraryCode() // no async method signature.
{
  // Note that this is not an async method, so we can't use await in here.
  ...
}

public async Task ComposeAsync()
{
  // We can await Tasks, regardless of where they come from.
  await NewStuffAsync();
  await MyOldTaskParallelLibraryCode(); as the return type is Tasj it can be awaited. it does not have to be asyn method signature.
}


Avoiding Context
Most of the time, you don’t need to sync back to the “main” context. Most async methods will be designed with composition in mind: they await other operations, and each one represents an asynchronous operation itself (which can be composed by others). In this case, you want to tell the awaiter to not capture the current context by calling ConfigureAwait and passing false, e.g.:

private async Task DownloadFileAsync(string fileName)
{
  // Use HttpClient or whatever to download the file contents.
  var fileContents = await DownloadFileContentsAsync(fileName).ConfigureAwait(false);

  // Note that because of the ConfigureAwait(false), we are not on the original context here.
  // Instead, we're running on the thread pool.

  // Write the file contents out to a disk file.
  await WriteToDiskAsync(fileName, fileContents).ConfigureAwait(false);

  // The second call to ConfigureAwait(false) is not *required*, but it is Good Practice.
}

// WinForms example (it works exactly the same for WPF).
private async void DownloadFileButton_Click(object sender, EventArgs e)
{
  // Since we asynchronously wait, the UI thread is not blocked by the file download.
  await DownloadFileAsync(fileNameTextBox.Text);

  // Since we resume on the UI context, we can directly access UI elements.
  resultTextBox.Text = "File downloaded!";
}
The important thing to note with this example is that each “level” of async method calls has its own context. DownloadFileButton_Click started in the UI context, and called DownloadFileAsync. DownloadFileAsync also started in the UI context, but then stepped out of its context by calling ConfigureAwait(false). The rest of DownloadFileAsync runs in the thread pool context. However, when DownloadFileAsync completes and DownloadFileButton_Click resumes, it does resume in the UI context.

A good rule of thumb is to use ConfigureAwait(false) unless you know you do need the context.

Async Composition
So far, we’ve only considered serial composition: an async method waits for one operation at a time. It’s also possible to start several operations and await for one (or all) of them to complete. You can do this by starting the operations but not awaiting them until later:

public async Task DoOperationsConcurrentlyAsync()
{
  Task[] tasks = new Task[3];
  tasks[0] = DoOperation0Async();
  tasks[1] = DoOperation1Async();
  tasks[2] = DoOperation2Async();

  // At this point, all three tasks are running at the same time.

  // Now, we await them all.
  await Task.WhenAll(tasks);
}

public async Task<int> GetFirstToRespondAsync()
{
  // Call two web services; take the first response.
  Task<int>[] tasks = new[] { WebService1Async(), WebService2Async() };

  // Await for the first one to respond.
  Task<int> firstTask = await Task.WhenAny(tasks);

  // Return the result.
  return await firstTask;
}
By using concurrent composition (Task.WhenAll or Task.WhenAny), you can perform simple concurrent operations. You can also use these methods
 along with Task.Run to do simple parallel computation. 
However, this is not a substitute for the Task Parallel Library - any advanced CPU-intensive parallel operations should be done with the TPL.

Old	New	Description
task.Wait	await task	Wait/await for a task to complete
task.Result	await task	Get the result of a completed task
Task.WaitAny	await Task.WhenAny	Wait/await for one of a collection of tasks to complete
Task.WaitAll	await Task.WhenAll	Wait/await for every one of a collection of tasks to complete
Thread.Sleep	await Task.Delay	Wait/await for a period of time
Task constructor	Task.Run or TaskFactory.StartNew	Create a code-based task


// Actual syntax
public async Task<int> GetValue()
{
  // Asynchronously retrieve two partial values.
  // Note that these are *not* awaited at this time.
  Task<int> part1 = GetValuePart1();
  Task<int> part2 = GetValuePart2();

  // Wait for both values to arrive.
  await TaskEx.WhenAll(part1, part2);

  // Calculate our result.
  int value1 = await part1; // Does not actually wait.
  int value2 = await part2; // Does not actually wait.
  return value1 + value2;
}

Cause of Deadlock in Wrongly Written Asyn Await function:

// My "library" method.
public static async Task<JObject> GetJsonAsync(Uri uri)
{
  using (var client = new HttpClient())
  {
    var jsonString = await client.GetStringAsync(uri);
    return JObject.Parse(jsonString);
  }
}

// My "top-level" method.
public class MyController : ApiController
{
  public string Get()
  {
    var jsonTask = GetJsonAsync(...);
    return jsonTask.Result.ToString();
  }
}

This code will cause the deadlock, Ok here is the reason.
1. whenever an await task is found the method runs in a particular context.
flow that happens in above example:

The top-level method calls GetJsonAsync (ASP.NET context).
GetJsonAsync starts the REST request by calling HttpClient.GetStringAsync (still within the context).
GetStringAsync returns an uncompleted Task, indicating the REST request is not complete.
GetJsonAsync awaits the Task returned by GetStringAsync. The context is captured and will be used to continue
 running the GetJsonAsync method later. 
 GetJsonAsync returns an uncompleted Task, indicating that the GetJsonAsync method is not complete.
 The top-level method synchronously blocks on the Task returned by GetJsonAsync. This blocks the context thread.
 Eventually, the REST request will complete. This completes the Task that was returned by GetStringAsync.
  The continuation for GetJsonAsync is now ready to run, and it waits for the context to be available so it can execute in the context.
  Deadlock. The top-level method is blocking the context thread, waiting for GetJsonAsync to complete, and GetJsonAsync is waiting for 
  the context to be free so it can complete.
  
  Preventing this deadlock:
  
  the best way to prevent these kinds of deadlocks:
  
public async void Button1_Click(...)
{
  var json = await GetJsonAsync(...);
  textBox1.Text = json;
}

public class MyController : ApiController
{
  public async Task<string> Get()
  {
    var json = await GetJsonAsync(...);
    return json.ToString();
  }
}



Async void methods have different error-handling semantics. When an exception is thrown out of an async Task or async 
Task<T> method, that exception is captured and placed on the Task object. With async void methods, there is no Task object, 
so any exceptions thrown out of an async void method will be raised directly on the SynchronizationContext that was active when 
the async void method started. 

private async void ThrowExceptionAsync()
{
  throw new InvalidOperationException();
}
public void AsyncVoidExceptions_CannotBeCaughtByCatch()
{
  try
  {
    ThrowExceptionAsync();
  }
  catch (Exception)
  {
    // The exception is never caught here!
    throw;
  }
}




 */
