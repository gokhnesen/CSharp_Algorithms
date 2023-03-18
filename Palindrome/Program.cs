namespace Palindrome
{
    public class Program
    {
        public static string isPalindrome(string str)
        {

            // Insert your code here
            string reverse = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }
            if (str == reverse)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
            return reverse;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(isPalindrome("kayak"));
        }
    }
}