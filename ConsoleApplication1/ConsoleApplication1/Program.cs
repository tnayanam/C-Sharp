namespace ConsoleApplication1
{
    // problem with multiple inheritance
    class A
    {
        public virtual void Print()
        {

        }
    }

    class B : A
    {
        public override void Print()
        {
            //base.Print();
        }
    }

    class C : A
    {
        public override void Print()
        {
            //base.Print();
        }
    }

    class D : C, B // compiler merror but suppose if this was allowed and we create a instance of C and call the "POrint method" then which implementation of print method
                   //should be calledf. B's implementation or C's implementation// this is called DIAMOND PROBLEM
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}


