﻿using System;
using System.Text;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            StringBuilder output = new StringBuilder(n);
            for (int i=n; i>0; i--)
            {
                output.AppendLine(i.ToString());
            }
            Console.WriteLine(output.ToString());
        }
    }
}
