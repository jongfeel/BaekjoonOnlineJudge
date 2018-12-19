using System;

namespace Problem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int testCaseCount = int.Parse(s);
            
			string[][] PhoneNumbers = new string[testCaseCount][];
            for (int i=0; i<testCaseCount; i++)
            {
                string ss = Console.ReadLine();
                int PhoneNumberCount = int.Parse(ss);
                PhoneNumbers[i] = new string[PhoneNumberCount];
                for (int j=0; j<PhoneNumberCount; j++)
                {
                    string sss = Console.ReadLine();
                    PhoneNumbers[i][j] = sss;
                }
            }
			
			for (int i=0; i<testCaseCount; i++)
			{
				Console.WriteLine(GetValidate(PhoneNumbers[i]));
			}
        }

        public static string GetValidate(string[] PhoneNumbers)
        {
            Array.Sort(PhoneNumbers, StringComparer.InvariantCulture);
            for (int i=0; i<PhoneNumbers.Length-1; i++) {
                string prefix = PhoneNumbers[i];
                if (PhoneNumbers[i+1].StartsWith(prefix))
                {
                    return "NO";
                }   
            }
        
            return "YES";
        }
    }
}