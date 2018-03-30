/*
 * Multicast Delegate
 * it is a delegate the references more than one function, when we invoke a multicast delegate all the delegate it points to gets invoked
 */

using System;
using System.Runtime.Serialization;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
                try
                {
                    Console.WriteLine("Please enter Numerator");
                    int Numerator = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Please enter Denominator");
                    //Convert.ToInt32() can throw FormatException, if the entered value
                    //cannot be converted to integer. So use int.TryParse() instead
                    int Denominator = Convert.ToInt32(Console.ReadLine());


                    int Result = Numerator / Denominator;


                    Console.WriteLine("Result = {0}", Result);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Only numbers are allowed!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Only numbers between {0} & {1} are allowed",
                        Int32.MinValue, Int32.MaxValue);


                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Denominator cannot be zero");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
