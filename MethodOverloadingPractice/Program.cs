using System;
using System.ComponentModel;

namespace MethodOverloadingPractice
{
    internal class Program
    {
        public static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public static decimal Add(decimal num1, decimal num2) 
        {
            decimal sum = num1 + num2;
            return sum;
        }

        // If the bool is true, return the sum with the word "dollars"
        // If the bool is false, return the sum as a string
        public static string Add(int num1, int num2, bool isMoney)
        {
            int sum = num1 + num2;
            if (isMoney)
            {         
                if (sum == 1)
                {
                    return $"{sum} dollar";
                }
                else
                {
                    return $"{sum} dollars";
                }
            }
            else
            {
                return $"{sum}";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(3, 4));
            Console.WriteLine(Add(5.38m, 6.54m));
            Console.WriteLine(Add(1, 4, true));
            Console.WriteLine(Add(2, 9, false));
            Console.WriteLine(Add(5, -12, true));
            Console.WriteLine(Add(-2, 3, true));
        }
    }
}
