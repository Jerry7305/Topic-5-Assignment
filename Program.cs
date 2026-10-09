using System.Security.Cryptography.X509Certificates;

namespace Topic_5_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            part1();
        }
      public static void part1()
        {
            double weight; 

            Console.WriteLine("Please enter your current earth weight:");
            Double.TryParse(Console.ReadLine(), out weight);
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine();
            Console.WriteLine("I have information for the followin planets:");

            
        }
    }
}
