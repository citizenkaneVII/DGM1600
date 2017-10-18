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


/*Loops are bools in the sense that they return a value of true or false.  As long as the method continues to return
the value of true, the loop will continue to run.  When the value returned is false, the loop ends. */

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Value of i: {0}", i);
}