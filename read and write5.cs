using System;

class Program
{
    static void Main()
    {
        // Taking input for first number
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        // Taking input for second number
        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Adding the two numbers
        int sum = num1 + num2;

        // Printing the output
        Console.WriteLine("Output: " + sum);
    }
}
