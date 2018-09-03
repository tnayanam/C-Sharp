// Three things to note in the signature:  
//  - The method has an async modifier.   
//  - The return type is Task or Task<T>. (See "Return Types" section.)  
//    Here, it is Task<int> because the return statement returns an integer.  
//  - The method name ends in "Async." 

using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = AcessTheWebAsync();
            task.Wait(); // this is very important, otherwise program execution will end and await thread will terminate.
            System.Console.WriteLine(task.Result);
        }

        public static async Task<int> AcessTheWebAsync()
        {
            HttpClient client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync("http://msdn.microsoft.com"); // here a different thread is assigned
            DoIndependentWork(); // main thread continues here
            string urlContents = await getStringTask; // Now here the main thread suspends and goes back to the caller. 
            return urlContents.Length;
        }

        private static void DoIndependentWork()
        {
            // do all the work here for which you dont need the output of GetStringAsync
        }
    }
}
