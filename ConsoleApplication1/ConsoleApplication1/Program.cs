namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            System.Console.WriteLine(Comparer.IsEqual("ABC", "ABC"));
        }
    }

    public class Comparer
    {
        public static bool IsEqual<T>(T FN, T SN)
        {
            return FN.Equals(SN);
        }
    }
}

/*
 * Generics allow us to design classes and methods decoupled from the data types
 * 
 * we can always use object instead of <T> because every class is derived from boject.
 * but Performance degradation happens due to boxing and unboxing. if ewwe pass integet
 * then that integer is a value type and it needs to egt converted to a object ttype
 * 
 *     public class Comparer
    {
        public static bool IsEqual(object FN, object SN)
        {
            return FN.Equals(SN);
        }
    }
 * 
 */
