using System;

class Program
{
    static void Main(string[] args)
    {
        int num1, num2;

        // Input validation for first number
        Console.WriteLine("Enter the first number:");
        while (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer:");
        }

        // Input validation for second number
        Console.WriteLine("Enter the second number:");
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer:");
        }

        // Arithmetic operations
        int sum = num1 + num2;
        int difference = num1 - num2;
        int product = num1 * num2;

        // Use double for quotient
        bool divisionByZero = (num2 == 0);
        double quotient = 0;
        if (!divisionByZero)
        {
            quotient = (double)num1 / num2; // Use floating-point division
        }

        // Output
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The difference is: " + difference);
        Console.WriteLine("The product is: " + product);

        if (!divisionByZero)
        {
            Console.WriteLine("The quotient is: " + quotient);
        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
    }
}