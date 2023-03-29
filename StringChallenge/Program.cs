using System.Text.RegularExpressions;

namespace StringChallenge
{
    public class Program
    {
        public static string StringChallenge(string str)
        {
           
            str = Regex.Replace(str, @"(^\w)|(\s\w)", m => m.Value.ToUpper());
            return str;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(StringChallenge(Console.ReadLine()));
        }
    }
}