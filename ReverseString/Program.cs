namespace ReverseString
{
    public class Program
    {
        //https://leetcode.com/problems/reverse-string
        public static void ReverseString(char[] s)
        {
            Array.Reverse(s);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text to be reversed");
            string inputText = Console.ReadLine();
            char[] myChar = inputText.ToCharArray();
            Array.Reverse(myChar);

            foreach (char character in myChar)
            {
                Console.Write(character);
            }
            Console.ReadLine();
            Console.WriteLine("------------");
          
        }
    }
}