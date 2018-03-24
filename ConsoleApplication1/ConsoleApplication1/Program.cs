using PATA = ProjectA;
using PATB = ProjectB;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectA.ClassA.Display(); // one way of calling
            ProjectB.ClassA.Display();
            PATA.ClassA.Display(); // Another way
            PATB.ClassA.Display();
        }
    }
}

namespace ProjectA
{
    class ClassA
    {
        public static void Display()
        {
            System.Console.WriteLine("I am from ProjectA.ClassA");
        }
    }
}


namespace ProjectB
{
    class ClassA
    {
        public static void Display()
        {
            System.Console.WriteLine("I am from ProjectB.ClassA");
        }
    }
}
// Namespace helps us to manage our code also they help us in avoiding name conflict (e.g: Display());