
using System;
using System.Collections.Generic;

public class Mains
{
    public static void Main()
    {
        Calculator.Add(3, 4); //old clients using this one.
    }
}

public class Calculator
{
    // old method
    [Obsolete("Please use a method int Add(List<int> Numbers)")] // after adding this green squiggly and warning will home. 
    public static int Add(int FN, int SN)
    {
        return FN + SN;
    }

    public static int Add(List<int> Numbers)
    {
        int Sum = 0;
        foreach (var num in Numbers)
        {
            Sum += num;
        }
        return Sum;
    }
}

/*
 * Attributes allow us to add declarative information to your programs. this information can be then queried at runtime using reflection
 * Example of atribute [Obsolete], [Serializable]
 * 
 * For this example suppose we have  a  clauclator  class and we have a siomple method to  add two number, and then someone asked for a method of  adding 3  numbers
 and then someone  asked for method  of  adding 4 numbers. Now we cannot keep on adding thses methods in our caluclator class so we decided to crate an  add method
 which can take a list of intetger and SUM them. But th problem is our new calculator clients wont know about this function. Also we cannot remvoe the olde Add methods 
 because it will break all the cleints who have coded for this method.  So we need to communicate the cients that we  have a improvedf add method without breaking theri coide.
 so as soon as some one hovers they will  see that new method is there now. Also in compile time it will throw  warning so that they get notified and alrmedf
 */
