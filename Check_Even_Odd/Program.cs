namespace Check_Even_Odd
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The no: ");
            int n = Convert.ToInt32(Console.ReadLine());
           
            if(n %2 == 0)
            {
                Console.WriteLine("Even_no");
            }
            else
            {
                Console.WriteLine("Odd_no");
            }
        }
    }
}