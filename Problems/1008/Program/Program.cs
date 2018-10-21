using System;

namespace _1008
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();
            double a = double.Parse(ss[0]);
            double b = double.Parse(ss[1]);
            Console.WriteLine(Program.Div(a, b));
        }

        public static double Div(double a, double b)
        {
            return a / b;
        }
    }
}
