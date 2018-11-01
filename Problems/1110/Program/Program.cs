using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            int n = int.Parse(s1);

            int count = 0;
            int number = n;

            do
            {
                number = GetCycleNumber(number);
                count++;
            }
            while (number != n);

            Console.WriteLine(count);
        }

        public static int GetCycleNumber(int n)
        {
            int left = n / 10;
            int right = n % 10;

            int newNumber = left + right;
            int newNumberRight = newNumber % 10;

            int nextNumber = int.Parse(right + "" + newNumberRight);

            return nextNumber;
        }
    }
}
