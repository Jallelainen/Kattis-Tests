using System;
using System.Numerics;
using System.Collections.Generic;

namespace Kattis_Tests
{
    class UniqueAnagrams
    {
        public static void AnagramsMain()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Anagram Calculator. Please enter a word:");
            string input;

            while ((input = Console.ReadLine()) != null)
            {
                char[] sortInput = input.ToCharArray();
                Array.Sort(sortInput);
                BigInteger possibleAnagrams = new BigInteger(0);
                List<int> repeatedChars = CountDuplicates(sortInput, input);

                if (repeatedChars.Count == 0)
                {
                    possibleAnagrams = GetFactorial(input.Length);
                }
                else
                {
                    possibleAnagrams = MultinominalCoefficient(input, repeatedChars);
                }

                Console.WriteLine("Total number of unique anagrams: " + possibleAnagrams);
                Console.WriteLine("Press any key to continue");
                Console.Read();
                Console.Clear();
                Console.WriteLine("Enter a word: ");
            }
        }

        public static BigInteger MultinominalCoefficient(string word, List<int> repeats)
        {
            BigInteger x = GetFactorial(word.Length);
            BigInteger y = 1;
            BigInteger anagrams;


            foreach (var num in repeats)
            {
                y *= GetFactorial(num);

            }

            anagrams = x / y;

            return anagrams;
        }

        public static List<int> CountDuplicates(char[] sortedInput, string input)
        {
            List<int> repeatedChars = new List<int>();
            bool isSingleChar = true;

            for (int i = 1; i < sortedInput.Length; i++)
            {
                if (sortedInput[i - 1] != sortedInput[i])
                {
                    isSingleChar = false;
                }
            }

            if (isSingleChar && sortedInput.Length > 0)
            {
                repeatedChars.Add(CountChar(input, sortedInput[0]));
                return repeatedChars;
            }
            else if (sortedInput.Length > 2)
            {
                if (sortedInput[0] == sortedInput[1])
                {
                    repeatedChars.Add(CountChar(input, sortedInput[0]));
                }
                for (int i = 1; i < sortedInput.Length; i++)
                {
                    if (sortedInput[i] != sortedInput[i - 1])
                    {
                        repeatedChars.Add(CountChar(input, sortedInput[i]));
                    }
                }
            }

            return repeatedChars;
        }

        public static int CountChar(string word, char x)
        {
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == x)
                {
                    count++;
                }
            }


            return count;
        }

        public static BigInteger GetFactorial(int length)
        {
            BigInteger fact = 1;

            for (int x = 1; x <= length; x++)
            {
                fact *= x;
            }


            return fact;
        }
    }
}
