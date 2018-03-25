namespace ConsoleApplication1
{


    // Simple Class Example
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(2);
            System.Console.WriteLine("Area = {0}", c1.Area());
            Circle c2 = new Circle(4);
            System.Console.WriteLine("Area = {0}", c2.Area());
        }
    }
    //Problem with below code is Pi is static and if we dont declare it static every instasnce of class will create a memory space for it. 
    // so lets make it static.
    //class Circle
    //{
    //    float _PI = 3.14F;
    //    int _radius;
    //    public Circle(int Radious)
    //    {
    //        _radius = Radious;
    //    }
    //    public float Area()
    //    {
    //        return _PI * _radius * _radius;
    //    }
    //}
    // now declared static
    //class Circle
    //{
    //    static float _PI = 3.14F;
    //    int _radius;
    //    public Circle(int Radious)
    //    {
    //        _radius = Radious;
    //    }
    //    public float Area()
    //    {
    //        return _PI * _radius * _radius;
    //    }
    //}

    // now lets assign value to static parameter via static constructor
    class Circle
    {
        static float _PI;
        int _radius;
        static Circle()
        {
            _PI = 3.14F;
        }
        public Circle(int Radious)
        {
            _radius = Radious;
        }
        public float Area()
        {
            return _PI * _radius * _radius;
        }
    }
}

