namespace Sub2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MethodThrowingException(2, 0);
                // expression 1
                // expression 2
            }
            catch (System.Exception)
            {

                // now handle the exception again here if you want to
                // but now expression 1 and expression 2 will not execute during exception
            }

        }

        public static void MethodThrowingException(int num, int div)
        {
            try
            {
                int res = num / div;
                // exp 1 some other expression
            }
            catch (System.Exception)
            {
                // some exception occured write it to database
                // exp 1 will not execute
                throw;
            }

            // do some operation in db
        }
    }

}

// delimeter is the space. so outputis Hello and then World
// If you want values directly to this file stand alone select this exe then right clik on this project and go to debugger section and add the parameter with space separatd

