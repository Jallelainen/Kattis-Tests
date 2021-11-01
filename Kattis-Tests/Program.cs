using System;
using System.Linq;

namespace Kattis_Tests
{
    class Program
    {
        public static void Main()
        {
            string busLinesStr = Console.ReadLine();
            int.TryParse(busLinesStr, out int busLines);
            string numbersStr = Console.ReadLine();
            string[] busLineNumbersStr = numbersStr.Split(" ");
            int removedChars = 3;

            Array.Sort(busLineNumbersStr);

            for (int i = 0; i < busLines - removedChars; i++)
            {
                bool num1Bool = int.TryParse(busLineNumbersStr[i], out int num1);
                bool num2Bool = int.TryParse(busLineNumbersStr[i + 1], out int num2);
                bool num3Bool = int.TryParse(busLineNumbersStr[i + 2], out int num3);

                if (num1Bool && num2Bool && num3Bool)
                {
                    if (num1 + 1 == num2 && num1 + 2 == num3)
                    {
                        busLineNumbersStr[i + 1] = "-";
                    }
                    else if (num1 + 1 == num2 && busLineNumbersStr[i - 1] == "-")
                    {
                        busLineNumbersStr = busLineNumbersStr.Where(var => var != busLineNumbersStr[i]).ToArray();
                        removedChars++;
                    }
                    
                }else if (!num1Bool)
                {
                    if (busLineNumbersStr[i] == "-" && num2 + 1 == num3)
                    {
                        busLineNumbersStr = busLineNumbersStr.Where(var => var != busLineNumbersStr[i + 1]).ToArray();
                        removedChars++;
                    }
                }
            }

            for (int i = 0; i < busLineNumbersStr.Length; i++)
            {
                if (i != busLineNumbersStr.Length - 1)
                {
                    if (busLineNumbersStr[i + 1] == "-")
                    {
                        Console.Write($"{busLineNumbersStr[i]}");
                    }
                    else if (busLineNumbersStr[i] == "-")
                    {
                        Console.Write($"{busLineNumbersStr[i]}");
                    }
                    else
                    {
                        Console.Write($"{busLineNumbersStr[i]} ");
                    }
                }
                else
                {
                    Console.Write($"{busLineNumbersStr[i]} ");
                }
            }
            Console.ReadKey();
        }
    }
}

