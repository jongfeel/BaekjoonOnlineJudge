using System;
using System.Linq;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            int score = int.Parse(s1);
            string grade = GetGrade(score);
            Console.WriteLine(grade);
        }

        public static string GetGrade(int score)
        {
            return score >= 90 ? "A" : score >= 80 ? "B" : score >= 70 ? "C" : score >= 60 ? "D" : "F";
        }
    }
}
