namespace NumberEqualsOfDigitsCube
{
    public class Program
    {
        //find out if the sum of the cubes of the digits of the entered 3-digit number is equal to the number itself
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 digit number");
            int number = int.Parse(Console.ReadLine());
            if (Digit(number))
            {
                double sum = 0;
                while (true)
                {
                    int digit = number % 10;
                    number = number / 10;
                    sum += Math.Pow(digit, 3);

                    if (number < 10)
                    {
                        digit = number;
                        sum += Math.Pow(digit, 3);
                        break;
                    }
                }
                if(sum == number)
                {
                    Console.WriteLine("Equal "+sum);
                }
                else
                {
                    Console.WriteLine("Not Equal "+sum);
                }
            
            }
            else
            {
                Console.WriteLine("Please enter 3 digit");
            }
        
      
        }

        static bool Digit(int numberDigit)
        {
            int digit = 1;
            while(numberDigit > 10)
            {
                numberDigit /= 10;
                digit++;
            }
            return digit==3 ? true : false;
        }
    }
}