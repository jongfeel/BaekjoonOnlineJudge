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
            int n = int.Parse(s1);

            string s2 = Console.ReadLine();
            string [] s22 = s2.Split();
            int [] scores = new int[s22.Length];
            for (int i = 0; i < s22.Length; i++)
            {
                scores[i] = int.Parse(s22[i]);
            }
            
            double result = GetAverageSejoonMethod(scores);
            Console.WriteLine(result.ToString("F2"));
        }

        public static double GetAverageSejoonMethod(int[] a)
        {
            return a.Select(score => score/(double)a.Max()*100).Average();
        }
    }
}
