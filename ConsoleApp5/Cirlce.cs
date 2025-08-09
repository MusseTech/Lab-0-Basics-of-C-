using ConsoleApp5;
using System;

public class Circle
{
    private double radius;

    // Constructor
    public Circle(double radius)
    {
        SetRadius(radius);
    }

    // SetRadius method with validation
    public void SetRadius(double radius)
    {
        if (radius <= 0)
        {
            throw new InvalidRadiusException($"Invalid radius: {radius}"); // Fix: Convert double to string using string interpolation
        }
        this.radius = radius;
    }

    // ToString method
    public override string ToString()
    {
        return $"Circle with radius: {radius}";
    }
}
