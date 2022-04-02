using System;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Kattis_Tests
{
    class UniqueAnagrams
    {
        public static void GetUniqueAnagrams()
        {
            string input = Console.ReadLine();

            while (input != "")
            {
                input = Console.ReadLine();
                Console.WriteLine(GetFactorial(input.Length));
            }
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
