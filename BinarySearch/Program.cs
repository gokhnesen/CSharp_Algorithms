namespace BinarySearch
{
    public class Program
    {
        //https://leetcode.com/problems/binary-search

        public static  int Search(int[] nums, int target)
        {
            int i = Array.BinarySearch(nums, target);
            return (i < 0) ? -1 : i;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine(Search(new int[] {1,2,3,4,5,6},8));
        }
    }
}