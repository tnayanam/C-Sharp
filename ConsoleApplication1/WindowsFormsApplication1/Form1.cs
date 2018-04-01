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

            DoTimeConsumingWork();

            btnDoTimeConsumingWork.Enabled = true;
            btnPrintNumbers.Enabled = true;
        }

        public void DoTimeConsumingWork()
        {
            Thread.Sleep(5000);
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
