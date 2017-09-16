/*Further examples.*/


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(A(5));
        Console.WriteLine(B(4));
    }

    static bool A(int y)
    {
        if (y >= 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static bool B(int y)
    {
        if (y >= 5)
        {
            return true;
        }
        return false;
    }
}