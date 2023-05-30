namespace SignOfTheProductOfAnArray
{
    internal class Program
    {
        ////https://leetcode.com/problems/sign-of-the-product-of-an-array
        public int ArraySign(int[] nums)
        {
            var sum = 1;
            for(int i=0;i<=nums.Length; i++)
            {
                sum *= nums[i];
            }
            return signFunc(sum);
        }

        public int signFunc(int product)
        {
            int result=0;
            if(product == 0)
            {
                result= 0;
            }
            if(product >= 1)
            {
                 result= 1;
            }
            if(product < 0)
            {
                result= -1;
            }
            return result;
        }

       
        static void Main(string[] args)
        {
            
        }
    }
}