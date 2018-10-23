using System;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int a = int.Parse(s1);
            int b = int.Parse(s2);
            Console.WriteLine(Program.Add(a, b));
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
