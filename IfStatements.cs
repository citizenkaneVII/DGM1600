using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* In the following example provided by Unity3d.com, we are given conditions.  If a condition is met, then an action will be performed.
 */

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    

    void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();
        
        coffeeTemperature -= Time.deltaTime * 5f;
    }
    
    
/* 
In this coffee example, the program needs to perform an function based on the tempeture of the coffee.  If the coffee is too hot,
then the program, based on our instructions, will write out the line, the "Coffee is too hot." in the console.  Why?  Because that's
what we told it to do.*/

    void TemperatureTest ()
    {
        // If the coffee's temperature is greater than the hottest drinking temperature...
        if(coffeeTemperature > hotLimitTemperature)
        {
            // ... do this.
            print("Coffee is too hot.");
        }
        // If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if(coffeeTemperature < coldLimitTemperature)
        {
            // ... do this.
            print("Coffee is too cold.");
        }
        // If it is neither of those then...
        else
        {
            // ... do this.
            print("Coffee is just right.");
        }
    }
}