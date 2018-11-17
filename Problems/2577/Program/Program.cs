using System;
using System.Collections.Generic;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            int A  = int.Parse(s1);
            int B  = int.Parse(s2);
            int C  = int.Parse(s3);

            int[] result = GetNumberCount(A * B * C);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] GetNumberCount(int value)
        {
            int[] result = new int[10];
            foreach (char item in value.ToString())
            {
                if (item == '0') result[0]++;
                if (item == '1') result[1]++;
                if (item == '2') result[2]++;
                if (item == '3') result[3]++;
                if (item == '4') result[4]++;
                if (item == '5') result[5]++;
                if (item == '6') result[6]++;
                if (item == '7') result[7]++;
                if (item == '8') result[8]++;
                if (item == '9') result[9]++;
            }
            return result;
        }
    }
}