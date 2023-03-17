namespace RotateArray
{
    public class Program
    {
        //https://leetcode.com/problems/rotate-array/
        public static void Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n; 

            ReverseArray(nums, 0, n - 1);
            ReverseArray(nums, 0, k - 1);
            ReverseArray(nums, k, n - 1);
        }

        static void ReverseArray(int[] arr,int left,int right)
        {
            while(left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3,4,5,6,7 };
            Rotate(arr, 3);
            Console.WriteLine(String.Join(",", arr));
        }
    }
}