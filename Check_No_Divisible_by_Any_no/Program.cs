namespace Check_No_Divisible_by_Any_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The no: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter The no you want to check that can divisble: ");
            int d = Convert.ToInt32(Console.ReadLine());

            if(n % d == 0 )
            {
                Console.WriteLine("Its_Divisble_by:" + d);
            }
            else
            {
                Console.WriteLine("Its_NOt_Divisble_by:" + d);
            }
        }
    }
}