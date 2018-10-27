using System;
using System.Globalization;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();
            int x = int.Parse(ss[0]);
            int y = int.Parse(ss[1]);
            string dayofweek = GetDayOfWeek(x, y);
            Console.WriteLine(dayofweek);
        }

        public static string GetDayOfWeek(int x, int y)
        {
            return new DateTime(2007, x, y).ToString("ddd", new CultureInfo("en-US")).ToUpper();
        }
    }
}
