using System;
using System.Linq;

namespace Kattis_Tests.Problems
{
    public class AboveAverage
    {
        public static void AverageMain()
        {
            string input;

            while ((input = Console.ReadLine()) != null)
            {
                Int32.TryParse(input, out int cases);

                for (int i = 0; i < cases; i++)
                {
                    string[] classInput = Console.ReadLine().Split(" ");

                    Int32.TryParse(classInput[0], out int students);

                    int[] scores = new int[students];

                    for (int k = 1; k <= students; k++)
                    {
                        scores[k - 1] = Int32.Parse(classInput[k]); 
                    }

                    double avg = Queryable.Average(scores.AsQueryable());

                    int studentsAbove = 0;
                    
                    foreach (var item in scores)
                    {
                        if (item > avg)
                        {
                            studentsAbove++;
                        }
                    }

                    avg = (100.0 / students) * studentsAbove;


                    Console.WriteLine(avg.ToString("0.000") + "%");
                }
            }
        }
    }
}
