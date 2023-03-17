namespace ArraysLeftRotation
{
    internal class Program
    {
        //https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem

        public static List<int> rotLeft(List<int> a, int d)
        {
            var rotatedArray= new List<int>();
            var i = 0;
            var index = d;
            
            while(index < a.Count)
            {
                rotatedArray[i] = a[index];
                i++;
                index++;
            }

            index = 0;

            while (index < d)
            {
                rotatedArray[i] = a[index];
                i++;
                index++;
            }
            return rotatedArray;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(rotLeft(new List<int> { 1, 2, 3, 4, 5 }, 5));
        }
    }
}