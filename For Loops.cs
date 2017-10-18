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
