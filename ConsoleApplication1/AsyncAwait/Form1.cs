using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnProcess_Click(object sender, EventArgs e)
        {
            Task<int> t1 = new Task<int>(CountCharacter);
            t1.Start();
            lblCount.Text = "Processing File Please Wait..";
            int count = await t1; // as long as the process is completing appliation will be NOT Responsive
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
