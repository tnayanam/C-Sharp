namespace ConsoleApplication1
{
    // how to utlize functionaity of multiple classes when multiple class inhetiance is not allowed
    interface IA
    {
        void PrintA();
    }

    interface IB
    {
        void PrintB();
    }

    class A : IA
    {
        public void PrintA()
        {
            System.Console.WriteLine("I am in A class");
        }
    }

    class B : IB
    {
        public void PrintB()
        {
            System.Console.WriteLine("I am in B class");
        }
    }

    class C : IA, IB
    {
        B b = new B();
        A a = new A();
        public void PrintA()
        {
            a.PrintA();
        }

        public void PrintB()
        {
            b.PrintB();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            c.PrintA();
            c.PrintB();
        }
    }
}


