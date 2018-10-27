using System;
using System.Text;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            for (int i=n; i>0; i--)
            {
                for (int j=0; j<n-i; j++)
                {
                    Console.Write(" ");
                }
                for (int k=0; k<i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
