namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///*
            // * Value type and reference types:
            // * int, struct, enums, bool are all value types: That means if we leave then empty they will have their default value.these are NON
            // * Non NUllable types

            // int t;
            // if we print t it will have 0
            // bool isavail;
            // if we print it it will print false.

            //Reference types are nullable types.
            //string,classes.
            //string abc;
            //if we print abc it will have null value.

            //Now how can we convert a non-nullable type to nullable type.
            //int? age;
            //now if you print age it will allow null values.
            // */
            //// NUll Coalsceing Operator
            //int? totalTickets = null;
            //int availableTickets;
            //if (totalTickets == null)
            //{
            //    availableTickets = 0;
            //}
            //else
            //{
            //    availableTickets = totalTickets.Value;
            //}
            //// above if  else statement can be coverted like below:
            //availableTickets = totalTickets ?? 0;
            // PASS by VALUE:
            int FN = 2;
            int SN = 8;
            int sum = 0;
            int prod = 0;
            //PassByValue(FN, SN);
            //System.Console.WriteLine("In main method value of FN is {0} and value of SN is {1}", FN, SN); // 0.0
            //// PASS by REFERENCE:
            //PassByRef(ref FN, ref SN);
            //System.Console.WriteLine("In main method value of FN is {0} and value of SN is {1}", FN, SN); // 0.0
            OutPramaters(FN, SN, out sum, out prod);
            System.Console.WriteLine("Sum of FN and SN is {0} and product is {1}", sum, prod); // 0.0
            // variable number of parameters
            var sum1 = ParamsSum(2, 3, 4);
            var sum2 = ParamsSum(2, 3, 4, 3, 7);
            System.Console.WriteLine("Sum  is {0} and  {1}", sum1, sum2); // 0.0
        }
        // PASS by VALUE:
        public static void PassByValue(int FN, int SN)
        {
            FN += 34;
            SN += 27;
            System.Console.WriteLine("In method value of FN is {0} and value of SN is {1}", FN, SN); //34,27
        }
        // PASS by REFERENCE:
        public static void PassByRef(ref int FN, ref int SN)
        {
            FN += 34;
            SN += 27;
            System.Console.WriteLine("In method value of FN is {0} and value of SN is {1}", FN, SN); //34,27
        }

        // Params indeifinite
        public static int ParamsSum(params int[] x)
        {
            int total = 0;
            foreach (var t in x)
            {
                total = total + t;
            }
            return total;
        }

        // Return Multiple return from a function
        public static void OutPramaters(int FN, int SN, out int sum, out int product)
        {
            sum = FN + SN;
            product = FN * SN;
        }
    }
}
