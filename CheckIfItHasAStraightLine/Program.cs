using System.Runtime.InteropServices;

namespace CheckIfItHasAStraightLine
{
    //https://leetcode.com/problems/check-if-it-is-a-straight-line
    public class Program
    {
        public bool CheckStraightLine(int[][] coordinates)
        {

            for (int i = 2; i < coordinates.Length; i++)
            {
                if ((coordinates[i][0] - coordinates[i - 1][0]) *
                    (coordinates[i - 1][1] - coordinates[i - 2][1]) !=
                    (coordinates[i - 1][0] - coordinates[i - 2][0]) *
                    (coordinates[i][1] - coordinates[i - 1][1]))
                {
                    return false;
                }
            }
                return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}