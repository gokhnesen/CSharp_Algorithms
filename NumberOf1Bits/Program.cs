namespace NumberOf1Bits
{
    public class Program
    {
        public int HammingWeight(uint n)
        {
            return System.Numerics.BitOperations.PopCount(n);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}