using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoTimeConsumingWork_Click(object sender, EventArgs e)
        {
            btnDoTimeConsumingWork.Enabled = false;
            btnPrintNumbers.Enabled = false;

            ParameterizedThreadStart ptm = new ParameterizedThreadStart(DoTimeConsumingWork); // here if we see the
            // definition of ParameterizedThreadStart it can only point to a fuction which takes object as parameter
            // thats why we had to change the DoTimeConsumingWork to take input as Object.
            // Also why in the first palce we needed ParameterizedThreadStart because the Thread constructor below
            // requiresinstance of ParameterizedThreadStart to be passed when we need to pass any parameter to our threadinf
            // method. IUdeally if no parameter is required we were usinf "THreadStart" which does not take any parameter (check previous example)
            Thread workerThread = new Thread(ptm); // if we look closely here, we are passing a function delegate. and then in the next line
            // we are calling the thread instance which in turns calls the delegate which in turn calls the fucnction it points to
            // if you go the constructor of Thread class you will see the definition as below
            //public Thread(ThreadStart start); where ThreadStart is of type Delegate
            //
            workerThread.Start(5000);
            //DoTimeConsumingWork();
            // Another way of calling worker thread by explicitly mentioing it as delegate
            //Thread wTh = new Thread(delegate ()
            //{
            //    DoTimeConsumingWork();
            //});
            //wTh.Start();

            btnDoTimeConsumingWork.Enabled = true;
            btnPrintNumbers.Enabled = true;
        }

        public static void DoTimeConsumingWork(object num)
        {
            Thread.Sleep((int)num);
            MessageBox.Show("Time Consuming Work Ended");
        }

        private void btnPrintNumbers_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}

// Nothing you can do when the time is getting consumed because we have just one threa whih is UI thread. So, we cannot click on print numbers button. the window in unresponsive

// In this case we are sending values to the threading function.

// More points:
// Whenever we need to pass parameter use ParameterizedThreadStart when no data needs to be passed use "ThreadStart".
// Disadvantage of ParameterizedThreadStart is that it is not type safe anymore. I mean if you go that delegate defintiion
// it accepts an object as the parameter that means at line "workerThread.Start(5000);" I could have passed even a string 
// and there will be no compile time error as string also eventually derives from Object parent class. But when it wil
// come to execute in the actual method call whichis public static void DoTimeConsumingWork(object num)
// inside its logic we want the num to  be integer thus we will get Errors and Program will Crash.


