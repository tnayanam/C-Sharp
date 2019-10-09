using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilders
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int var = 40;
            for(int i = 0;i < 10; i++)
                sb.Append(i).Append(" - ");
            sb.AppendLine();
            sb.AppendLine("Hello big boss");
            sb.Append("New Line after this").AppendLine();
            sb.AppendFormat($"New Line after this {var}").AppendLine();
            sb.Append("this is the this in this");
            sb.Replace("this", "no");
            Console.WriteLine(sb.ToString());
            Console.WriteLine(sb);
        }
    }
}


// Output //
//0 - 1 - 2 - 3 - 4 - 5 - 6 - 7 - 8 - 9 -
//Hello big boss
//New Line after no
//New Line after no 40
//no is the no in no
//0 - 1 - 2 - 3 - 4 - 5 - 6 - 7 - 8 - 9 -
//Hello big boss
//New Line after no
//New Line after no 40
//no is the no in no