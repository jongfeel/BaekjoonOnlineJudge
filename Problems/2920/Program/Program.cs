using System;
using System.Linq;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string[] ss1 = s1.Split();
            int[] codes = Array.ConvertAll(ss1, int.Parse);
            
            Console.WriteLine(GetCodeResult(codes));
        }

        public static string GetCodeResult(int[] codes)
        {
            var result = codes.Zip(codes.Skip(1), (x, y) => y - x);
            bool isAscending = result.All(diff => diff == 1);
            bool isDescending = result.All(diff => diff == -1);
            return isAscending ? "ascending" : isDescending ? "descending" : "mixed";
        }
    }
}