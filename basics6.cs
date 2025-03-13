using System;

class Program
{
    static void Main()
    {
        // Input
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Swapping logic
        int temp = num1;
        num1 = num2;
        num2 = temp;

        // Output
        Console.WriteLine("After swapping: " + num1 + "," + num2);
    }
}
