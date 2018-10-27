using System;
using System.Globalization;
using System.Linq;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            int sum = SumOfN(n);
            Console.WriteLine(sum);
            //Console.WriteLine(Enumerable.Range(1, n).Sum());
        }

        public static int SumOfN(int n)
        {
            return n * (n + 1) / 2;
        }
    }
}
