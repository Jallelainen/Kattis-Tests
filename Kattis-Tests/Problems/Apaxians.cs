using System;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Kattis_Tests
{
    class Apaxians
    {
        public static void ApaxiansMain()
        {
            string input = Console.ReadLine();
            Console.WriteLine(RemoveRepeats(input));
        }

        public static string RemoveRepeats(string input)
        {
            string newString = input[0].ToString();

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    newString = string.Concat(newString, input[i].ToString());
                }

            }

            return newString;
        }
    }
}