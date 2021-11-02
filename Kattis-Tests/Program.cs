using System;
using System.Linq;

namespace Kattis_Tests
{
    class Program
    {
        public static void Main()
        {
            // Int bus length
            int busLinesLength;
            busLinesLength = 15;
            
            // The bus lines
            int[] busLines = new int[]  { 22, 23, 24, 25, 50, 60, 40, 256, 232, 1, 3, 5, 7, 9, 65 };
            
            // Sorting bus numbers from smallest to biggest
            Array.Sort(busLines);

            // New array based on busLinesLength
            int[] arr = new int[busLinesLength];

            // Defined array index 
            int i = 0;

            // Array 2 = busLine 0 at beginning
            arr[i++] = busLines[0];

            //Looping through all the bus line numbers
            for(int j = 1; j < busLinesLength; j++) 
                {
                // Validates if the bus line number before is current busLine - 1
                if (busLines[j] == busLines[j - 1] + 1)
                {
                    // Jumps 1 in the index, doesn't print anything since you want to build a summarized object
                    arr[i++] = busLines[j];
                }
                else 
                {
                    // Printing the numbers is its nog going to build a composite object 
                    print(arr, i);
                    // Reset array index
                    i = 0;
                    // Jumps 1 indec again 
                    arr[i++] = busLines[j];
                }
                // Checks if it should print the last bus number or if its composite
                if (j == busLinesLength - 1)
                {
                    print(arr, i);
                }
                }
            }
        
            static void print(int[] arr, int i)
            {
                // If i > 2 its a contraction of bus numbers
                if (i > 2)
                {
                    Console.WriteLine(arr[0] + "-" + arr[i - 1] + " ");
                }
                // Normal just printing out bus numbers
                else 
                {
                    Console.WriteLine(arr[0] + " ");
                }
            }
        }
}

