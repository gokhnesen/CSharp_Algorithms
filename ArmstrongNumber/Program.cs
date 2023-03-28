namespace ArmstrongNumber
{
    public class Program
    {
        public static int Armstrong(int num)
        {
            int sum = 0;
            int temp = num;

            while (true)
            {
                int digit = num % 10;
                num= num / 10;
                sum += (int)Math.Pow(digit, 3);
                if (num < 10)
                {
                    digit = num;
                    sum += (int)Math.Pow(digit, 3);
                    
                    if (sum == temp)
                    {
                        Console.WriteLine(temp + " is a armstrong number");
                    }
                    else
                    {
                        Console.WriteLine(temp + " is not a armstrong number");
                    }
                    
                    break;

                }
        

            }
    
            return sum;

        }
        static void Main(string[] args)
        {
            Console.Write(Armstrong(371));
        }
    }
}