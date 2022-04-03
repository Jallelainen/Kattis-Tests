using System;

namespace Kattis_Tests
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("---- WELCOME TO THE KATTIS SOLUTION PROGRAM ----");
            Console.WriteLine();
            Console.WriteLine("1 = The Apaxian Civilization");
            Console.WriteLine("2 = The Bus line List Formater");
            Console.WriteLine("3 = The Anagram Calculator");
            Console.WriteLine("");
            Console.WriteLine("Please select your choice by entering a number:");

            int.TryParse(Console.ReadLine(), out int input);

            switch (input)
            {
                case 1:
                    Apaxians.ShortenApaxianName();
                    break;
                case 2:
                    BusLines.CalculateBusLines();
                    break;
                case 3:
                    UniqueAnagrams.GetUniqueAnagrams();
                    break;
                default:
                    break;
            }
        }
    }
}
