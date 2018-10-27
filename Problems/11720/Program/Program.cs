using System;
using System.Linq;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            int length = int.Parse(s1);
            string s2 = Console.ReadLine();
            int sum = SumOfNumbers(s2);
            Console.WriteLine(sum);
        }

        public static int SumOfNumbers(string numbers)
        {
            return numbers.Select(n => int.Parse(n.ToString())).Sum();
        }
    }
}
