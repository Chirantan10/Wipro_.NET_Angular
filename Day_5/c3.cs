using System;

// Step 1: PropertyDemo with private value
public class PropertyDemo
{
    private string privateField = "Private Value";
    public int Add(int a, int b)
    {
        return a + b;
    }

    public void ShowPrivateValue()
    {
        Console.WriteLine(privateField);
    }
}

// Step 2: StaticDemo with static constructor, field, and method
public class StaticDemo
{
    public static string StaticField;
    
    // Static constructor
    static StaticDemo()
    {
        StaticField = "Static Constructor";
        Console.WriteLine(StaticField); // To match expected output
    }

    public static void PrintStatic()
    {
        Console.WriteLine("Static Method");
    }

    public static int StaticValue = 10;
}

// Step 3: Static class MathHelper
public static class MathHelper
{
    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int Divide(int a, int b)
    {
        return b != 0 ? a / b : 0;
    }
}

public class Program
{
    public static void Main()
    {
        PropertyDemo pd = new PropertyDemo();
        Console.WriteLine(pd.Add(2, 3)); // 5

        pd.ShowPrivateValue(); // "Private Value"

        // StaticDemo class triggers static constructor on first access
        int value = StaticDemo.StaticValue; // triggers static constructor
        Console.WriteLine(value); // 10

        StaticDemo.PrintStatic(); // "Static Method"

        Console.WriteLine(MathHelper.Multiply(5, 3)); // 15
        Console.WriteLine(MathHelper.Divide(10, 2)); // 5
    }
}
