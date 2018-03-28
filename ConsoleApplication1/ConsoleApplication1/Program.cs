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
    // an abstract class cannot be sealed
    // we cannot create instance of wither interface oir abstract cloass.
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

/*
 * difference between Abstract and Interface
 * we can have a method implementation in abstract but interface cant have method implementation.
 * interfaces cant haqve access modifiers as they are public by default'
 * and class members are preivate by default
 * interface cannot cobntain fields but absatract class can have fields
 * abstract class members can have access modifiers but interface cannot.
 * 
 */
