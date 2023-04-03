namespace AverageSalary
{
    public class Program
    {
        //https://leetcode.com/problems/average-salary-excluding-the-minimum-and-maximum-salary/
        public double Average(int[] salary)
        {
            int sum = 0;
            int average = 0;
            for (int i = 0; i < salary.Length; i++)
            {
                sum += salary[i];
            }
            return sum/salary.Length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}