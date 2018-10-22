using System;
using _1000;
using _1001;
using _10998;
using _1008;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();
            int a = int.Parse(ss[0]);
            int b = int.Parse(ss[1]);
            Console.WriteLine(_1000.Program.Sum(a, b));
            Console.WriteLine(_1001.Program.Sub(a, b));
            Console.WriteLine(_10998.Program.Mul(a, b));
            Console.WriteLine(_1008.Program.Div(a, b));
            Console.WriteLine(Modulo(a, b));
        }

        public static int Modulo(int a, int b)
        {
            return a % b;
        }
    }
}
