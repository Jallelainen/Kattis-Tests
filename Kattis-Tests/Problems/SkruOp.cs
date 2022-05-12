using System;
namespace Kattis_Tests.Problems
{
    public class SkruOp
    {
        public static void ChangeVolume()
        {
            Console.Clear();

            int volumeIndex = 7;
            string input;

            while ((input = Console.ReadLine()) != "")
            {
                if (input == "Skru op!")
                {
                    if (volumeIndex != 10)
                    {
                        volumeIndex++;
                    }
                }
                else if (input == "Skru ned!")
                {
                    if (volumeIndex != 0)
                    {
                        volumeIndex--;
                    }
                }
            }

            Console.WriteLine(volumeIndex);
        }
    }
}
