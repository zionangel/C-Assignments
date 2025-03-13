using System;

class Program
{
    static void Main()
    {
        // Taking input for first number
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Taking input for second number
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Taking input for operation
        Console.Write("Enter an operation (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());

        double result = 0;

        // Performing the operation
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }

        // Printing the result
        Console.WriteLine($"{num1} {operation} {num2} = {result}");
    }
}
