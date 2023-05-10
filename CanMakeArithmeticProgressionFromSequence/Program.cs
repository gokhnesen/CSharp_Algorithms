namespace CanMakeArithmeticProgressionFromSequence
{
    //https://leetcode.com/problems/can-make-arithmetic-progression-from-sequence
    public class Program
    {
        public bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);
            for(int i=0;i<arr.Length-1; i++)
            {
                int diff = Math.Abs(arr[0]- arr[1]);
                if (arr[i] + diff == arr[i + 1])
                {
                    return true;
                }

            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}