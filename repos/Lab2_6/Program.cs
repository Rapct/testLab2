using System;

namespace Lab2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the number of numbers
            Console.Write("How many numbers do you want to enter (2 or 3): ");
            int numNumbers = int.Parse(Console.ReadLine());

            // Declare variables to store the numbers
            double firstNumber, secondNumber = 0, thirdNumber = 0;

            // Prompt the user to enter the numbers
            Console.Write("Enter the first number: ");
            firstNumber = double.Parse(Console.ReadLine());

            if (numNumbers >= 2)
            {
                Console.Write("Enter the second number: ");
                secondNumber = double.Parse(Console.ReadLine());
            }

            if (numNumbers == 3)
            {
                Console.Write("Enter the third number: ");
                thirdNumber = double.Parse(Console.ReadLine());
            }

            // Call the appropriate library method based on the number of numbers
            double result;
            if (numNumbers == 2)
            {
                result = Lab2_5.MathOperations.CalculatePower(firstNumber, secondNumber);
            }
            else
            {
                result = Lab2_5.MathOperations.CalculatePower(firstNumber, secondNumber, thirdNumber);
            }

            // Display the result to the console
            Console.WriteLine("The result is: {0}", result);

            Console.ReadLine();
        }
    }
}
