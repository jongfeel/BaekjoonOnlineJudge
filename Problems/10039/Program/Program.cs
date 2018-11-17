using System;
using System.Linq;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            for (int i = 0; i < 5; i++)
            {
                string s1 = Console.ReadLine();
                scores[i] = int.Parse(s1);
            }
            
            Console.WriteLine((int)GetSupplementaryAverage(scores));
        }

        public static double GetSupplementaryAverage(int[] scores)
        {
            return scores.Select(score => score < 40 ? 40 : score).Average();
        }
    }
}