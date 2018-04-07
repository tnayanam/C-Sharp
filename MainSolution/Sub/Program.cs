using System.Diagnostics;

namespace Sub
{
    class Program
    {
        static void Main(string[] args)
        {
            string arg = string.Format("{0} {1}", "Hello", "World");
            Process.Start(@".\..\..\..\Sub2\bin\Debug\Sub2.exe", arg);
        }
    }
}

/*
 * Here we are running two exe together. Basically we want to call
 * Sub2.exe from this project (Sub.exe). So,  steps are
 * We need to make sure we give the path properly and also
 * we need to run Sub.exe and cross the process.start breakpoint.
 * Now in the same time we need to open other instance of Sub2.exe solution
 * There we need to add a thread.sleep so that the Sub.exe gices us time to
 * attach the debugger. MAKE SURE that after adding the sleep we build both Sub and Sub2.exe properly
 * Now we in other instance put a breakpoint just after the thread.sleep so that
 * and Now run Sub.exe and once process.strt executes go to othe instance of VS and click onn debug attach to process and
 * attach the Sub2.exe there. Breakpint will hit now.
 * Basically the Sub -> calls Sub2.exe ->and if we attach an explicit Sub2.exe in other instace if Sub2.exe it tries to hit breakpoint in it. 
 * // we need to send data as space separater. 
 */
