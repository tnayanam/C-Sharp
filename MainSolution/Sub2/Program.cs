namespace Sub2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (MethodThrowingException(2, 0))
                {
                    // expression 1
                    // expression 2
                }
                else
                {
                    // handle exception here
                }
            }
            catch (System.Exception)
            {

                // now this will come into picture
                // expression 1 and expression 2 will not execute
            }

        }

        public static bool MethodThrowingException(int num, int div)
        {
            bool ret = false;
            try
            {
                int res = num / div;
                // exp 1 some other expression
                ret = true; // this will not execute
            }
            catch (System.Exception)
            {
                // some exception occured write it to database
                // exp 1 will not execute
                return ret;
            }
            return ret;

            // do some operation in db
        }
    }

}

// delimeter is the space. so outputis Hello and then World
// If you want values directly to this file stand alone select this exe then right clik on this project and go to debugger section and add the parameter with space separatd

