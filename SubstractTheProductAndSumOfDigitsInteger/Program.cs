namespace SubstractTheProductAndSumOfDigitsInteger
{
    public class Program
    {
        //https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/

        public int SubtractProductAndSum(int n)
        {
            var sumDigit = 0;
            var productDigit = 1;
            while(n>=10)
            {
                int digit =n%10;
                n /= 10;
                sumDigit += digit;
                productDigit *= digit;
                if (n < 10)
                {
                    digit = n;
                    sumDigit += digit;
                    productDigit *= digit;
                }
    
            }
            return productDigit - sumDigit;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}