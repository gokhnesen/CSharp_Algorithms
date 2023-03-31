namespace CountOddNumbers
{
    internal class Program
    {
        //https://leetcode.com/problems/count-odd-numbers-in-an-interval-range
        public int CountOdds(int low, int high)
        {
            int odd = 0;

            for(int i=low;i<high;i++)
            {
                if(i%2 == 0)
                {
                    odd++;
                }
            }
            return odd;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}