using System.Security.Cryptography.X509Certificates;

namespace Topic_5_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part1();
            Part2();
        }
      public static void Part1()
        {
            double weight;
            double planetWeight;
            int planetChoice;

            Console.WriteLine("Please enter your current earth weight:");
            Double.TryParse(Console.ReadLine(), out weight);
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine();
            Console.WriteLine("I have information for the following planets:");
            Console.WriteLine("\t1. Venus  2. Mars  3. Jupiter");
            Console.WriteLine("\t4. Saturn  5. Uranus  6. Neptune");
            Console.WriteLine("Which planet are you visiting?");
            Int32.TryParse(Console.ReadLine(), out planetChoice);

            if (planetChoice == 1)
            {
                Console.WriteLine("Your weight on Venus is " + weight * 0.78 + "lbs");
            }
            else if (planetChoice == 2)
            {
                Console.WriteLine("You weight on Mars is " + weight * 0.39 + "lbs");
            }
            else if (planetChoice == 3)
            {
                Console.WriteLine("Your weight on Jupiter is " + weight * 2.65 + "lbs");
            }
            else if (planetChoice == 4)
            {
                Console.WriteLine("You weight on Saturn is " + weight * 1.17 + "lbs");
            }
            else if (planetChoice == 5)
            {
                Console.WriteLine("Your weight on Uranus is " + weight * 1.05 + "lbs");
            }
            else if (planetChoice == 6)
            {
                Console.WriteLine("Your weight on Neptune is " + weight * 1.23 + "lbs");

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number 1-6");
            }
        }
        public static void Part2()
        {
        
        }
    }
}
