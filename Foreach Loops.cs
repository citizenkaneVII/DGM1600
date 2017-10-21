//Foreach Loops

using UnityEngine;
using System.Collections;

public class ForeachLoop : MonoBehaviour 
{   
    void Start () 
    {
        string[] strings = new string[3];
        
        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";
        
        foreach(string item in strings)
        {
            print (item);
        }
    }
}



/*Loops are a way of repeating a method.  In for loops, we wrote a condition that had to be met in order for the loop
to stop.  In Foreach loops, the method is ran for every element in a collection, such as an array. */


int[] fibarray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
foreach (int element in fibarray)
{
    System.Console.WriteLine(element);
}
System.Console.WriteLine();
// Output:
// 0
// 1
// 1
// 2
// 3
// 5
// 8
// 13

/*In the example above, we are given an array called fibarray.  It has a lot of integers, o, 1, 13, ect.
The foreach command means that a loop will be run for the condition made, in this case, every element that is
listed in the array.*/


foreach (int element in fibarray)
{
    System.Console.WriteLine(element);
}

/*The un-coded equivelent would be to say "For each element that is an integer in this library (called 'fibarray'),
write one of those elements in the console.  The output will be: */
// 0
// 1
// 1
// 2
// 3
// 5
// 8
// 13

//After all the elements are printed to the console, the loop ends.

//Here are some other examples:

