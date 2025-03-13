using System;

class Program
{
    static void Main()
    {
        // Taking password input
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        // Converting to character array
        char[] passwordChars = password.ToCharArray();

        // Converting back to string
        string passwordString = new string(passwordChars);

        // Printing the output
        Console.WriteLine("Password: " + passwordString);
    }
}
