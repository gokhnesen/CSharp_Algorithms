namespace CheckIfOneStringSwapCanMakeStringsEqual
{
    //https://leetcode.com/problems/check-if-one-string-swap-can-make-strings-equal
    public class Program
    {
        public bool AreAlmostEqual(string s1, string s2)
        {
            char[] str1=new char[s1.Length];
            for(int i = 0; i < str1.Length; i++)
            {
                str1[i] = s1[i];
            }
            Array.Sort(str1);

            char[] str2=new char[s2.Length];
            for(int i=0;i< str2.Length; i++)
            {
                str2[i] = s2[i];
            }
            Array.Sort(str2);

            return str1.ToString().Equals(str2.ToString());
          
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}