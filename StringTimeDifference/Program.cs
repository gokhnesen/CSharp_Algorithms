namespace StringTimeDifference
{
    public class Program
    {
        public static string StringChallenge(string str)
        {
            int minutes = CalculateTimeDifference(str);
            return minutes.ToString();
        }
        static int CalculateTimeDifference(string str)
        {
            string[] timeStrings = str.Split('-');
            string startTimeString = timeStrings[0];
            string endTimeString = timeStrings[1];

            int startTime = GetMinutesFromTimeString(startTimeString);
            int endTime = GetMinutesFromTimeString(endTimeString); 

            if(endTime<startTime)
            {
                endTime += 24 * 60;
            }
            
            return endTime - startTime;
        }
        static int GetMinutesFromTimeString(string timeString)
        {
            string[] parts = timeString.Split(':');
            int hours = int.Parse(parts[0]);
            int minutes = int.Parse(parts[1].Substring(0, 2));
            bool isAM = parts[1].Substring(2).ToLower() == "am";

            if (hours == 12)
            {
                hours = 0; // handle 12:xx am/pm edge case
            }

            if (!isAM)
            {
                hours += 12; // add 12 to hours for pm times
            }

            return hours * 60 + minutes;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(StringChallenge(Console.ReadLine()));
        }
    }
}