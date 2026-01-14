namespace Check_year_Is_leap_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Year: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 4 == 0)
            {
                Console.WriteLine("Its_Leap");
            }
            else
                Console.WriteLine("not_leap");
        }
    }
}