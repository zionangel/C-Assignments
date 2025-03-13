using System;

class Program
{
    static void Main()
    {
        float floatValue = 12.34F; // Declaring a float variable
        decimal decimalValue = (decimal)floatValue; // Converting float to decimal

        Console.WriteLine("Float Value: " + floatValue);
        Console.WriteLine("Converted Decimal Value: " + decimalValue);
    }
}
