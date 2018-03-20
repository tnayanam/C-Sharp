namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Value type and reference types:
             * int, struct, enums, bool are all value types: That means if we leave then empty they will have their default value.these are NON
             * Non NUllable types
              
             int t;
             if we print t it will have 0
             bool isavail;
             if we print it it will print false.

            Reference types are nullable types.
            string,classes.
            string abc;
            if we print abc it will have null value.

            Now how can we convert a non-nullable type to nullable type.
            int? age;
            now if you print age it will allow null values.
             */
            // NUll Coalsceing Operator
            int? totalTickets = null;
            int availableTickets;
            if (totalTickets == null)
            {
                availableTickets = 0;
            }
            else
            {
                availableTickets = totalTickets.Value;
            }
            // above if  else statement can be coverted like below:
            availableTickets = totalTickets ?? 0;


        }
    }
}
