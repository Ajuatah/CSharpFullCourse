using System;

//declaring the namespace 
namespace SimpleCalculator
{
    //naming the class
    class Calculate
    {
        //entry point of program
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Enter First Value:");
            double number1=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Operation (either +, -, *, /):");
            char operation=Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter Second Value");
            double number2=Convert.ToDouble(Console.ReadLine());

            //initialising the answer to 0
            double answer = 0;
            //ensure the operation entered is either +, -, *, /
            bool isOperationValid = true;

            switch (operation)
            {
                case '+':
                    answer = number1 + number2;
                    break;
                case '-':
                    answer = number1 - number2;
                    break;
                case '*':
                    answer = number1 * number2;
                    break;
                case '/':
                    if (number1 == 0)
                    {
                        Console.WriteLine("Error Dividing By 0");
                        isOperationValid = false;
                    }
                    else
                    {
                        answer = number1 / number2;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    isOperationValid = false;
                    break;
            }

            if (isOperationValid)
            {
                Console.WriteLine($"Answer: {answer}");
            }

            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }
    }
}