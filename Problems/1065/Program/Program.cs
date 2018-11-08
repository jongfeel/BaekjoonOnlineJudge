using System;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            Console.WriteLine(GetHanNumberCount(n));
        }

        public static int GetHanNumberCount(int n)
        {
            int count = 99;

            // 1 ~ 99는 모두 한수이므로 n 자체를 return해 준다.
            if (n <= count)
            {
                return n;
            }
            // 예제에서 110까지 역시 99개 였으므로 99를 return해 준다.
            else if (n > count && n < 111)
            {
                return count;
            }
            else
            {
                for (int i=111; i<=n; i++)
                {
                    if (HanNumber(i))
                    {
                        count++;
                    }
                }
            }

            return count;
        }
        public static bool HanNumber(int n)
        {
            if (n == 1000)
            {
                return false;
            }

            int hundred = n % 1000 / 100;
            int ten = n % 100 / 10;
            int digit = n % 10;
            
            return hundred - ten == ten - digit;
        }
    }
}
