namespace Check_Vowel
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            char ch = Console.ReadLine()[0];

            if("aeiouAEIOU".Contains(ch))
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Constent");
            }
        }
    }
}