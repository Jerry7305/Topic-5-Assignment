using System.ComponentModel.Design;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Topic_5_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part1();
            //Part2();
            Part3();
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
            double number1, number2, result;
            string operation;

            Console.WriteLine("Pick any number");
            double.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Pick another number");
            double.TryParse(Console.ReadLine(), out number2);
            Console.WriteLine("Pick any operation (+, -, / x)");
            operation = Console.ReadLine();

            if (operation == "+")
            {
                result = number1 + number2;
                Console.WriteLine(number1 + " + " + number2 + " = " + result);
            }
            else if (operation == "-")
            {
                result = number1 - number2;
                Console.WriteLine(number1 + " - " + number2 + " = " + result);
            }
            else if (operation == "/")
            {
                result = number1 / number2;
                Console.WriteLine(number1 + " / " + number2 + " = " + result);
            }
            else if (operation == "x")
            {
                result = number1 * number2;
                Console.WriteLine(number1 + " x " + number2 + " = " + result);
            }
        }
        public static void Part3()
        {
            int score = 0;
            string answer;
            string correctAnswer;

            Console.WriteLine("Welcome to my math quiz!");
            Console.WriteLine("Question 1: What is 2+2");
            Console.WriteLine("A) 3  " + "B) 4");
            Console.WriteLine("C) 5  " + "D) 0");
            answer = Console.ReadLine();

            if (answer.ToUpper() == "A")
            {
                Console.WriteLine("Wrong!");
            }
            else if (answer.ToUpper() == "B")
            {
                Console.WriteLine("Correct!");
                score = score + 1;
            }
            else if (answer.ToUpper() == "C")
            {
                Console.WriteLine("Wrong!");
            }
            else if (answer.ToUpper() == "D")
            {
                Console.WriteLine("Wrong!");
            }
            else 
            {
                Console.WriteLine("Wrong!");
            }
            Console.WriteLine("Question 2: What is 16-6");
            Console.WriteLine("A) 14  " + "B) 8");
            Console.WriteLine("C) 20  " + "D) 10");
            answer = Console.ReadLine();

            if (answer.ToUpper() == "A")
            {
                Console.WriteLine("Wrong!");
            }
            else if (answer.ToUpper() == "B")
            {
                Console.WriteLine("Wrong!");
            }
            else if (answer.ToUpper() == "C")
            {
                Console.WriteLine("Wrong!");
            }
            else if (answer.ToUpper() == "D")
            {
                Console.WriteLine("Correct");
                score = score + 1;
            }
            else
            {
                Console.WriteLine();
            }
            Console.WriteLine("Question 3: What is 7x7");
            Console.WriteLine("A) 49  " + "B) 42");
            Console.WriteLine("C) 56  " + "D) 46");
            answer = Console.ReadLine();

            if (answer.ToUpper() == "A")
            {
                Console.WriteLine("Correct!");
                score = score + 1;
            }
            else if (answer.ToUpper() == "B")
            {
                Console.WriteLine("Wrong!");
            }
            else if (answer.ToUpper() == "C")
            {
                Console.WriteLine("Wrong!");
            }
            else if (answer.ToUpper() == "D")
            {
                Console.WriteLine("Wrong!");
            }
            else
            {
                Console.WriteLine();
            }
                Console.WriteLine("Question 4: What is 12/6");
            Console.WriteLine("A) 3  " + "B) 4");
            Console.WriteLine("C) 1.5  " + "D) 2");

            answer = Console.ReadLine();
            if (answer.ToUpper() == "A")
            {
                Console.WriteLine("Wrong!");
            }
            else if (answer.ToUpper() == "B")
            {
                Console.WriteLine("Wrong!");
            }
            else if (answer.ToUpper() == "C")
            {
                Console.WriteLine("Wrong!");
            }
            else if (answer.ToUpper() == "D")
            {
                Console.WriteLine("Correct!");
                score = score + 1;
            }
            Console.WriteLine(score);
        }
    }
}

