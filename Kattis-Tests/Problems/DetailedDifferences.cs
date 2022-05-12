using System;
using System.Text;

namespace Kattis_Tests.Problems
{
    public class DetailedDifferences
    {
        public static void DetailedMain()
        {
            string input;
            int cases;
            string str1;
            string str2;
            StringBuilder visualisation = new StringBuilder();

            while ((input = Console.ReadLine()) != null)
            {
                cases = Int32.Parse(input);

                for (int i = 0; i < cases; i++)
                {
                    str1 = Console.ReadLine();
                    str2 = Console.ReadLine();

                    for (int k = 0; k < str1.Length; k++)
                    {
                        if (str1[k] == str2[k])
                        {
                            visualisation.Append('.');
                        }
                        else
                        {
                            visualisation.Append('*');
                        }
                    }

                    Console.WriteLine(str1);
                    Console.WriteLine(str2);
                    Console.WriteLine(visualisation);
                    Console.WriteLine("");
                }
            }
        }
    }
}
