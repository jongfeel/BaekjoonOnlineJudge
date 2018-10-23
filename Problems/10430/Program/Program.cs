using System;

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
            int c = int.Parse(ss[2]);
            Console.WriteLine(Program.Modulo1(a, b, c));
            Console.WriteLine(Program.Modulo2(a, b, c));
            Console.WriteLine(Program.Modulo3(a, b, c));
            Console.WriteLine(Program.Modulo4(a, b, c));
        }

        public static int Modulo1(int a, int b, int c)
        {
            return (a + b) % c;
        }

        public static int Modulo2(int a, int b, int c)
        {
            return (a % c + b % c) % c;
        }

        public static int Modulo3(int a, int b, int c)
        {
            return (a * b) % c;
        }

        public static int Modulo4(int a, int b, int c)
        {
            return (a % c * b % c) % c;
        }
    }
}
