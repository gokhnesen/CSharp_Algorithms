namespace TwoSum
{
    public class Program
    {
        //https://leetcode.com/problems/two-sum-ii-input-array-is-sorted
        public static int[] TwoSum(int[] numbers, int target)
        {
            int index=0, index2=numbers.Length-1;
            while (numbers[index] + numbers[index2] != target)
            {
                if (numbers[index] + numbers[index2] > target)
                {
                    index2--;
                }
                else index++;
            }
            return new int[] {index+1,index2+1};
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.Write(TwoSum(numbers, 3));
        }
    }
}