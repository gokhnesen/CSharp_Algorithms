﻿namespace HappyNumber
{
    internal class Program
    {
        //https://leetcode.com/problems/happy-number
        public bool IsHappy(int n)
        {
            HashSet<int> seen = new HashSet<int>(); // To detect cycles

            while (n != 1 && !seen.Contains(n))
            {
                seen.Add(n);
                n = GetNextNumber(n);
            }

            return n == 1;
        }

        private int GetNextNumber(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}