using System;
using System.Collections.Generic;

namespace Kattis_Tests
{
    public class SpeedLimit
    {
        public static void GetDistance()
        {
            Console.Clear();
            Console.WriteLine("Wlcome to the Distance Calculator. ");
            string input;

            while ((input = Console.ReadLine()) != "-1")
            {
                Int32.TryParse(input, out int sets);
                List<string> speeds = new List<string>();
                List<string> hours = new List<string>();
                int distance;

                for (int i = 0; i < sets; i++)
                {
                    string dataSet = Console.ReadLine();
                    string[] numbers = dataSet.Split(' ');

                    speeds.Add(numbers[0]);
                    hours.Add(numbers[1]);
                }

                distance = Int32.Parse(hours[0]) * Int32.Parse(speeds[0]);

                for (int i = 1; i < sets; i++)
                {
                    distance += (Int32.Parse(hours[i]) - Int32.Parse(hours[i - 1])) * Int32.Parse(speeds[i]); 
                }

                Console.WriteLine(distance + " miles");
            }
        }
    }
}
