namespace ConsoleApplication1
{
    abstract class Customer
    {
        public abstract int Print(); // it cannot have the implementaton
        public void Tan()
        {

        }
    }

    // an abstract class is incomplete so cannot be instantiated.
    // an abstract class cannot be selaed because an abstract class is meant to over public
    // AN ABSTRACT CLASS MAy or may not contain abstract members
    // a non abstract class deriving from abstract class must implement al the methods of abstract class.
    class Program : Customer
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();

             
        }

        public override int Print()
        {
            System.Console.WriteLine("I am in non abstract class");
            return 0;
        }
    }
}
