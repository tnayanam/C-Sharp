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
            lblCount.Text = "Processing File Please Wait..";
            lblCount.Text = CountCharacter().ToString(); // as long as the process is completing appliation will be NOT Responsive
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
