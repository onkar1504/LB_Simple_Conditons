namespace character_type_identification
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            char ch = Console.ReadLine()[0];


            if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine("Uppercase Letter");
            }
            else if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine("Lowercase Letter");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("Digit");
            }
            else
            {
                Console.WriteLine("Special Character");
            }
        }
    }
}