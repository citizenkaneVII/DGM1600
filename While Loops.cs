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

while (true) // Executes forever
{
    Console.WriteLine("Never Stop!");
}


while (false) // Never executes
{
    Console.WriteLine("Never execute");
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



static void Main(string[] args)
      {
         /* local variable definition */
         int a = 10;

         /* while loop execution */
         while (a < 20)
         {
            Console.WriteLine("value of a: {0}", a);
            a++;
         }
         Console.ReadLine();
      }



static void Main(string[] args)
        {
            int num1, res, i;
 
            Console.WriteLine("Enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());
 
            i = 1; //Initialization
            //Check whether condition matches or not
            while (i <= 10)
            {
                res = num1 * i;
                Console.WriteLine("{0} x {1} = {2}", num1, i, res);
                i++; //Increment by one
            }
            Console.ReadLine();
        }



public static void Main(string[] args)
		{
			int i=1;
			while (i<=5)
			{
				Console.WriteLine("C# For Loop: Iteration {0}", i);
				i++;
			}
		}



i = 0
while(i<4){
   Console.WriteLine(i);
   i++;
}



 static void Main(string[] args)
        {
            int number = 0;

            while(number < 5)
            {
                Console.WriteLine(number);
                number = number + 1;
            }

            Console.ReadLine();
        }



int myCount = 0;

while ( myCount < 100 )
{
      myCount++;
}



// Initialize the counter

int counter = 0;

// Execute the loop body while the loop condition holds

while (counter <= 9)

{

        // Print the counter value

        Console.WriteLine("Number : " + counter);

        // Increment the counter

        counter++;

}



bool iNeedMoreCandies = true;
int candiesCount = 0;
            
while (iNeedMoreCandies)
{
    Console.WriteLine("One more candy?");
    
    string answer = Console.ReadLine();
    if (answer == "Yes")
    {
        candiesCount++;
    }
    else
    {
        iNeedMoreCandies = false;
    }
}



int repetitions = 10;
while(repetitions > 0)
{
    Console.WriteLine("Print me!");
    repetitions--;
}
