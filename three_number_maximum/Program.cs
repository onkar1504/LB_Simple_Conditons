//Take three numbers and print the largest.

namespace three_number_maximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Fist no ");
            int n1 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter The second no ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter The Fist no ");
            int n3 = Convert.ToInt32(Console.ReadLine());


            if (n1 > n2  && n1 > n3)
            {
                Console.WriteLine("First larger");
            }
            else if (n2 > n3)
            {
                Console.WriteLine("second larger");
            }
            else
            {
                Console.WriteLine("third larger");
            }

        }
    }
}