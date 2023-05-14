namespace NextGreateElement
{
    public class Program
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            int[] nextGreat= new int[40];
            for(int i = 0; i < nums1.Length; i++)
            {
                for(int j = 0;j < nums2.Length; j++)
                {
                    if (nums1[i] > nums2[j])
                    {
                        nextGreat[i] = nums2[j];
                        break;
                    }
                    else
                    {
                        nextGreat[i] = -1;
                    }
                }
            }
            return nextGreat;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}