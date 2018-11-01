using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            int c = int.Parse(s1);
            List<List<int>> scoresList = new List<List<int>>(c);

            for (int i = 0; i < c; i++)
            {
                string s2 = Console.ReadLine();
                string [] s22 = s2.Split();
                int count = int.Parse(s22[0]);
                List<int> scores = new List<int>(s22.Length-1);
                for (int j = 1; j <= count; j++)
                {
                    scores.Add(int.Parse(s22[j]));
                }
                scoresList.Add(scores);
            }

            foreach (var scores in scoresList)
            {
                double result = GetAverageRatio(scores);
                Console.WriteLine(Math.Round(result, 3).ToString("F3")+"%");
            }
        }

        public static double GetAverageRatio(List<int> scores)
        {
            double avg = scores.Average();
            int countOverAvg = scores.Where(score => score > avg).Count();
            return countOverAvg / (double)scores.Count * 100;
        }
    }
}
