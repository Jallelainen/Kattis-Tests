using System;
namespace Kattis_Tests.Problems
{
    public class EyeOfSauron
    {
        public static void SauronMain()
        {
            string input;
            int linesR = 0;
            int linesL = 0;
            bool isLeft = true;

            while ((input = Console.ReadLine()) != null)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == '|' && isLeft)
                    {
                        linesL++;
                    }
                    else if (input[i] == ')')
                    {
                        isLeft = false;
                    }
                    else if (input[i] == '|' && !isLeft)
                    {
                        linesR++;
                    }
                }

                if (linesR == linesL)
                {
                    Console.WriteLine("correct");
                }
                else
                {
                    Console.WriteLine("fix");
                }
            }
        }
    }
}
