using System.Text;

namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            string name = string.Empty;
            name += "Tanuj"; // new mmeory space with tanuj

            name += " Nayanam"; // new memory space with tanuj nayanam
            name += " is"; // new memory space with tanuj nayanam is
            name += " a";
            name += " Dumb";
            name += " Boy";
            System.Console.WriteLine(name);

            StringBuilder name1 = new StringBuilder();
            name1.Append("Tanuj");
            name1.Append(" Nayanam");
            name1.Append(" is");
            name1.Append(" a");
            name1.Append(" Dumb");
            name1.Append(" Boy");
            System.Console.WriteLine(name1);
        }
    }
}

// output is same bu string is immutable where is stringbuiilder is mutable
// that means that when ever we assing a new value to streing a separeate memore is create to store the string and old memory is left orphanced. thus we see serious pperfomrance issue. So we should always use string builder because sam mempry space is used. nothing is or[haned

