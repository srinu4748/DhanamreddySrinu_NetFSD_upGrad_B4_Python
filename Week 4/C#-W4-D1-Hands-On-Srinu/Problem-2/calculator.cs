using System;

public class Calculator
{
    public static void Run()
    {
        int a, b;

        Console.Write("Enter first number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Addition = " + (a + b));
        Console.WriteLine("Subtraction = " + (a - b));
        Console.WriteLine("Multiplication = " + (a * b));
        Console.WriteLine("Division = " + (a / b));
    }
}