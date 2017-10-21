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