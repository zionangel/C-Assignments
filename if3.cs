using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter any alphabet: ");
        char ch = Char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        if (ch >= 'a' && ch <= 'z')
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("The alphabet is a vowel.");
            }
            else
            {
                Console.WriteLine("The alphabet is a consonant.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter an alphabet.");
        }
    }
}
