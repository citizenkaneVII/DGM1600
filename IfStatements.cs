/*Further examples.*/


using System;

namespace CodeStudies
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesOfCodeWritten = 75;

            if (linesOfCodeWritten <= 25)
            {
                Console.WriteLine("Not too bad; less code can certainly be more.");
            }
            else
            {
                Console.WriteLine("You added more than 25 lines of code to the project.");

                if (linesOfCodeWritten > 500)
                {
                    Console.WriteLine("Working hard on some kind of new feature?");
                }
            }
        }
    }
}