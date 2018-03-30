// IMPORTANT EXAMPLE 1 ENUM

//using System;
//public class Enums
//{
//    public static void Main()
//    {
//        int[] Values = (int[])Enum.GetValues(typeof(Gender));
//        Console.WriteLine("Gender Enum Values");
//        foreach (int value in Values)
//        {
//            Console.WriteLine(value);
//        }

//        Console.WriteLine();
//        string[] Names = Enum.GetNames(typeof(Gender));
//        Console.WriteLine("Gender Enum Names");
//        foreach (string Name in Names)
//        {
//            Console.WriteLine(Name);
//        }
//    }
//}
//public enum Gender : int
//{
//    Unknown = 1,
//    Male = 2,
//    Female = 3
//}

// IMPORTANT EXAMPLE 2 ENUM

public class Enums
{
    public static void Main()
    {
        // This line will not compile. Cannot implicitly convert type 'Season' to 'Gender'. 
        // An explicit conversion is required.
        // Gender gender = Season.Winter;


        // This line comiples as we have an explicit cast
        Gender gender = (Gender)Season.Winter;
    }
}
public enum Gender : int
{
    Unknown = 1,
    Male = 2,
    Female = 3
}
public enum Season : int
{
    Winter = 1,
    Spring = 2,
    Summer = 3
}