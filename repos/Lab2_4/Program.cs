using System;
//Mengtian Lin, CPS3330 * 2, Lab #2
namespace Lab2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber, thirdNumber;

            // Prompt the user to enter three numbers
            Console.Write("Enter the first number: ");
            firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            secondNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            thirdNumber = double.Parse(Console.ReadLine());

            // Calculate the power of three numbers
            double result = Math.Pow(Math.Pow(firstNumber, secondNumber), thirdNumber);

            // Display the result to the console
            Console.WriteLine("The result is: {0}", result);

            Console.ReadLine();
        }
    }
}
