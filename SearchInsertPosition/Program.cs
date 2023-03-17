namespace SearchInsertPosition
{
    public class Program
    {
        //https://leetcode.com/problems/search-insert-position/
        public static int SearchInsert(int[] nums, int target)
        {
      
            for(int i = 0; i < nums.Length; i++)
            {
                if(target == nums[i] || nums[i]>target)
                {
                    return i;
                }
                
            }
            return nums.Length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SearchInsert(new int[]{ 1,2, 3, 5 }, 4));
        }
    }
}