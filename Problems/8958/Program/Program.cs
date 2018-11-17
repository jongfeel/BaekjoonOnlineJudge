using System;
using System.Linq;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            int n  = int.Parse(s1);

            int[] scores = new int[n];
            for (int i = 0; i < n; i++)
            {
                string[] corrects = GetCorrectArray(Console.ReadLine());
                scores[i] = corrects.Select(correct => SumToN(correct.Length)).Sum();
            }

            foreach (int item in scores)
            {
                Console.WriteLine(item);
            }
        }

        public static int SumToN(int n)
        {
            return n * (n + 1) / 2;
        }

        public static string[] GetCorrectArray(string quizResult)
        {
            string[] correct = quizResult.Split('X');
            return correct.Where(c => c != "").ToArray();
        }
    }
}