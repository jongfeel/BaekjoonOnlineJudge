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
            string [] s11 = s1.Split();
            int n = int.Parse(s11[0]);
            int x = int.Parse(s11[1]);

            string s2 = Console.ReadLine();
            string [] s22 = s2.Split();
            int [] a = new int[s22.Length];
            for (int i = 0; i < s22.Length; i++)
            {
                a[i] = int.Parse(s22[i]);
            }
            
            List<int> result = GetLessthan(a, x);
            result.ForEach(item => Console.Write(item + " "));
        }

        public static List<int> GetLessthan(int[] a, int x)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < x)
                {
                    result.Add(a[i]);
                }
            }

            return result;
        }
    }
}
