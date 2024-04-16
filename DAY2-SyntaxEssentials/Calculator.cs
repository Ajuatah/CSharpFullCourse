using System;

namespace DAY2_SyntaxEssentials
{
    public class CalculatorMethods
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException("Error: Division by zero!");
            }
            return num1 / num2;
        }
    }

    class Calculator
    {
       

        public static void RunCalculator(CalculatorMethods calculator)
        {
            Console.WriteLine("Welcome to Simple Calculator!");

            while (true)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice (1-5): ");
                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    break;
                }

                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (choice)
                {
                    case "1":
                        result = calculator.Add(num1, num2);
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;
                    case "2":
                        result = calculator.Subtract(num1, num2);
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;
                    case "3":
                        result = calculator.Multiply(num1, num2);
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;
                    case "4":
                        try
                        {
                            result = calculator.Divide(num1, num2);
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please select a valid operation.");
                        break;
                }
            }
        }
    }
}
