using ConsoleApp5;
using System;

public class Program
{
    public static void Main()
    {
        try
        {
            var c1 = new Circle(1); // Test case 1: Positive radius
            Console.WriteLine(c1);
        }
        catch (InvalidRadiusException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }

        try
        {
            // Test case 2: Negative radius
            var c2 = new Circle(-1);
            Console.WriteLine(c2);
        }
        catch (InvalidRadiusException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }

        try
        {
            // Test case 3: Zero radius
            var c3 = new Circle(0);
            Console.WriteLine(c3);
        }
        catch (InvalidRadiusException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}

