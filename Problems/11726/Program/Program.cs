using System;

namespace Problem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            
			Console.WriteLine(GetMethodCount(n));
        }

        public static int GetMethodCount(int n)
        {
            int[] count = new int[1001];
			count[0] = 1;
			count[1] = 1;
			count[2] = 2;
    
  			for (int i=2; i<=n; i++) {
       			count[i] = (count[i-1] + count[i-2]) % 10007;
    		}
    
    		return count[n];
        }
    }
}