using System;

namespace _10998
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();
            int a = int.Parse(ss[0]);
            int b = int.Parse(ss[1]);
            Console.WriteLine(Program.Mul(a, b));
        }

        public static int Mul(int a, int b)
        {
            return a * b;
        }
    }
}
