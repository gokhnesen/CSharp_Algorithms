namespace FirstBadVersion
{
    public class Program:VersionControl
    {
        //https://leetcode.com/problems/first-bad-version
        
        public int FirstBadVersion(int n)
        {
            int left = 1;
            int right = n;
            while(left<=right)
            {
                int middle = (right - left) / 2 + left;
                if(!IsBadVersion(middle)) 
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            return left;
        }

     

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}