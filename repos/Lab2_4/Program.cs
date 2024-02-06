using System;

namespace Lab2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the number of numbers
            Console.Write("How many numbers do you want to enter (2 or 3): ");
            int numNumbers = int.Parse(Console.ReadLine());

            // Declare variables to store the numbers
            double firstNumber, secondNumber, thirdNumber = 0;

            // Prompt the user to enter the numbers
            if (numNumbers == 2)
            {
                Console.Write("Enter the first number: ");
                firstNumber = double.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                secondNumber = double.Parse(Console.ReadLine());
            }
            else if (numNumbers == 3)
            {
                Console.Write("Enter the first number: ");
                firstNumber = double.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                secondNumber = double.Parse(Console.ReadLine());

                Console.Write("Enter the third number: ");
                thirdNumber = double.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Invalid number of numbers entered.");
                return;
            }

            // Calculate the power of the numbers
            double result;
            if (numNumbers == 2)
            {
                result = Math.Pow(firstNumber, secondNumber);
            }
            else
            {
                result = Math.Pow(Math.Pow(firstNumber, secondNumber), thirdNumber);
            }

            // Display the result to the console
            Console.WriteLine("The result is: {0}", result);

            Console.ReadLine();
        }
    }
}
