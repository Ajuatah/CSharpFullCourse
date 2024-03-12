using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the first number
        Console.Write("Enter the first number: ");
        // Read the user input and convert it to a double
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the second number
        Console.Write("Enter the second number: ");
        // Read the user input and convert it to a double
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        // Calculate the sum of the two numbers
        double sum = firstNumber + secondNumber;

        // Display the sum
        Console.WriteLine("The sum of {0} and {1} is: {2}", firstNumber, secondNumber, sum);

        // Keep the console window open until a key is pressed
        Console.ReadKey();
    }
}
