using System.Text.RegularExpressions;

namespace SearchingChallenge
{
    public class Program
    {
        public static string SearchingChallenge(string str)
        {
            int sum = 0;
            int n = str.Length;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i]>='0') && (str[i] <= '9'))
                {
                    sum += (str[i] - '0');
                }
            }
            Console.WriteLine(sum);
            return str;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(SearchingChallenge(Console.ReadLine()));
            string input = "abc123def45g6h7";
            int sum = 0;

            // Use regular expression to match all the numbers in the string
            Regex regex = new Regex(@"\d+");
            MatchCollection matches = regex.Matches(input);

            // Loop through each match and add the value to the sum
            foreach (Match match in matches)
            {
                int value = int.Parse(match.Value);
                sum += value;
            }

            Console.WriteLine("The sum of all the numbers in the string is: " + sum);
        }
    }
}