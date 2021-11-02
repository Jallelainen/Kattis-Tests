using System;
using System.Linq;
using System.Text;

namespace Kattis_Tests
{
    class Program
    {
        public static void Main()
        {
            int.TryParse(Console.ReadLine(), out int busLines);
            string numbersStr = Console.ReadLine();

            string[] busLineNumbersStr = OrderArray(numbersStr, busLines);
            busLineNumbersStr = SortArray(busLineNumbersStr);
            StringBuilder result = ConvertToString(busLineNumbersStr);
            
            Console.WriteLine(result);
        }

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

        public static string[] SortArray(string[] busLineNumbersStr)
        {
            for (int i = 0; i < busLineNumbersStr.Length; i++)
            {
                if (i < busLineNumbersStr.Length - 2)
                {
                    bool num1Bool = int.TryParse(busLineNumbersStr[i], out int num1); //prev: - ; i =178
                    bool num2Bool = int.TryParse(busLineNumbersStr[i + 1], out int num2);// 179
                    bool num3Bool = int.TryParse(busLineNumbersStr[i + 2], out int num3);//180

                    if (num1Bool && num2Bool && num3Bool)
                    {
                        if (i != 0)
                        {
                            if (num1 + 1 == num2 && num1 + 2 == num3 && busLineNumbersStr[i - 1] != "-")
                            {
                                busLineNumbersStr[i + 1] = "-";
                            }
                            else if (num1 + 1 == num2 && num1 + 2 == num3 && busLineNumbersStr[i - 1] == "-")
                            {
                                busLineNumbersStr = busLineNumbersStr.Where(var => var != busLineNumbersStr[i]).ToArray();
                                i--;
                            }
                        }
                        else
                        {
                            if (num1 + 1 == num2 && num1 + 2 == num3)
                            {
                                busLineNumbersStr[i + 1] = "-";
                            }
                        }

                    }
                    else if (!num1Bool && num2Bool && num3Bool)
                    {
                        if (busLineNumbersStr[i] == "-" && num2 + 1 == num3)
                        {
                            busLineNumbersStr = busLineNumbersStr.Where(var => var != busLineNumbersStr[i + 1]).ToArray();
                            i--;
                        }
                    }
                }
                else if (i < busLineNumbersStr.Length - 1)
                {
                    int.TryParse(busLineNumbersStr[i], out int num1);
                    int.TryParse(busLineNumbersStr[i + 1], out int num2);

                    if (num1 + 1 == num2)
                    {
                        busLineNumbersStr = busLineNumbersStr.Where(var => var != busLineNumbersStr[i]).ToArray();
                    }
                }
            }

            return busLineNumbersStr;
        }
    }
}

