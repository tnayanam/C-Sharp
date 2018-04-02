using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace AsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            int count = 0;
            //Task<int> t1 = new Task<int>(CountCharacter);
            //t1.Start();
            //Thread t2 = new Thread(CountCharacter); since the thread is returning something we need to use lamda expressions
            Thread t2 = new Thread(() => { count = CountCharacter(); }); // lamda expression
            t2.Start();
            lblCount.Text = "Processing File Please Wait..";
            t2.Join(); // this will make sure UI thread is waiting for the countchracter function to finish excuting and join main thread
            // but the problem now is our UI become un respionsive till the time the main is waiting for the t2 to fnish execution
            // it was not happening in Task Example.
            lblCount.Text = count.ToString();
        }

        public static int CountCharacter()
        {
            int count = 0;
            using (StreamReader rdr = new StreamReader("C:\\eula.1028.txt"))
            {
                string content = rdr.ReadToEnd();
                count = content.Length;
            }
            Thread.Sleep(3000);

            return count;
        }
    }
}
