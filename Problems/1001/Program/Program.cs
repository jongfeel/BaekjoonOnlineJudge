using System;

namespace _1001
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();
            int a = int.Parse(ss[0]);
            int b = int.Parse(ss[1]);
            Console.WriteLine(Program.Sub(a, b));
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
