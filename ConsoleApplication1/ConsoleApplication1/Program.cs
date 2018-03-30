/*
 * Multicast Delegate
 * it is a delegate the references more than one function, when we invoke a multicast delegate all the delegate it points to gets invoked
 */

using System;
using System.Runtime.Serialization;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadyLoggedInException("User Already logged in");
            }
            catch (UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }


    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException(string message)
            : base(message)
        {
        }


        public UserAlreadyLoggedInException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
