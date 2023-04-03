namespace AverageSalary
{
    public class Program
    {
        //https://leetcode.com/problems/average-salary-excluding-the-minimum-and-maximum-salary/
        public double Average(int[] salary)
        {
            double sum = 0;
            int max = salary[0];
            int min = salary[0];
            
            for (int i = 0; i < salary.Length; i++)
            {
                if (min > salary[i])
                {
                    min = salary[i];
                }
                if (max < salary[i])
                {
                    max = salary[i];
                }
               sum += salary[i];
            }
            return (sum - max - min) / (salary.Length - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}