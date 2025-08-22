using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Check Prime Number");
        Console.WriteLine("2. Check Odd Number");
        Console.WriteLine("3. Check Even Number");
        Console.Write("Enter your choice (1/2/3): ");
        
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                if (IsPrime(number))
                    Console.WriteLine(number + " is a Prime Number.");
                else
                    Console.WriteLine(number + " is NOT a Prime Number.");
                break;

            case 2:
                if (number % 2 != 0)
                    Console.WriteLine(number + " is an Odd Number.");
                else
                    Console.WriteLine(number + " is NOT an Odd Number.");
                break;

            case 3:
                if (number % 2 == 0)
                    Console.WriteLine(number + " is an Even Number.");
                else
                    Console.WriteLine(number + " is NOT an Even Number.");
                break;

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
}
