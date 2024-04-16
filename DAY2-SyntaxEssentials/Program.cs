using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace DAY2_SyntaxEssentials
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Declare and initialize variables of different data types
            int age = 25;
            float height = 5.8f;
            double weight = 68.5;
            bool isStudent = true;
            char grade = 'A';
            string name = "John Doe";

            // Outputting variables
            Console.WriteLine($"Name: {name} \n, Age: {age} \n, Height: {height} \n," +
                $" Weight: {weight} \n, Student: {isStudent} \n, Grade: {grade}");

            // Task 2: Operators
            // Arithmetic operators
            int x = 10;
            int y = 5;
            int result1 = x + y;
            int result2 = x - y;
            int result3 = x * y;
            int result4 = x / y;
            int result5 = x % y;

            Console.WriteLine($"Addition: {result1},\n Subtraction: {result2},\n  " +
                $"Multiplication: {result3},\n Division: {result4},\n Modulus: {result5}");
            // Comparison operators
            
            bool isEqual = (x == y);
            bool isGreater = (x > y);
            bool isLess = (x < y);

            Console.WriteLine($"Equal: {isEqual},\n  Greater: {isGreater},\n  Less: {isLess}");


            // Logical operators
            bool condition1 = true;
            bool condition2 = false;
            bool logicalAnd = condition1 && condition2;
            bool logicalOr = condition1 || condition2;
            bool logicalNot = !condition1;

            Console.WriteLine($"Logical AND: {logicalAnd}, \n Logical OR: {logicalOr} \n, " +
                $"Logical NOT: {logicalNot} ");

            // Bitwise operators
            int a = 5;  // 0101
            int b = 3;  // 0011
            int bitwiseAnd = a & b;  // 0001
            int bitwiseOr = a | b;   // 0111
            int bitwiseXor = a ^ b;  // 0110
            int bitwiseNot = ~a;     // 1010

            Console.WriteLine($"Bitwise AND: {bitwiseAnd} \n, Bitwise OR: {bitwiseOr} \n, " +
                $"Bitwise XOR: {bitwiseXor} \n, Bitwise NOT: {bitwiseNot}");

            // Ternary operator
             int number = 10;
            string message = (number % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine($"Number is {message}");

            // Task 3: Control flow statements
            // If - Else statement
            int num = 10;
            if (num > 0)
            {
                Console.WriteLine("Number is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine("Number is negative.");
            }
            else
            {
                Console.WriteLine("Number is zero.");
            }

            // Switch-case statement
            
            char graded = 'A';
            switch (graded)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                    Console.WriteLine("Good!");
                    break;
                case 'C':
                    Console.WriteLine("Fair!");
                    break;
                default:
                    Console.WriteLine("Needs improvement!");
                    break;
            }
                    // Task 4: Loops
                    // For loop
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"For loop iteration {i}");
                    }

                    // While loop
                    int j = 0;
                    while (j < 5)
                    {
                        Console.WriteLine($"While loop iteration {j}");
                        j++;
                    }

                    // Do-While loop
                    int k = 0;
                    do
                    {
                        Console.WriteLine($"Do-While loop iteration {k}");
                        k++;
                    } while (k < 5);

                    // ForEach loop
                    int[] numbers = { 1, 2, 3, 4, 5 };
                    foreach (int numn in numbers)
                    {
                        Console.WriteLine($"ForEach loop iteration: {num}");
                    }


            //DEmo project
            Console.WriteLine("From calculator");

            CalculatorMethods calculator = new CalculatorMethods();

            Calculator.RunCalculator(calculator);

            
        }
   }
    }


