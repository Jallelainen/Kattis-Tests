using System;

namespace Kattis_Tests
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("1 = Shorten Apaxian Name");
            Console.WriteLine("2 = Simplify Busline List");
            Console.WriteLine("3 = Get Amount of unique Anagrams");
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
