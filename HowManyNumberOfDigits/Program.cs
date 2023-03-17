namespace HowManyNumberOfDigits
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Find how many digits the entered number has


            Console.WriteLine("Enter the number you want to know the number of digits");

            int number = int.Parse(Console.ReadLine());

            int _number = number;
            int sum = 0;
            while (number >= 10)
            {
                number /= 10;
                sum++;
            }
            sum++;
            Console.WriteLine($"{_number}  has {sum} digits ");
        }
    }
}