using System;

namespace Kattis_Tests.Problems
{
    public class MirrorImages
    {
        public static void MirrorMain()
        {
            string input;
            int cases;
            int rows;
            int cols;

            while ((input = Console.ReadLine()) != null)
            {
                cases = Int32.Parse(input);

                for (int i = 0; i < cases; i++)
                {
                    input = Console.ReadLine();

                    string[] img = input.Split(" ");

                    rows = Int32.Parse(img[0]);
                    cols = Int32.Parse(img[1]);

                    string[] reverseImg = new string[rows];

                    for (int k = 0; k < rows; k++)
                    {
                        input = Console.ReadLine();
                        string reverseStr = string.Empty;

                        for (int j = cols - 1; j >= 0; j--)
                        {
                            reverseStr += input[j];
                        }

                        reverseImg[k] = reverseStr;
                    }

                    Array.Reverse(reverseImg);

                    Console.WriteLine($"Test {i+1}");
                    foreach (var item in reverseImg)
                    {
                        Console.WriteLine(item);
                    }

                }
            }
        }
    }
}
