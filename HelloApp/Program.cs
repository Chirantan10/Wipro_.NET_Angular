using System;

class Program
{
    static void Main(string[] args)
    {
        // Print a welcome message
        Console.WriteLine("Hello! What is your name?");

        // Read user input
        string name = Console.ReadLine();

        // Greet the user
        Console.WriteLine("Nice to meet you, " + name + "!");

        // Wait for user to press a key before closing
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

