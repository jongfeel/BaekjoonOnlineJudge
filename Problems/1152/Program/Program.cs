using System;
using System.Linq;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            s1 = s1.TrimStart();
            s1 = s1.TrimEnd();

            Console.WriteLine(GetWordCount(s1));
        }

        public static int GetWordCount(string s1)
        {
            return s1.Split().Where(word => word != string.Empty).Count();
        }
    }
}
