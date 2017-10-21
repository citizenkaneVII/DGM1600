//While Loops

using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour
{
    int cupsInTheSink = 4;
    
    
    void Start ()
    {
        while(cupsInTheSink > 0)
        {
            Debug.Log ("I've washed a cup!");
            cupsInTheSink--;
        }
    }
}

/*The idea of the while loop is to run a method while the conditions are still being met to keep the loop going, in
otherwards, a true statement.  The while loop is interesting in that if an correct exit condition (a point at which
the statement condition becomes false) is not provided, it will continue to run as an infinite loop.  An infinite
loop will use up all the memory and crash Unity, and possibly the computer.  If an exit condition is in place, then 
the method will run till the condition is met. */

//The syntax of the While loop is:

while(condition)
{
   statement(s);
}

//Here are some examples of while loop code blocks.

 // Continue in while-loop until index is equal to 10.
        int i = 0;
        while (i < 10)
        {
            Console.Write("While statement ");
            // Write the index to the screen.
            Console.WriteLine(i);
            // Increment the variable.
            i++;
        }

