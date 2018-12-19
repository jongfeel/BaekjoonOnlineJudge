using System;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            DrawDefaultTriangle(n);
        }

        public static void DrawTriangle(int n)
        {
            
        }

        public static void DrawDefaultTriangle(int n)
        {
            double k = Math.Log(n / 3, 2);
            Console.WriteLine(k);
            Console.WriteLine("  *  ");
            Console.WriteLine(" * * ");
            Console.WriteLine("*****");
        }
    }
}
