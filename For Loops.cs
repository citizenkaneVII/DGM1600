//For Loops

using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour
{
    int numEnemies = 3;
    
    
    void Start ()
    {
        for(int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }
}

/*Loops are methods that executes statments until a condition is met.*/

//Example:

for (variable initialization; condition; steps)
{
    //execute this code block as long as condition is satisfied 
}

/*Each for loop contains three parts.  Remember to declair a for loop by writting "for" first.  In the parenthases
afterwards, You need to intialize a variable, provide the conditions for the variable to satisfy, and provide the
steps the loop will take till the condition says they value is false. */


/*Loops are bools in the sense that they return a value of true or false.  As long as the method continues to return
the value of true, the loop will continue to run.  When the value returned is false, the loop ends. */

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Value of i: {0}", i);
}

/*In the example above, as long as the value of i is less then 10, the code will continue to run, from 0 to 9.
After 9, it will stop printing i because it will be equel to 10.  The method will then return a value of false
because i is no longer less then 10, but is equel to 10. */