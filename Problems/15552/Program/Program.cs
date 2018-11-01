using System;
using System.Text;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            int t = int.Parse(s1);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < t; i++)
            {
                string s2 = Console.ReadLine();
                string[] s22 = s2.Split();
                int a = int.Parse(s22[0]);
                int b = int.Parse(s22[1]);

                sb.Append(a + b + "\n");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
