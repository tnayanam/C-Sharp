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

            Thread workerThread = new Thread(DoTimeConsumingWork); // if we look closely here, we are passing a function delegate. and then in the next line
            // we are calling the thread instance which in turns calls the delegate which in turn calls the fucnction it points to
            // if you go the constructor of Thread class you will see the definition as below
            //public Thread(ThreadStart start); where ThreadStart is of type Delegate
            //
            workerThread.Start();
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

        public static void DoTimeConsumingWork()
        {
            Thread.Sleep(5000);
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

