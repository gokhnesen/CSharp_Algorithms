namespace HappyNumber
{
    internal class Program
    {
        //https://leetcode.com/problems/happy-number
        public bool IsHappy(int n)
        {
            var digit=0;
            var digit2=0;
            var digit3= 0;
            bool isHappy = false;

            while (n >= 4 || n==1)
            {
                digit = n / 10;
                digit2 = n % 10;

                n = (int)Math.Pow(digit, 2)+ (int)Math.Pow(digit2,2);
             
                if(n <= 10)
                {
                    digit = n % 10;

                    n = (int)Math.Pow(digit, 2);
                }
                
                if(n>=100)
                {
                    digit3 = n / 100;
                    digit2 = n % 100 /10;
                    digit = n % 10;

                    n= (int)Math.Pow(digit,2) + (int)Math.Pow(digit2,2) + (int)Math.Pow(digit3,2); 
                }

                if (n == 1)
                {
                    return isHappy = true;
                }
            }
            return isHappy;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}