using System;
using System.Linq;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string [] s = s1.Split();
            int number1 = int.Parse(s[0]);
            int number2 = int.Parse(s[1]);
            int number3 = int.Parse(s[2]);
            int second = GetSecondOrder(number1, number2, number3);
            Console.WriteLine(second);
        }

        public static int GetSecondOrder(int number1, int number2, int number3)
        {
            return                      number1 > number2 ? 
                              number1 > number3 ?
                    number2 > number3 ?
                    number2 : number3 : number1 > number3 ?
                                        number3 : number1 : number2 > number3 ?
                                                  number1 > number3 ? 
                                                  number1 : number3 : number1 > number2 ?
                                                                      number1 : number2;
        }
    }
}
