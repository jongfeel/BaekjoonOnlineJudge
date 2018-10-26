using System;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            int count = GetTotalSugarPackageCount(n);
            Console.WriteLine(count);
        }

        public static int GetTotalSugarPackageCount(int n)
        {
            // 최대 담을 수 있는 5kg 봉지 개수를 구하고
            // 5Kg 봉지 개수를 줄여가며 3Kg 봉지에 담기는지 조사

            int Pkg5 = 0;
            int Pkg3 = 0;
            int Mod = 0;
            int PkgCount = 0;

            // 최대 담을 수 있는 5kg 봉지 개수
            int Pkg5MaxCount = n / 5;

            // 5Kg 봉지에 깔끔하게 담기면 3Kg 봉지에 담기는지 조사할 필요 없음
            if (n % 5 == 0)
            {
                return Pkg5MaxCount;
            }

            // 5Kg에 담았던 설탕을 풀어 헤칠 준비
            for (int i = Pkg5MaxCount; i >= 0; i--)
            {
                // 5Kg 봉지에 담긴 갯수
                Pkg5 = i;
                // 5Kg 봉지에 담고 남은 설탕의 무게
                Mod = n - 5 * i;
                // 5Kg 봉지에 담아보고 남은 설탕이 3Kg 봉지에 담김
                if (Mod % 3 == 0)
                {
                    Pkg3 = Mod / 3;
                    break;
                }
            }

            PkgCount = Pkg5 + Pkg3;

            //Console.WriteLine($"Pkg5: {Pkg5}, Pkg3: {Pkg3}");

            // 담을 수 없다면 -1
            return PkgCount == 0 ? -1 : PkgCount;
        }
    }
}
