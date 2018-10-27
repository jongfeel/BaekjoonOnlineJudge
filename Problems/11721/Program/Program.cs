using System;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int lineCount = s.Length / 10 + 1;
            for (int i = 1; i < lineCount; i++)
            {
                // "\n"을 삽입할 때 마다 s의 length가 1씩 늘어난다.
                // 두번째 줄 부터는 삽입한 "\n"의 갯수만큼 더 더해준 startIndex를 넣어줘야 함
                s = s.Insert(i * 10 + (i - 1), "\n");
            }

            Console.WriteLine(s);
        }
    }
}