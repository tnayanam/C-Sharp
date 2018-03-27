namespace ConsoleApplication1
{
    interface ICustomer
    {
        void Print(); // you cannot give implementation in interface // you cannot give access modifier. they are alwasy public
    }

    public class Test : ICustomer
    {
        public void Print()
        {
            System.Console.WriteLine("Hello");
        }
    }
    class Program : ICustomer
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.Print();
            ICustomer cust = new Test();
            ICustomer cust = new ICustomer(); // NOT POSSIBLE (**)
            cust.Print();
        }
        public void Print()
        {
        }// class imnplemeting the interface has to implement all the methods of it 
    }
}
/*
 * Interfaces contains only declaration no implementations
 * interface members are public by default
 * interfaces cannot contain fields
 * if a class inherits from an interface it must provide implementation for all interface members
 * a class can inherit from more than one interface but a class cannot inherit from more than one class
 * We cannot create an instance of an interface, but an instance referenec variable can point to an instance of derived class object. (**)
 */
