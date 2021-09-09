// C# program to find n terms of
// series from given two numbers
using System;

class GFG
{

    // Function to find n terms
    // of series
    static void findSeries(int num,
                int first)
    {

        Console.Write(first + " ");
        int counter = 0, sum;

        // find next (num - 2) terms
        // of series as first two
        // terms are already given
        while (counter < num - 2)
        {
            sum = first;
            Console.Write(sum + " ");
            num = first ;
            counter++;
        }
    }

    // Drivers code
    public static void Main()
    {
        int n = 0, first = 1;

        findSeries(n, first);
    }
}