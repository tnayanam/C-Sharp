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
// Namespace helps us to manage our code also they help us in avoiding name conflict (e.g: Display());'

// If you create a new project then you need to create is a class library. Because it will not be used standalone it will
// be more like a helper, also it will be built as a DLL NOT an EXE
// where as main project will have an EXE. 
// Also just creating a project does not help, one also needs to add reference of those dll's in the amin project. so clikc on main project and add references for those dll's
// also using statement will be required to actually use functionality of oter project in main project.