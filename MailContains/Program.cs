namespace MailContains
{
    public class Program
    {
        public static string[] myFunc(string[] mails)
        {

            string gmail = "@gmail.com";
            foreach (var mail in mails)
            {
                if (mail.Contains(gmail))
                {
                    Console.WriteLine(mail);
                }
            }
            return mails;
        
          
     
        }
        static void Main(string[] args)
        {
            
            string[] emails = new string[] { "hatice@hotmail.com", "gokolo@gmail.com", "sakir@hotmail.com","baboli@gmail.com" };
            Console.WriteLine(myFunc(emails));
            
        }
    }
}