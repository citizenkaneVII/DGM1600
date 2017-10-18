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

  for (initializer; Boolean expression; modifier)
  [{]
    statement(s)
  [}]

/*Each for loop contains three parts.  Remember to declair a for loop by writting "for" first.  In the parenthases
afterwards, You need to intialize a variable, provide the conditions for the variable to satisfy, and provide the
steps the loop will take till the condition says they value is false. */

/*In this example,
    The variable initialization (or intializer) is i = 0
    The condition (or boolean expression) is i < 10
    The steps (also known as a modifier or a iterator) are/is i++

EACH OF THESE MUST HAVE A SEMI-COLON AFTER IT. 
    
The initialization naturally starts at zero unless defined otherwise.  The condition will then count up from zero
using the steps we've provided until i no longer is less then 10. */

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Value of i: {0}", i);
}


/*Loops are bools in the sense that they return a value of true or false.  As long as the method continues to return
the value of true, the loop will continue to run.  When the value returned is false, the loop ends. */

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Value of i: {0}", i);
}

/*In the example above, as long as the value of i is less then 10, the code will continue to run, from 0 to 9.
After 9, it will stop printing i because it will be equel to 10.  The method will then return a value of false
because i is no longer less then 10, but is equel to 10. */

/*A nested for loop is the same thing as a regular for loop, but instead, it resides in another for loop. */

using System;
 
class TriagnelNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int row = 1; row <= n; row++)
        {
            for (int column = 1; column <= row; column++)
            {
                Console.Write("{0} ", column);
            }
            Console.WriteLine();
        }
    }
}

/*When the first for loop runs, the second will also begin to run because it's part of the first for loops's method.
The second one will run till it returns a value of false, and that will return a value of false to the first for
loop. */

//These are further examples of for loops.


class ForLoopTest 
{
    static void Main() 
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }
    }
}
/*
Output:
1
2
3
4
5
*/


//Here's some alternate syntax:

static void Main()
 {
     int i;
     int j = 10;
     for (i = 0, Console.WriteLine("Start: {0}",i); i < j; i++, j--, Console.WriteLine("i={0}, j={1}", i, j))
     {
         // Body of the loop.
     }
 }
 // Output:
 // Start: 0
 // i=1, j=9
 // i=2, j=8
 // i=3, j=7
 // i=4, j=6
 // i=5, j=5



 using System;
namespace Loops
{
   class Program
   {
      static void Main(string[] args)
      {
         /* for loop execution */
         for (int a = 10; a < 20; a = a + 1)
         {
            Console.WriteLine("value of a: {0}", a);
         }
         Console.ReadLine();
      }
   }
} 

/*value of a: 10
value of a: 11
value of a: 12
value of a: 13
value of a: 14
value of a: 15
value of a: 16
value of a: 17
value of a: 18
value of a: 19
 */


using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}



using System;

class Program
{
    static void Main()
    {
        for (int i = 10 - 1; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 10; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        for (int i = 10 - 1; i >= 0; i -= 2)
        {
            Console.WriteLine(i);
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < (20 / 2); i += 2)
        {
            Console.WriteLine(i);
        }
    }
}



