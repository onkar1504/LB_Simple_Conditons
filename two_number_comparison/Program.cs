// 6. Take two numbers and print the larger one.
namespace two_number_comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Fist no ");
            int n1= Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter The second no ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            
            if(n1 > n2)
            {
                Console.WriteLine("fisrt  larger");
            }
            else {
                Console.WriteLine("Second largers");
            }    
        }
    }
}