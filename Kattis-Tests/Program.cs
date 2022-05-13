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
            Console.WriteLine("4 = The Distance Calculator");
            Console.WriteLine("5 = Set Volume(Skru op!)");
            Console.WriteLine("6 = Is it the Eye of Souron?");
            Console.WriteLine("7 = Detailed Differences");
            Console.WriteLine("8 = Mirror Images");
            Console.WriteLine("");
            Console.WriteLine("Please select your choice by entering a number:");

            int.TryParse(Console.ReadLine(), out int input);

            switch (input)
            {
                case 1:
                    Apaxians.ApaxiansMain();
                    break;
                case 2:
                    BusLines.BusLinesMain();
                    break;
                case 3:
                    UniqueAnagrams.AnagramsMain();
                    break;
                case 4:
                    SpeedLimit.SpeedLimitMain();
                    break;
                case 5:
                    Problems.SkruOp.SkruOpMain();
                    break;
                case 6:
                    Problems.EyeOfSauron.SauronMain();
                    break;
                case 7:
                    Problems.DetailedDifferences.DetailedMain();
                    break;
                case 8:
                    Problems.MirrorImages.MirrorMain();
                    break;
                default:
                    break;
            }
        }
    }
}
