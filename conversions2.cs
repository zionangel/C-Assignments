using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Value of I: ");
        double doubleValue = Convert.ToDouble(Console.ReadLine());
        
        int intValue = (int)doubleValue; // Explicit Type Conversion
        
        Console.WriteLine("Value of I is " + intValue);
    }
}
