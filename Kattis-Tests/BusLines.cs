using System;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Kattis_Tests
{
    class BusLines
    {
        public static void CalculateBusLines()
        {

            //Save input in variables
            int.TryParse(Console.ReadLine(), out int busLines);
            string numbersStr = Console.ReadLine();

            //Handle inputs
            string[] busLineNumbersStr = OrderArray(numbersStr, busLines);

            if (busLines > 2)
            {
                busLineNumbersStr = SortArray(busLineNumbersStr);
            }

            StringBuilder result = ConvertToString(busLineNumbersStr);

            //output
            Console.WriteLine(result);

        }


        /// <summary>
        ///    Takes in an array of strings and outputs a stringbuilder object of that array
        /// </summary>
        /// <param name="busLineNumbersStr"> string array containing results </param>
        /// <returns> StringBuilder object with the full result </returns>
        public static StringBuilder ConvertToString(string[] busLineNumbersStr)
        {
            StringBuilder result = new StringBuilder();
            
            for (int i = 0; i < busLineNumbersStr.Length; i++)
            {

                if (i != busLineNumbersStr.Length - 1)
                {
                    if (busLineNumbersStr[i + 1] == "-")
                    {
                        result.Append(busLineNumbersStr[i]);
                    }
                    else if (busLineNumbersStr[i] == "-")
                    {
                        result.Append(busLineNumbersStr[i]);
                    }
                    else
                    {
                        result.Append(busLineNumbersStr[i] + " ");
                    }
                }
                else
                {
                    result.Append(busLineNumbersStr[i]);
                }
            }

            return result;

        }

        /// <summary>
        ///     Takes in an unordered string array. Then loops trough it and parse each string index leaving an int array.
        ///     After which it loops through again and turns it back into a string array.
        /// </summary>
        /// <param name="numbersStr"> array of strings containing bus line numbers </param>
        /// <param name="busLines"> int number that states the amount of bus lines </param>
        /// <returns> a string array with numbers ordered in ascending order </returns>
        public static string[] OrderArray(string numbersStr, int busLines)
        {
            string[] unsortedArr = numbersStr.Split(" ");
            string[] sortedArr = new string[busLines];
            int[] busLineNumbers = new int[busLines];

            for (int i = 0; i < busLines; i++)
            {
                int parsedNum;
                int.TryParse(unsortedArr[i], out parsedNum);
                busLineNumbers[i] += parsedNum;
            }

            Array.Sort(busLineNumbers);

            for (int i = 0; i < busLines; i++)
            {
                sortedArr[i] += busLineNumbers[i].ToString();
            }

            return sortedArr;
        }

        /// <summary>
        ///     Takes in an ordered array of string numbers, then loops trough it to sort out concsecutive numbers.
        ///     Where there are more than 3 numbers in a row, it replaces everything with a '-', except the first and last number.
        /// </summary>
        /// <param name="busLineNumbersStr"> a string array with ordered numbers of bus lines </param>
        /// <returns> a sorted array where unneccesary numbers have been sorted out </returns>
        public static string[] SortArray(string[] busLineNumbersStr)
        {

            for (int i = 2; i < busLineNumbersStr.Length; i++)
            {
                bool num3Bool = int.TryParse(busLineNumbersStr[i], out int num3);
                bool num2Bool = int.TryParse(busLineNumbersStr[i - 1], out int num2);
                bool num1Bool = int.TryParse(busLineNumbersStr[i - 2], out int num1);

                if (num1Bool && num2Bool && num3Bool)
                {
                    if (num1 == num2 - 1 && num3 == num2 + 1)
                    {
                        busLineNumbersStr[i - 1] = "-";
                    }
                    
                }
                else if (!num1Bool && num2Bool && num3Bool)
                {
                    if (num2 == num3 - 1)
                    {
                        busLineNumbersStr = busLineNumbersStr.Where(var => var != busLineNumbersStr[i - 1]).ToArray(); //remove index
                        i--; //prevents iteration skip when index is removed
                    }
                }
                 
            }

            return busLineNumbersStr;
        }
    
    }
}

