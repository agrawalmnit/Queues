//using System;
//using System.Collections;
//public class CopyTo
//{

//    public static void Main()
//    {

//        // Creates and initializes the source Queue.
//        Queue mySourceQ = new Queue();
//        mySourceQ.Enqueue("three");
//        mySourceQ.Enqueue("napping");
//        mySourceQ.Enqueue("cats");
//        mySourceQ.Enqueue("in");
//        mySourceQ.Enqueue("the");
//        mySourceQ.Enqueue("barn");


//        // Creates and initializes the one-dimensional target Array.
//        Array myTargetArray = Array.CreateInstance(typeof(string), 15);
//        myTargetArray.SetValue("The", 0);
//        myTargetArray.SetValue("quick", 1);
//        myTargetArray.SetValue("brown", 2);
//        myTargetArray.SetValue("fox", 3);
//        myTargetArray.SetValue("jumps", 4);
//        myTargetArray.SetValue("over", 5);
//        myTargetArray.SetValue("the", 6);
//        myTargetArray.SetValue("lazy", 7);
//        myTargetArray.SetValue("dog", 8);


//        // Displays the values of the target Array.
//        Console.WriteLine("The target Array contains the following (before and after copying):");
//        PrintValues(myTargetArray, ' ');

//        // Copies the entire source Queue to the target Array, starting at index 6.
//        mySourceQ.CopyTo(myTargetArray, 6);

//        // Displays the values of the target Array.
//        PrintValues(myTargetArray, ' ');

//        // Copies the entire source Queue to a new standard array.
//        Object[] myStandardArray = mySourceQ.ToArray();

//        // Displays the values of the new standard array.
//        Console.WriteLine("The new standard array contains the following:");
//        PrintValues(myStandardArray, ' ');
//    }

//    public static void PrintValues(Array myArr, char mySeparator)
//    {
//        foreach (Object myObj in myArr)
//        {
//            Console.Write("{0}{1}", mySeparator, myObj);
//        }
//        Console.WriteLine();
//    }
//}


