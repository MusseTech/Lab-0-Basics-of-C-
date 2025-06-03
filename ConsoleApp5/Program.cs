using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
     static void Main(string[] args)
    {
        // Task 1: Creating Variables
        var variables = new Variables();
        variables.GetNumbers();

        // Task 2: Looping and Input Validation
        var input = new LoopingAndInput();
        int low = input.GetPositiveNumber("Enter a positive low number: ");
        int high = input.GetHighNumber(low);

        // Task 3: Arrays and File I/0
        var arrays = new Arrays();
        int[] numbers = arrays.CreateNumberArray(low, high);
        arrays.WriteToFile(numbers, "numbers.text");

        // Additional tasks
        int sum = arrays.CalculateSumFromFile("numbers.txt");
        Console.WriteLine($"Sum of numbers: {sum}");

        arrays.PrintPrimes(numbers);

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();

    }
}

