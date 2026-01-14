// Take a temperature value and print “Cold”, “Warm”, or “Hot” using range conditions.
namespace temperature_range_classification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Temprateure ");
            int Temp = Convert.ToInt32(Console.ReadLine());


            if (Temp < 10)
                Console.WriteLine("Cold");
            else if (Temp > 10 && Temp < 20)
            {
                Console.WriteLine("Warm");
            }
            else
                Console.WriteLine("Hot");
         
        }
    }
}