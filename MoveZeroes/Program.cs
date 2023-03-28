namespace MoveZeroes
{
    public class Program
    {
        //https://leetcode.com/problems/move-zeroes

        public void MoveZeroes(int[] nums)
        {

            int lastElement = 0, curElement = 0;

            while (curElement < nums.Length)
            {
                if (nums[curElement] != 0)
                {
                    int temp = nums[curElement];
                    nums[curElement] = nums[lastElement];
                    nums[lastElement] = temp;
                    lastElement++;
                }
                curElement++;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}