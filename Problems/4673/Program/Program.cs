using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool[] selfNumbers = Enumerable.Repeat<bool>(true, 10000).ToArray();

            for (int i = 1; i < 10000; i++)
            {
                int d = Get_d(i);
                // don't care condition d(n) > 10000
                if (d < 10000)
                {
                    selfNumbers[Get_d(i)] = false;
                }
            }
            
            for (int i = 1; i < 10000; i++)
            {
                if (selfNumbers[i])
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static int Get_d(int n)
        {
            int thousand = n / 1000;
            int hundred = n % 1000 / 100;
            int ten = n % 100 / 10;
            int digit = n % 10;
            
            return n + thousand + hundred + ten + digit;
        }
    }
}
