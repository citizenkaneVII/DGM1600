/*But if a is not equel to 10, 20 or 30, that means none of the conditions are true, and as a result, the last option, the else condtion will
perform it's associated function, printing "None of the values is matching". */


using System;
namespace DecisionMaking
{
   class Program 
   {
      static void Main(string[] args)
      {
         /* local variable definition */
         int a = 100;
         
         /* check the boolean condition */
         if (a == 10)
         {
            /* if condition is true then print the following */
            Console.WriteLine("Value of a is 10");
         }
         
         else if (a == 20)
         {
            /* if else if condition is true */
            Console.WriteLine("Value of a is 20");
         }
         
         else if (a == 30)
         {
            /* if else if condition is true  */
            Console.WriteLine("Value of a is 30");
         }
         
         else
         {
            /* if none of the conditions is true */
            Console.WriteLine("None of the values is matching");
         }
         Console.WriteLine("Exact value of a is: {0}", a);
         Console.ReadLine();
      }
   }
}