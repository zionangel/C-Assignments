using System;

class Program
{
    static void Main()
    {
        // Taking character input
        Console.Write("Enter a symbol: ");
        char input = Convert.ToChar(Console.ReadLine());

        // Checking the input type
        if ("aeiou".Contains(input))  // Check if it's a lowercase vowel
        {
            Console.WriteLine("It is a lowercase vowel.");
        }
        else if (char.IsDigit(input)) // Check if it's a digit
        {
            Console.WriteLine("It is a digit.");
        }
        else // Any other symbol
        {
            Console.WriteLine("It is another symbol.");
        }
    }
}
