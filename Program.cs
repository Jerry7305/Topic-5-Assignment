using System.ComponentModel.Design;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Topic_5_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part1();
            Console.WriteLine("Press Enter to continue to Part 2");
            Console.ReadLine();
            Console.Clear();
            Part2();
            Console.WriteLine("Press Enter to continue to Part 3");
            Console.ReadLine();
            Console.Clear();
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
            double score = 0;
            string answer;
            string correctAnswer;

            Console.WriteLine("Welcome to my math quiz!");
            Console.WriteLine("Question 1: What is 2+2"); //Answer is B
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
            Console.WriteLine("Question 2: What is 9x6");  //Answer is 54
            answer = Console.ReadLine();
            if (answer == "54")
            {
                Console.WriteLine("Correct!");
                score = score + 1;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }

            if (score == 2)
            {
                Console.WriteLine("2/2 Good work so far!");
            }
            Console.WriteLine("Question 3: What math operation gives you a difference in numbers?  Hint: Type it in it's word form not symbol");
            answer = Console.ReadLine().ToLower();                //Answer is subtraction or (-) for a half mark

            if (answer == "subtraction")
            {
                Console.WriteLine("Correct!");
                score = score + 1;
            }
            else if (answer == "-")
            {
                Console.WriteLine("You were supposed to type it in word form but I'll give you a half mark");
                score = score + 0.5;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }    
            if (score == 3)
            {
                Console.WriteLine("3/3! Wow your doing very good!");
            }
            Console.WriteLine("Question 4: True or false? Does 12x12 = 144?");  //Answer is true
            answer = Console.ReadLine().ToLower();

            if (answer == "true")
            {
                Console.WriteLine("Correct!");
                score = score + 1;
            }
            else if (answer == "false")
            {
                Console.WriteLine("Wrong!");
            }
            Console.WriteLine("Thats the end of my quiz. Thank you for taking it!");
            Console.WriteLine("Press Enter to see your results!");
            Console.ReadLine();

            Console.WriteLine(score + "/4");
            Console.WriteLine("Or");
            if (score == 0)
            {
                Console.WriteLine((0.0/4.0).ToString("P"));
                Console.WriteLine("Maybe math isn't your thing.");
            }
            if (score == 0.5)
            {
                Console.WriteLine((0.5/4).ToString("P"));
                Console.WriteLine("At least it's not 0!");
            }
            if (score == 1) 
            {
                Console.WriteLine((1.0/4.0).ToString("P"));
                Console.WriteLine("At least you tried");
            }
            if (score == 1.5)
            {
                Console.WriteLine((1.5/4.0).ToString("P"));
                Console.WriteLine("At least you tried");
            }
            if (score == 2.0)
            {
                Console.WriteLine((2.0/4.0).ToString("P"));
                Console.WriteLine("You passed!");
            }
            if (score == 2.5)
            {
                Console.WriteLine((2.5/4.0).ToString("P"));
                Console.WriteLine("Good effort!");
            }
            if (score == 3.0)
            {
                Console.WriteLine((3.0/4.0).ToString("P"));
                Console.WriteLine(" 75%, Not bad!");
            }
            if (score == 3.5)
            {
                Console.WriteLine((3.5/4.0).ToString("P"));
                Console.WriteLine("Almost perfect!");
            }
            if (score == 4.0)
            {
                Console.WriteLine((score/4.0).ToString("P"));
                Console.WriteLine("Congrats! you got perfect!");
            }
        }
    }
}

