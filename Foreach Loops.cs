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

//This is the syntax.

class ForEachSample
    {
        static void Main(string[] args)
        {
            int[] arrayList = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int num in arrayList )
            {
                System.Console.WriteLine(num);
            }
            System.Console.ReadLine();
        }

    }
//Here is an example of a Foreach loop.

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


static void Main(string[] args)
        {
            string[] arr = new string[5]; // declaring array
 
            //Storing value in array element
            arr[0] = "Steven";
            arr[1] = "Clark";
            arr[2] = "Mark";
            arr[3] = "Thompson";
            arr[4] = "John";
 
            //retrieving value using foreach loop
            foreach (string name in arr)
            {
                Console.WriteLine("Hello " + name);
            }
            Console.ReadLine();
        }



int[] myInterger = new int[1];
int total = 0;
foreach(int i in myInterger) 
{
    total += i;
}

      // Create an array of string type
      string[] names = {"Jim","Kate","Sam","Sally"};
      // Store length of names array in variable
      int arrayLength = names.Length;
      // Go through each name in names array and display on new line
      foreach (string name in names) {
        Console.WriteLine(name);
      }
      // Wait for user input before quitting program
      Console.ReadLine();
    }
  }

  string[] pets = { "dog", "cat", "bird" };

        // ... Loop with the foreach keyword.
        foreach (string value in pets)
        {
            Console.WriteLine(value);
        }


        


