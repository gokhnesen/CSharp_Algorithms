namespace SquaresOfSortedArray
{
    public class Program
    {
        //https://leetcode.com/problems/squares-of-a-sorted-array/

        public static int[] SortedSquares(int[] nums)
        {
            List<int> result = new List<int>();
            foreach (var i in nums) 
            {
                result.Add(i*i);
            }
            result.Sort();
            return result.ToArray();
         
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SortedSquares(new int[] {-1,-4,1,3,7,5}));
        }
    }
}